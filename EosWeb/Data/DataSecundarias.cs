using System;
using System.Collections.Generic;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataSecundarias
    {
        public static Boolean Crear(Secundarias c) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_secundarias_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_A", Direction = System.Data.ParameterDirection.Input, Value = c.A });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_B", Direction = System.Data.ParameterDirection.Input, Value = c.B });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_C", Direction = System.Data.ParameterDirection.Input, Value = c.C });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tmin_k", Direction = System.Data.ParameterDirection.Input, Value = c.Tmin_k });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tmax_k", Direction = System.Data.ParameterDirection.Input, Value = c.Tmax_k });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static List<Secundarias> LeerTodo() {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_secundarias_leer_todo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Secundarias> c = new List<Secundarias>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var comp = new Secundarias()
                        {
                            Id = Convert.ToInt32(prodData["id"]),
                            A = Convert.ToDouble(prodData["A"]),
                            B = Convert.ToDouble(prodData["B"]),
                            C = Convert.ToDouble(prodData["C"]),
                            Tmin_k = Convert.ToInt32(prodData["tmin_k"]),
                            Tmax_k = Convert.ToInt32(prodData["tmax_k"])
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

        public static Secundarias Leer(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leer_secundarias", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = Id });
                var datos = DataSource.GetDataSet(command);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    var comp = new Secundarias()
                    {
                        A = Convert.ToDouble(prodData["A"]),
                        B = Convert.ToDouble(prodData["B"]),
                        C = Convert.ToDouble(prodData["C"]),
                        Tmin_k = Convert.ToInt32(prodData["tmin_k"]),
                        Tmax_k = Convert.ToInt32(prodData["tmax_k"])
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
            return null;
        }

        public static Boolean Eliminar(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_secundarias_eliminar", CommandType = System.Data.CommandType.StoredProcedure };
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

        public static Boolean Modificar(Secundarias c) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_secundarias_modificar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = c.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_A", Direction = System.Data.ParameterDirection.Input, Value = c.A });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_B", Direction = System.Data.ParameterDirection.Input, Value = c.B });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_C", Direction = System.Data.ParameterDirection.Input, Value = c.C });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tmin_k", Direction = System.Data.ParameterDirection.Input, Value = c.Tmin_k });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tmax_k", Direction = System.Data.ParameterDirection.Input, Value = c.Tmax_k });
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