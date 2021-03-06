﻿using System.Data;
using Npgsql;

namespace Wookies_arkanoid.Controlador
{
    public class Connection_BD
    {
        private static string host = "localhost",
            database = "Arkanoid",
            userId = "postgres",
            password = "uca";
        private static string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";
        public static DataTable ExecuteQuery(string query)
        {
              
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
              
            connection.Open();
              
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,connection);
            da.Fill(ds);
              
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
    }
}  
 