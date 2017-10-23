using EosWeb.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EosWeb.Repositories
{
    public class SecundariasRepository
    {
        public static int Crear(Secundarias secundarias)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_secundarias_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = secundarias.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_A", Direction = System.Data.ParameterDirection.Input, Value = secundarias.A });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_B", Direction = System.Data.ParameterDirection.Input, Value = secundarias.B });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_C", Direction = System.Data.ParameterDirection.Input, Value = secundarias.C });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tmin_k", Direction = System.Data.ParameterDirection.Input, Value = secundarias.Tmin_k });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tmax_k", Direction = System.Data.ParameterDirection.Input, Value = secundarias.Tmax_k });
                var datos = DataSource.ExecuteProcedure(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
            finally
            {

            }
            return 1;
        }


    }
}