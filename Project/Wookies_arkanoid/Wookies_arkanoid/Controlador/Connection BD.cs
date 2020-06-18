using System.Data;
using Npgsql;

namespace Wookies_arkanoid.Controlador
{
    public class Connection_BD
    {
        private static string host = "localhost",
            database = "arkanoid",
            userId = "postgres",
            password = "melissita1";

        private static string sConnection =
            $"Server={host};Port=1234;User Id={userId};Password={password};Database={database};";

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
 