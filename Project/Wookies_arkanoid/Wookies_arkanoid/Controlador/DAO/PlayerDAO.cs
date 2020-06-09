using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;

namespace Wookies_arkanoid.Controlador.DAO
{
    public class PlayerDAO
    {
        public static List<Player> getPlayers()
        {
            string query = "SELECT * FROM players";
            DataTable dt = Connection_BD.ExecuteQuery(query: query);
            List<Player> lista = new List<Player>();
            foreach (DataRow fila in dt.Rows)
            {
                Player u = new Player();
                u.nickname = fila[0].ToString();
                u.password = fila[1].ToString();
                lista.Add(u);
            }
            return lista;
        }


        public static bool addUser(Player u)
        {
            try
            {
                string nQ = $"INSERT INTO players(nickname, password) VALUES(" +
                            $"'{u.nickname}', " +
                            $"'{u.password}')";
                Connection_BD.ExecuteNonQuery(nQ);
                MessageBox.Show($"Player '{u.nickname}' added correctly. " +
                                $"May the force be with you, young padawan");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
                return false;
            }
        }

        public static void changePassword(Player u, string newPassword)
        {
            try
            {
                string nQ = $"UPDATE players SET password = '{newPassword}' WHERE nickname = '{u.nickname}' ";
                Connection_BD.ExecuteNonQuery(nQ);
                MessageBox.Show($"Updated Password successfully. Be careful Padawan!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }
    }
}