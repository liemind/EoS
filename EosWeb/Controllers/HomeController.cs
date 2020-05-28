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

        public ActionResult CambiarPass(string anterior, string nuevo, int id) {
            return RedirectToAction("Perfil", "Home");
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
            //if (TempData.ContainsKey("Notificacion")) ViewBag.Notificacion = TempData["Notificacion"];

            string[] w = Rut.Split(".");
            if(w.Length > 1) {
                //TempData["notificacion"] = "No pudo iniciar sesión debido a que su id de usuario no es correcto.";
            }
            else {
                //encripto la pass
                String EPass = Encriptar(Pass);
                if(DataHome.VerificarPass(Rut, EPass)) {
                    HttpContext.Session.SetString(Global.SessionKeyName, Rut);
                    return RedirectToAction("Index", "Home");
                }
                else {
                    //TempData["notificacion"] = "No pudo iniciar sesión debido a que su contraseña no es correcta.";
                }
            }
            return RedirectToAction("Invitado", "Home");
        }

        public IActionResult CerrarSesion() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


    }
}
