using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataUsuario
    {
        public static List<Usuario> LeerTodo()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leertodas_usuario", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);
                int estado = 1;
                int tipo = 1;

                List<Usuario> usuarios = new List<Usuario>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var comp = new Usuario()
                        {
                            Rut = prodData["rut"].ToString(),
                            Nombre = prodData["nombre"].ToString(),
                            CorreoElectronico = prodData["correoElectronico"].ToString()
                        };
                        estado = Convert.ToInt32(prodData["estado"]);
                        if (estado == 1)
                        {
                            comp.Estado = "Habilitado";
                        }
                        else
                        {
                            comp.Estado = "Deshabilitado";
                        }
                        tipo = Convert.ToInt32(prodData["tipo"]);
                        if (tipo == 1)
                        {
                            comp.Tipo = "Administrador";
                        }
                        else
                        {
                            comp.Tipo = "Alumno";
                        }
                        usuarios.Add(comp);
                    }
                }
                return usuarios;
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

        public static Usuario LeerUno(string Rut)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leer_usuario", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_rut", Direction = System.Data.ParameterDirection.Input, Value = Rut });
                var datos = DataSource.GetDataSet(command);
                int estado = 1;
                int tipo = 1;

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    var comp = new Usuario()
                    {
                        Rut = prodData["rut"].ToString(),
                        Nombre = prodData["nombre"].ToString(),
                        CorreoElectronico = prodData["correoElectronico"].ToString()
                    };
                    estado = Convert.ToInt32(prodData["estado"]);
                    if (estado == 1)
                    {
                        comp.Estado = "Habilitado";
                    }
                    else
                    {
                        comp.Estado = "Deshabilitado";
                    }
                    tipo = Convert.ToInt32(prodData["tipo"]);
                    if (tipo == 1)
                    {
                        comp.Tipo = "Administrador";
                    }
                    else
                    {
                        comp.Tipo = "Alumno";
                    }
                    return comp;
                }

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

        public static Boolean HabilitarDeshabilitar(String rut, int EstadoActual)
        {
            int estado;
            if (EstadoActual == 0)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }

            try
            {
                var command = new MySqlCommand() { CommandText = "sp_habilitar_deshabilitar_usuario", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_rut", Direction = System.Data.ParameterDirection.Input, Value = rut });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = estado });
                var datos = DataSource.ExecuteProcedure(command);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {

            }
        }

        public static Usuario Crear(Usuario usuario, string pass)
        {
            int tipo;
            if (usuario.Tipo == "Administrador")
            {
                tipo = 1;
            }
            else
            {
                tipo = 2;
            }

                try
            {
                var command = new MySqlCommand() { CommandText = "sp_crear_usuario", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_rut", Direction = System.Data.ParameterDirection.Input, Value = usuario.Rut});
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_nombre", Direction = System.Data.ParameterDirection.Input, Value = usuario.Nombre });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_correoElectronico", Direction = System.Data.ParameterDirection.Input, Value = usuario.CorreoElectronico });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tipo", Direction = System.Data.ParameterDirection.Input, Value = tipo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_password", Direction = System.Data.ParameterDirection.Input, Value = pass});
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = 1 });
                var datos = DataSource.ExecuteProcedure(command);

                return usuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static Boolean Modificar(Usuario usuario)
        {
            int tipo;
            if (usuario.Tipo == "Administrador")
            {
                tipo = 1;
            }
            else
            {
                tipo = 2;
            }

            try
            {
                var command = new MySqlCommand() { CommandText = "sp_modificar_usuario", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_rut", Direction = System.Data.ParameterDirection.Input, Value = usuario.Rut });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_nombre", Direction = System.Data.ParameterDirection.Input, Value = usuario.Nombre });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_correoElectronico", Direction = System.Data.ParameterDirection.Input, Value = usuario.CorreoElectronico });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tipo", Direction = System.Data.ParameterDirection.Input, Value = tipo });
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