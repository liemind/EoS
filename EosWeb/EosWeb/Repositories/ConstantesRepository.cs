using EosWeb.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EosWeb.Repositories
{
    public class ConstantesRepository
    {
        public static int Crear(Constantes constantes)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_constantes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = constantes.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_A", Direction = System.Data.ParameterDirection.Input, Value = constantes.A });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_B", Direction = System.Data.ParameterDirection.Input, Value = constantes.B });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_C", Direction = System.Data.ParameterDirection.Input, Value = constantes.C });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_D", Direction = System.Data.ParameterDirection.Input, Value = constantes.D });
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