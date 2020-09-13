using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace POO3B3E47.DAL
{
    public class DALBD
    {
        private string ConnectionString = "Persist Security info=false; server=localhost; database=bd_Gravadora; user=root; pwd=;";
        private MySqlConnection connection;

        public void Connect()
        {
            try
            {
                connection = new MySqlConnection(ConnectionString);
                connection.Open();
            }
            catch (MySqlException error)
            {
                throw new Exception($"Não foi possível conectar ao banco. {error.Message}");
            }
        }

        public void execCommand(string sql)
        {
            try
            {
                Connect();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                throw new Exception($"Não foi possível executar comando. {error.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable execQuery(string sql)
        {
            try
            {
                Connect();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(sql, connection);
                data.Fill(dataTable);
                return dataTable;
            }
            catch (MySqlException error)
            {
                throw new Exception($"Não foi possível executar comando. {error.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
}