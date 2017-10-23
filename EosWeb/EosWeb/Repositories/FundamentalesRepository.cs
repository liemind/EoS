using EosWeb.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EosWeb.Repositories
{
    public class FundamentalesRepository
    {
        public static int Crear(Fundamentales constantes)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_constantes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_id", Direction = System.Data.ParameterDirection.Input, Value = constantes.Id });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_tc_k", Direction = System.Data.ParameterDirection.Input, Value = constantes.Tc_K });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_pc_bar", Direction = System.Data.ParameterDirection.Input, Value = constantes.Pc_bar });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_zc", Direction = System.Data.ParameterDirection.Input, Value = constantes.Zc });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_w", Direction = System.Data.ParameterDirection.Input, Value = constantes.W });
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