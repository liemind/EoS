using EosWeb.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EosWeb.Repositories
{
    public class IdentificadorRepository
    {
        public static int Crear(Identificador identificador)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_identificador_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_formula", Direction = System.Data.ParameterDirection.Input, Value = identificador.Formula });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_m", Direction = System.Data.ParameterDirection.Input, Value = identificador.M });
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