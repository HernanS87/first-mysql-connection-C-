using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto_Terciario.Datos
{
    public class Usuario
    {
        // este metodo retorna una tabla con la info
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                // este comando es un elemento que almacena el nombre del procedure y la referencia a la db

                comando.CommandType = CommandType.StoredProcedure;


                //ahora definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                sqlCon.Open();
                resultado = comando.ExecuteReader(); // alamacenamos la respuesta
                tabla.Load(resultado); //cargamos la tabla con el resultado

                return tabla;
            } 
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
