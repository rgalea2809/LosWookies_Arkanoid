using System;
using System.Collections.Generic;
using System.Data;
using Wookies_arkanoid.Controlador;

namespace Wookies_arkanoid.TOP10
{
    public class TopClassDAO
    {
         public static List<TopClass> topget1()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 1");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget2()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 2");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget3()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 3");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget4()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 4");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget5()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 5");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget6()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 6");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget7()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 7");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget8()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 8");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget9()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 9");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
        
        public static List<TopClass> topget10()
        {
            string sql = String.Format(
                "select nickname , playerscore FROM top WHERE idposition = 10");


            DataTable dt = Connection_BD.ExecuteQuery(sql);

            List<TopClass> score = new List<TopClass>();
            foreach (DataRow fila in dt.Rows)
            {
                TopClass p = new TopClass();

                p.nickname = fila[0].ToString();
                p.playerscore = Convert.ToInt32(fila[1].ToString());

                score.Add(p);

            }

            return score;
        }
    }
}