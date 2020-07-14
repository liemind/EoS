using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataNoticia
    {
        public static List<Noticia> LeerTodo()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leertodas_noticia", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Noticia> noticias = new List<Noticia>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var d = new Noticia()
                        {
                            id = Convert.ToInt32(prodData["id"]),
                            titulo = prodData["titulo"].ToString(),
                            cuerpo = prodData["cuerpo"].ToString(),
                            fecha = Convert.ToDateTime(prodData["fecha"])
                        };
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(prodData["autor"]);
                        usuario = DataUsuario.LeerPorId(usuario.Id);
                        d.autor = usuario;
                        noticias.Add(d);
                    }
                }
                return noticias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
            return null;
        }

        public static Noticia LeerUno(int Id)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leer_noticia", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = Id });
                var datos = DataSource.GetDataSet(command);
                Noticia d = null;

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    d = new Noticia()
                        {
                            id = Convert.ToInt32(prodData["id"]),
                            titulo = prodData["titulo"].ToString(),
                            cuerpo = prodData["cuerpo"].ToString(),
                            fecha = Convert.ToDateTime(prodData["fecha"])
                        };
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(prodData["autor"]);
                        usuario = DataUsuario.LeerPorId(usuario.Id);
                        d.autor = usuario;
                }
                return d;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
            return null;

        }

        public static List<Noticia> LeerCinco()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leercinco_noticia", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Noticia> noticias = new List<Noticia>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var d = new Noticia()
                        {
                            id = Convert.ToInt32(prodData["id"]),
                            titulo = prodData["titulo"].ToString(),
                            cuerpo = prodData["cuerpo"].ToString(),
                            fecha = Convert.ToDateTime(prodData["fecha"])
                        };
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(prodData["autor"]);
                        usuario = DataUsuario.LeerPorId(usuario.Id);
                        d.autor = usuario;
                        noticias.Add(d);
                    }
                }
                return noticias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
            return null;
        }

        public static Boolean Crear(Noticia n)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_crear_noticia", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_titulo", Direction = System.Data.ParameterDirection.Input, Value = n.titulo});
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_cuerpo", Direction = System.Data.ParameterDirection.Input, Value = n.cuerpo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_fecha", Direction = System.Data.ParameterDirection.Input, Value = n.fecha });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_autor", Direction = System.Data.ParameterDirection.Input, Value = n.autor.Id });
                var datos = DataSource.ExecuteProcedure(command);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }



        public static Boolean Modificar(Noticia n)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_modificar_noticia", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = n.id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_titulo", Direction = System.Data.ParameterDirection.Input, Value = n.titulo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_cuerpo", Direction = System.Data.ParameterDirection.Input, Value = n.cuerpo });
                var datos = DataSource.ExecuteProcedure(command);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static Boolean Eliminar(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_eliminar_noticia", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = Id });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


    }
}