using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace dataHP
{
    internal class connection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;

            try
            {
                string sConnstring = "server=localhost; uid=root; password=; database=db_sekolah";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
        
    }
}
