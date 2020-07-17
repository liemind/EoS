using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data;

namespace Eosweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];

            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;
            }
            List<Noticia> n = new List<Noticia>();
            n = DataNoticia.LeerCinco();

            if (n == null) {
                n = new List<Noticia>();
            }

            return View(n);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Perfil() {
            if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];

            //ver si inicio sesion
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;

                    //cargar el grupo actual
                    //cargar grupos anteriores

                    return View();
            }
            return RedirectToAction("Invitado", "Home");
        }

        /***************
        * PERFIL
        ***************/
        public ActionResult CambiarPass(string anterior, string nuevo) {
            //ver si inicio sesion
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);

                //encripto la pass
                String EPass = Encriptar(anterior);
                if(DataHome.VerificarPass(Rut, EPass)) {
                    String newPass = Encriptar(nuevo);
                    //cambiar pass
                    if(DataUsuario.CambiarPass(u.Rut,newPass)) {
                        TempData["notificacion"] = "La contraseña fue cambiada correctamente. Recibirá un correo electrónico señalando los cambios.";
                        CorreoCambioPass(u);
                        // INICIO LOG
                            HomeController.crearLog(u, "Usuario "+u.Nombre+" cambió su contraseña.");
                        // FIN LOG
                    }
                    else {
                        //no se cambio
                        TempData["notificacion"] = "No pudo cambiarse la contraseña. Inténtelo nuevamente o contacte al administrador.";
                    }
                    return RedirectToAction("Perfil", "Home");
                }
                else {
                    //la pass está mal
                    TempData["notificacion"] = "Las contraseñas no coinciden.";
                }
                    
            }
            return RedirectToAction("Invitado", "Home");
        }

        public ActionResult UnirseAGrupo(string Llave, int Id) {
            return RedirectToAction("Perfil", "Home");
        }

        /***************
        * PERFIL
        ***************/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        /***************
        * PASSWORDS
        ***************/
        // encrypt
        public static string Encriptar(string strData)
        {
            return Convert.ToBase64String(Encriptar(Encoding.UTF8.GetBytes(strData)));
        }

        // decoding
        public static string Desencriptar(string strData)
        {
            return Encoding.UTF8.GetString(Desencriptar(Convert.FromBase64String(strData)));
        }

        // encrypt
        public static byte[] Encriptar(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(Global.strPermutation,
            new byte[] { Global.bytePermutation1,
                         Global.bytePermutation2,
                         Global.bytePermutation3,
                         Global.bytePermutation4
            });
 
            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize/8);
            aes.IV = passbytes.GetBytes(aes.BlockSize/8);
 
            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }
 
        // decrypt
        public static byte[] Desencriptar(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(Global.strPermutation,
            new byte[] { Global.bytePermutation1,
                         Global.bytePermutation2,
                         Global.bytePermutation3,
                         Global.bytePermutation4
            });
 
            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize/8);
            aes.IV = passbytes.GetBytes(aes.BlockSize/8);
 
            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

        //Pass
        public static String GenerarPass() {
          var bytes = new byte[16];
          using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
          {
            rng.GetBytes(bytes);
          }
          string password = BitConverter.ToString(bytes).Replace("-","");
          
          return password;
        }

        /***************
        * PASSWORDS
        ***************/

        /***************
        * SESION
        ***************/
        public IActionResult Invitado()
        {
            if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];
            return View();
        }
        
        public Boolean Sesion() {
            
            Boolean exist = string.IsNullOrEmpty(HttpContext.Session.GetString(Global.SessionKeyName));
            if (exist) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public IActionResult IniciarSesion(String Rut, String Pass) {
            if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];

            string[] w = Rut.Split(".");
            if(w.Length > 1 || w == null) {
                TempData["notificacion"] = "No pudo iniciar sesión debido a que su id de usuario no es correcto.";
            }
            else {
                Usuario u = DataUsuario.LeerUno(Rut);
                if(u.Estado == "Habilitado") {
                    //encripto la pass
                    String EPass = Encriptar(Pass);
                    if(DataHome.VerificarPass(Rut, EPass)) {
                        HttpContext.Session.SetString(Global.SessionKeyName, Rut);
                        // INICIO LOG
                        crearLog(u, "Usuario "+u.Nombre+" inició sesión.");
                        // FIN LOG
                        return RedirectToAction("Index", "Home");
                    }
                    else {
                        TempData["notificacion"] = "No pudo iniciar sesión debido a que su contraseña no es correcta.";
                    }
                }
                else {
                    TempData["notificacion"] = "No pudo iniciar sesión debido a que su cuenta se encuentra bloqueada. Para más información, contacte con el administrador.";
                }
                
            }
            return RedirectToAction("Invitado", "Home");
        }

        public IActionResult CerrarSesion() {
            // INICIO LOG
            String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
            Usuario u = DataUsuario.LeerUno(Rut);
            crearLog(u, "Usuario "+u.Nombre+" cerró sesión.");
            // FIN LOG
            HttpContext.Session.Clear();
            return RedirectToAction("Invitado", "Home");
        }


        /***************
        * Correos
        ***************/

        public void CorreoCambioPass(Usuario u) {
            string body = "<html><head><style type='text/css'>body{color:#777;font-family:'Helvetica Neue',Roboto,Arial,'Droid Sans',sans-serif;font-size:13px;font-weight:400;line-height:1.471;background-color:#f7f7f7}.bg{margin:0 auto;width:500px;border:1px solid #e6e9ed;background-color:#fff}.image{background-color:#272727;padding-top:20px;padding-bottom:20px}.image>center>img{width:30%;text-align:center}.content{padding:10px}h2{font-size:18px!important;font-weight:400!important;color:#272727;border-bottom:2px solid #e6e9ed;margin-bottom:10px}.footer{text-align:center;padding-top:10px;padding-bottom:5px}a{font-weight:600!important;color:#337ab7}td{background-color:#e6e9ed}table,td,th{border:1px solid #ddd;padding:8px;line-height:1.42857143;vertical-align:top;border-collapse:collapse}</style></head><body><div class='bg'><div class='image'><center><img src='https://i.imgur.com/HrMODiU.png'></center></div><div class='content'><h2>¡Cambio de contraseña!</h2><p>¡Hola "+u.Nombre+"!. Si recibes este correo electrónico es porque has cambiado la contraseña en <b>EOS3</b>. Para acceder a ella basta con entrar al <a href='http://168.232.165.145/'>enlace</a> de la plataforma e ingresar tus credenciales:</p><center><table><tr><th>Nombre de usuario</th><td>tu rut sin puntos ni digito verificador</td></tr><tr><th>Contraseña</th><td>Tu nueva contraseña</td></tr></table></center><p>Si tienes problemas con tu cuenta, no dudes en consultar al administrador del curso.</p><p>Atentamente,<br><i>El equipo de EOS3</i></p></div><div class='footer'><a href='#'>Dar de baja</a> | <a href='https://www.utalca.cl/'>Universidad de Talca</a> | <a href='http://168.232.165.145/Home/About'>Ayuda</a></div></div></body> </html>";

            HomeController.Send(u.CorreoElectronico, "¡Cambio de contraseña!", body);
        }

        public static void Send(string to, string Subject, string body)
        {
            MailMessage o = new MailMessage(Global.Email, to, Subject, body);
            o.IsBodyHtml = true;

            NetworkCredential netCred = new NetworkCredential(Global.Email, Global.Pass);
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = netCred;
            cliente.Send(o);
        }

        /***************
        * Correos
        ***************/
        public static void crearLog(Usuario u, String Accion) {
            Log log = new Log();
            log.autor = u;
            log.accion = Accion;
            log.fecha = DateTime.Now;
            if(DataUsuario.CrearLog(log)) {
                //wena choro :v
            }
        }
        
    }
}
