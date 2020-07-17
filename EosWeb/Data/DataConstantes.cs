using System;
using System.Collections.Generic;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataConstantes
    {
        public static Boolean Crear(Constantes c) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_constantes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = c.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_A", Direction = System.Data.ParameterDirection.Input, Value = c.A });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_B", Direction = System.Data.ParameterDirection.Input, Value = c.B });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_C", Direction = System.Data.ParameterDirection.Input, Value = c.C });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_D", Direction = System.Data.ParameterDirection.Input, Value = c.D });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static List<Constantes> LeerTodo() {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_constantes_leer_todo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Constantes> c = new List<Constantes>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var comp = new Constantes()
                        {
                            Id = Convert.ToInt32(prodData["id"]),
                            A = Convert.ToDouble(prodData["A"]),
                            B = Convert.ToDouble(prodData["B"]),
                            C = Convert.ToDouble(prodData["C"]),
                            D = Convert.ToDouble(prodData["D"])
                        };

                        //Inicio Identificador
                        comp.i = DataIdentificador.Leer(comp.Id);
                        //Fin Identificador
                        
                        c.Add(comp);
                    }
                }
                return c;
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

        public static Constantes Leer(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leer_constantes", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = Id });
                var datos = DataSource.GetDataSet(command);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    var comp = new Constantes()
                    {
                        A = Convert.ToDouble(prodData["A"]),
                        B = Convert.ToDouble(prodData["B"]),
                        C = Convert.ToDouble(prodData["C"]),
                        D = Convert.ToDouble(prodData["D"])
                    };
                    comp.Id = Id;
                    //Inicio Identificador
                    comp.i = DataIdentificador.Leer(comp.Id);
                    //Fin Identificador

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

        public static Boolean Eliminar(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_constantes_eliminar", CommandType = System.Data.CommandType.StoredProcedure };
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

        public static Boolean Modificar(Constantes c) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_constantes_modificar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = c.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_A", Direction = System.Data.ParameterDirection.Input, Value = c.A });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_B", Direction = System.Data.ParameterDirection.Input, Value = c.B });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_C", Direction = System.Data.ParameterDirection.Input, Value = c.C });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_D", Direction = System.Data.ParameterDirection.Input, Value = c.D });
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