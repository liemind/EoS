using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eosweb.Models;
using MySql.Data.MySqlClient;

namespace Eosweb.Data
{
    public class DataHome
    {
        public static string[] VerificarPass(string Rut, string Pass)
        {
            string[] arr = new string[2];
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_verificar_pass", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_rut", Direction = System.Data.ParameterDirection.Input, Value = Rut });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_pass", Direction = System.Data.ParameterDirection.Input, Value = Pass });
                var datos = DataSource.GetDataSet(command);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    var prodData = datos.Tables[0].Rows[0];
                    String PassBD = prodData["password"].ToString();
                    if(PassBD == Pass) {
                        arr[0] = "1";
                        arr[1] = "Las pass coinciden";
                        return arr;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                arr[0] = "0";
                arr[1] = ex.ToString();
                return arr;
                //return false;
            }
            finally
            {

            }
            arr[0] = "0";
            arr[1] = "Las pass no coinciden";
            return arr;

        }
    
        public static Boolean CambiarPass(string Rut, string Pass){
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_cambiar_pass_usuario", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_rut", Direction = System.Data.ParameterDirection.Input, Value = Rut });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_password", Direction = System.Data.ParameterDirection.Input, Value = Pass });
                var datos = DataSource.GetDataSet(command);

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

        
    }
}