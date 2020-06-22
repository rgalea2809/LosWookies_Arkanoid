using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador;

namespace Wookies_arkanoid.TOP10
{
    //Top 10 DATA ACCESS OBJECT
    public class TopClassDAO
    {
         public static List<userScore> getScores()
        {
            //Returns all of the saved scores in the DB
            string sql = String.Format(
                "SELECT * FROM  top");
            
            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<userScore> scoreBoard = new List<userScore>();
            foreach (DataRow fila in dt.Rows)
            {
                userScore user = new userScore();
                user.nickname = fila[0].ToString();
                user.playerscore = Convert.ToInt32(fila[1].ToString());

                scoreBoard.Add(user);
            }
            return scoreBoard;
        }

         public static void AddtoScoreboard(string nickname, int score)
         {
             //Adds score to db
             try
             {
                 Connection_BD.ExecuteNonQuery($"INSERT INTO top VALUES('{nickname}', {score})");

             }
             catch (Exception exception)
             {
                 Console.WriteLine("Ha ocurrido un error");
             }
         }
    }
}