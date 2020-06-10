using System;
using System.Collections.Generic;
using System.Data;
using Wookies_arkanoid.Controlador;

namespace Wookies_arkanoid.TOP10
{
    public class TopClassDAO
    {
         public static List<userScore> getScores()
        {
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
    }
}