using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyGenerator
{
    class DBconnect
    {

        private static DBconnect instance = null;

        MySqlConnection conn;

        private DBconnect()
        {
            this.conn = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
        }

        public static DBconnect getInstance()
        {
            if (instance == null)
            {
                DBconnect.instance = new DBconnect();
            }

            return DBconnect.instance;

        }
        public void insert(string key)
        {

            this.conn.Open();
            var command = new MySqlCommand("INSERT INTO llaves (`id`) VALUES (\"" + key + "\");", this.conn);
            command.ExecuteNonQuery();

            this.conn.Close();

        }

    }
}
