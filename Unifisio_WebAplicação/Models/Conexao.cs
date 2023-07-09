using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unifisio_WebAplicação.Models
{
    public class Conexao:IDisposable
    {
        public MySqlConnection conn;
        public readonly string server = "Localhost";
        public readonly string port = "3306";
        public readonly string db = "db_fisioterapia";
        public readonly string user = "root";
        public readonly string pass = "Kjkszpj@19";

        public Conexao()
        {
            Conectar();
        }

        private void Conectar()
        {
            string StrConn = "";
            StrConn = "Server= " + server + "; Port= " + port + "; Database= " + db + "; Uid= " + user + "; Pwd= " + pass;
            conn = new MySqlConnection(StrConn);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}