using System;
using System.Collections.Generic;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataIdentificador
    {
        public static Boolean Crear(Identificador i) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_identificador_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_compuesto", Direction = System.Data.ParameterDirection.Input, Value = i.Compuesto });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_formula", Direction = System.Data.ParameterDirection.Input, Value = i.Formula });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_m", Direction = System.Data.ParameterDirection.Input, Value = i.M });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static List<Identificador> LeerTodo() {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_identificador_leer_todo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Identificador> i = new List<Identificador>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var comp = new Identificador()
                        {
                            Id = Convert.ToInt32(prodData["id"]),
                            Compuesto = prodData["compuesto"].ToString(),
                            Formula = prodData["formula"].ToString(),
                            M = Convert.ToDouble(prodData["m"])
                        };
                        
                        i.Add(comp);
                    }
                }
                return i;
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

        public static Identificador Leer(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leer_identificador", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = Id });
                var datos = DataSource.GetDataSet(command);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    var comp = new Identificador()
                    {
                        Compuesto = prodData["compuesto"].ToString(),
                        Formula = prodData["formula"].ToString(),
                        M = Convert.ToDouble(prodData["m"])
                    };
                    comp.Id = Id;
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
                var command = new MySqlCommand() { CommandText = "sp_identificador_eliminar", CommandType = System.Data.CommandType.StoredProcedure };
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

        public static Boolean Modificar(Identificador i) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_identificador_modificar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = i.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_compuesto", Direction = System.Data.ParameterDirection.Input, Value = i.Compuesto });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_formula", Direction = System.Data.ParameterDirection.Input, Value = i.Formula });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_m", Direction = System.Data.ParameterDirection.Input, Value = i.M });
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