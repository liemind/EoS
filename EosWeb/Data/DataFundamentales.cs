using System;
using System.Collections.Generic;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataFundamentales
    {
        public static Boolean Crear(Fundamentales c) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_fundamentales_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = c.Id});
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tc_k", Direction = System.Data.ParameterDirection.Input, Value = c.Tc_K });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_pc_bar", Direction = System.Data.ParameterDirection.Input, Value = c.Pc_bar });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_zc", Direction = System.Data.ParameterDirection.Input, Value = c.Zc });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_w", Direction = System.Data.ParameterDirection.Input, Value = c.W });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static List<Fundamentales> LeerTodo() {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_fundamentales_leer_todo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Fundamentales> c = new List<Fundamentales>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var comp = new Fundamentales()
                        {
                            Id = Convert.ToInt32(prodData["id"]),
                            Tc_K = Convert.ToDouble(prodData["tc_k"]),
                            Pc_bar = Convert.ToDouble(prodData["pc_bar"]),
                            Zc = Convert.ToDouble(prodData["zc"]),
                            W = Convert.ToDouble(prodData["w"])
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

        public static Fundamentales Leer(int Id) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_leer_fundamentales", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = Id });
                var datos = DataSource.GetDataSet(command);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    var comp = new Fundamentales()
                    {
                        Tc_K = Convert.ToDouble(prodData["tc_k"]),
                        Pc_bar = Convert.ToDouble(prodData["pc_bar"]),
                        Zc = Convert.ToDouble(prodData["zc"]),
                        W = Convert.ToDouble(prodData["w"])
                    };
                    comp.Id = Id;
                    //Inicio Identificador
                    comp.i = DataIdentificador.Leer(Id);
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
                var command = new MySqlCommand() { CommandText = "sp_fundamentales_eliminar", CommandType = System.Data.CommandType.StoredProcedure };
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

        public static Boolean Modificar(Fundamentales c) {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_fundamentales_modificar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = c.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tc_k", Direction = System.Data.ParameterDirection.Input, Value = c.Tc_K });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_pc_bar", Direction = System.Data.ParameterDirection.Input, Value = c.Pc_bar });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_zc", Direction = System.Data.ParameterDirection.Input, Value = c.Zc });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_w", Direction = System.Data.ParameterDirection.Input, Value = c.W });
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