using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLApp
{
    public class SQLUtils
    {

        //Constructeur
        public SQLUtils()
        {
        }
        public MySqlConnection GetDBConnection()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=testdatabase; UID=root; PASSWORD=root";
            return new MySqlConnection(connectionString);
        }


    }
}
