using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eosweb.Models;
using Eosweb.Data;
using Microsoft.AspNetCore.Http;


namespace Eosweb.Controllers
{
    public class UsuariosController : Controller
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
                    
                    List<Usuario> finalUsuarios = DataUsuario.LeerTodo();
                    if (finalUsuarios == null)
                    {
                        finalUsuarios = new List<Usuario>();
                    }

                    return View(finalUsuarios);
            }
            return RedirectToAction("Invitado", "Home");
        }

        public ActionResult Crear(String Rut, String Nombre, String Correo, String Tipo) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);
                //content
                Usuario usuario = new Usuario();
                usuario.Rut = Rut;
                usuario.CorreoElectronico = Correo;
                usuario.Nombre = Nombre;
                usuario.Tipo = Tipo;

                //Encriptar Pass
                String pass = HomeController.GenerarPass();
                String passE = HomeController.Encriptar(pass);
                usuario = DataUsuario.Crear(usuario, passE);

                if(usuario == null) {
                    TempData["notificacion"] = "No pudo crearse al usuario.";
                }
                else {
                    //mandar correo
                    CorreoCreacionCuenta(usuario,pass);
                    TempData["notificacion"] = "El usuario ha sido creado. Recibirá un correo electrónico con las instrucciones para poder acceder al sistema.";
                    // INICIO LOG
                    Usuario u = DataUsuario.LeerUno(RutSesion);
                    HomeController.crearLog(u, "Usuario "+u.Nombre+" creó un nuevo usuario llamado "+usuario.Nombre+".");
                    // FIN LOG
                }
                //end content
                return RedirectToAction("Index", "Usuarios");
            }
            return RedirectToAction("Invitado", "Home");
        }

        public ActionResult HabilitarDeshabilitar(string Rut, int estadoActual) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);
                //content
                if(Rut != null) {
                    if (DataUsuario.HabilitarDeshabilitar(Rut, estadoActual))
                    {
                        Usuario usuario = DataUsuario.LeerUno(Rut);
                        //mostrar alerta de que funciono
                        TempData["Notificacion"] = "La operación fue realizada.";
                        CorreoDeshabilitarHabilitarCuenta(usuario,estadoActual);
                        // INICIO LOG
                        Usuario u = DataUsuario.LeerUno(RutSesion);
                        if(estadoActual == 1) {
                            HomeController.crearLog(u, "Usuario "+u.Nombre+" deshabilitó al usuario "+usuario.Nombre+".");
                        }
                        else {
                            HomeController.crearLog(u, "Usuario "+u.Nombre+" habilitó al usuario "+usuario.Nombre+".");
                        }
                        // FIN LOG
                    }
                    else
                    {
                        //mostrar alerta de que no.
                        TempData["Notificacion"] = "La operación no pudo ser realizada.";
                    }
                }
                //end content
                return RedirectToAction("Index", "Usuarios");
            }
            return RedirectToAction("Invitado", "Home");

        }

        public ActionResult ReiniciarPass(String Rut) {
            if (Sesion() == true) {
                String RutSesion = HttpContext.Session.GetString(Global.SessionKeyName);
                //content
                if(Rut != null) {
                    String pass = HomeController.GenerarPass();
                    String passE = HomeController.Encriptar(pass);

                    if (DataUsuario.CambiarPass(Rut,passE))
                    {
                        Usuario usuario = DataUsuario.LeerUno(Rut);
                        CorreoReinicioPass(usuario, pass);
                        //mostrar alerta de que funciono
                        TempData["notificacion"] = "La contraseña del usuario ha sido reiniciado. Recibirá un correo electrónico con las instrucciones para poder acceder al sistema.";
                        // INICIO LOG
                        Usuario u = DataUsuario.LeerUno(RutSesion);
                        HomeController.crearLog(u, "Usuario "+u.Nombre+" reinicio la contraseña del usuario "+usuario.Nombre+".");
                        // FIN LOG
                    }
                    else
                    {
                        //mostrar alerta de que no.
                        TempData["Notificacion"] = "La operación no pudo ser realizada.";
                    }
                }
                //end content
                return RedirectToAction("Index", "Usuarios");
            }
            return RedirectToAction("Invitado", "Home");
        }
        public IActionResult Acciones()
        {
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;

                    List<Log> logs = DataUsuario.LeerTodoLog();
                    if (logs == null)
                    {
                        logs = new List<Log>();
                    }
                    return View(logs);
            }
            return RedirectToAction("Invitado", "Home");
        }

        public IActionResult Grupos()
        {
            if (Sesion() == true) {
                String Rut = HttpContext.Session.GetString(Global.SessionKeyName);
                ViewData["Sesion"] = true;
                Usuario u = DataUsuario.LeerUno(Rut);
                    //poned acá más datos de usuario en caso de necesitarlos
                    ViewData["Tipo"] = u.Tipo;
                    ViewData["NombreUsuario"] = u.Nombre;
                    ViewData["IdUsuario"] = u.Rut;

                    //return View();
                    return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Invitado", "Home");
        }


        /********
        * Correos
        ********/
        public void CorreoCreacionCuenta(Usuario u, string pass) {
            string body = "<html><head><style type='text/css'>body{color:#777;font-family:'Helvetica Neue',Roboto,Arial,'Droid Sans',sans-serif;font-size:13px;font-weight:400;line-height:1.471;background-color:#f7f7f7}.bg{margin:0 auto;width:500px;border:1px solid #e6e9ed;background-color:#fff}.image{background-color:#272727;padding-top:20px;padding-bottom:20px}.image>center>img{width:30%;text-align:center}.content{padding:10px}h2{font-size:18px!important;font-weight:400!important;color:#272727;border-bottom:2px solid #e6e9ed;margin-bottom:10px}.footer{text-align:center;padding-top:10px;padding-bottom:5px}a{font-weight:600!important;color:#337ab7}td{background-color:#e6e9ed}table,td,th{border:1px solid #ddd;padding:8px;line-height:1.42857143;vertical-align:top;border-collapse:collapse}</style></head><body><div class='bg'><div class='image'><center><img src='https://i.imgur.com/HrMODiU.png'></center></div><div class='content'><h2>¡Bienvenido a EOS3!</h2><p>Si recibes este correo electrónico es porque se te ha creado una cuenta de usuario en <b>EOS3</b>. Para acceder a ella basta con entrar al <a href='http://168.232.165.145/'>enlace</a> de la plataforma e ingresar tus credenciales:</p><center><table><tr><th>Nombre de usuario</th><td>tu rut sin puntos ni digito verificador</td></tr><tr><th>Contraseña</th><td>"+pass+"</td></tr></table></center><p>Si tienes problemas con tu cuenta, no dudes en consultar al administrador del curso.</p><p>Atentamente,<br><i>El equipo de EOS3</i></p></div><div class='footer'><a href='#'>Dar de baja</a> | <a href='https://www.utalca.cl/'>Universidad de Talca</a> | <a href='http://168.232.165.145/Home/About'>Ayuda</a></div></div></body> </html>";

            HomeController.Send(u.CorreoElectronico, "¡Bienvenido a Eos3!", body);
        }

        public void CorreoReinicioPass(Usuario u, string pass) {
            string body = "<html><head><style type='text/css'>body{color:#777;font-family:'Helvetica Neue',Roboto,Arial,'Droid Sans',sans-serif;font-size:13px;font-weight:400;line-height:1.471;background-color:#f7f7f7}.bg{margin:0 auto;width:500px;border:1px solid #e6e9ed;background-color:#fff}.image{background-color:#272727;padding-top:20px;padding-bottom:20px}.image>center>img{width:30%;text-align:center}.content{padding:10px}h2{font-size:18px!important;font-weight:400!important;color:#272727;border-bottom:2px solid #e6e9ed;margin-bottom:10px}.footer{text-align:center;padding-top:10px;padding-bottom:5px}a{font-weight:600!important;color:#337ab7}td{background-color:#e6e9ed}table,td,th{border:1px solid #ddd;padding:8px;line-height:1.42857143;vertical-align:top;border-collapse:collapse}</style></head><body><div class='bg'><div class='image'><center><img src='https://i.imgur.com/HrMODiU.png'></center></div><div class='content'><h2>¡Reinicio de Contraseña!</h2><p>¡Hola "+u.Nombre+"!. Si recibes este correo electrónico es porque se te reiniciado la cuenta en <b>EOS3</b>. Para acceder a ella basta con entrar al <a href='http://168.232.165.145/'>enlace</a> de la plataforma e ingresar tus credenciales:</p><center><table><tr><th>Nombre de usuario</th><td>tu rut sin puntos ni digito verificador</td></tr><tr><th>Contraseña</th><td>"+pass+"</td></tr></table></center><p>Si tienes problemas con tu cuenta, no dudes en consultar al administrador del curso.</p><p>Atentamente,<br><i>El equipo de EOS3</i></p></div><div class='footer'><a href='#'>Dar de baja</a> | <a href='https://www.utalca.cl/'>Universidad de Talca</a> | <a href='http://168.232.165.145/Home/About'>Ayuda</a></div></div></body> </html>";

            HomeController.Send(u.CorreoElectronico, "¡Reinicio de contraseña!", body);
        }

        public void CorreoDeshabilitarHabilitarCuenta(Usuario u, int estadoActual) {
            if(estadoActual == 1) {
                string body = "<html><head><style type='text/css'>body{color:#777;font-family:'Helvetica Neue',Roboto,Arial,'Droid Sans',sans-serif;font-size:13px;font-weight:400;line-height:1.471;background-color:#f7f7f7}.bg{margin:0 auto;width:500px;border:1px solid #e6e9ed;background-color:#fff}.image{background-color:#272727;padding-top:20px;padding-bottom:20px}.image>center>img{width:30%;text-align:center}.content{padding:10px}h2{font-size:18px!important;font-weight:400!important;color:#272727;border-bottom:2px solid #e6e9ed;margin-bottom:10px}.footer{text-align:center;padding-top:10px;padding-bottom:5px}a{font-weight:600!important;color:#337ab7}td{background-color:#e6e9ed}table,td,th{border:1px solid #ddd;padding:8px;line-height:1.42857143;vertical-align:top;border-collapse:collapse}</style></head><body><div class='bg'><div class='image'><center><img src='https://i.imgur.com/HrMODiU.png'></center></div><div class='content'><h2>¡Tu cuenta ha sido deshabilitada :(!</h2><p>¡Hola "+u.Nombre+"!. Si recibes este correo electrónico es porque se ha deshabilitado tu cuenta en <b>EOS3</b>. Si tienes problemas con tu cuenta, no dudes en consultar al administrador del curso.</p><p>Atentamente,<br><i>El equipo de EOS3</i></p></div><div class='footer'><a href='#'>Dar de baja</a> | <a href='https://www.utalca.cl/'>Universidad de Talca</a> | <a href='http://168.232.165.145/Home/About'>Ayuda</a></div></div></body> </html>";
                HomeController.Send(u.CorreoElectronico, "¡Tu cuenta ha sido deshabilitada!", body);
            }
            else {
                string body = "<html><head><style type='text/css'>body{color:#777;font-family:'Helvetica Neue',Roboto,Arial,'Droid Sans',sans-serif;font-size:13px;font-weight:400;line-height:1.471;background-color:#f7f7f7}.bg{margin:0 auto;width:500px;border:1px solid #e6e9ed;background-color:#fff}.image{background-color:#272727;padding-top:20px;padding-bottom:20px}.image>center>img{width:30%;text-align:center}.content{padding:10px}h2{font-size:18px!important;font-weight:400!important;color:#272727;border-bottom:2px solid #e6e9ed;margin-bottom:10px}.footer{text-align:center;padding-top:10px;padding-bottom:5px}a{font-weight:600!important;color:#337ab7}td{background-color:#e6e9ed}table,td,th{border:1px solid #ddd;padding:8px;line-height:1.42857143;vertical-align:top;border-collapse:collapse}</style></head><body><div class='bg'><div class='image'><center><img src='https://i.imgur.com/HrMODiU.png'></center></div><div class='content'><h2>¡Tu cuenta ha sido habilitada :D!</h2><p>¡Hola "+u.Nombre+"!. Si recibes este correo electrónico es porque se ha habilitado tu cuenta en <b>EOS3</b>. Si tienes problemas con tu cuenta, no dudes en consultar al administrador del curso.</p><p>Atentamente,<br><i>El equipo de EOS3</i></p></div><div class='footer'><a href='#'>Dar de baja</a> | <a href='https://www.utalca.cl/'>Universidad de Talca</a> | <a href='http://168.232.165.145/Home/About'>Ayuda</a></div></div></body> </html>";
                HomeController.Send(u.CorreoElectronico, "¡Tu cuenta ha sido habilitada!", body);
            }
            
        }

        /********
        * SESION
        ********/
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
    }
}