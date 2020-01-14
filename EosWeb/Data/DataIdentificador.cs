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

        }

        public static Identificador Leer(int Id) {

        }

        public static Boolean Eliminar(int Id) {

        }

        public static Boolean Modificar(Identificador i) {
            
        }

    }
}