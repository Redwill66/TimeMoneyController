﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeMoneyController
{
    class NewGameFunk
    {
        public void CreateFormel(decimal MoneyTimeRech, string Genre, string Email)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.NewFormel();


            connn.Parameters.AddWithValue("@MoneyTimeRech", MoneyTimeRech);
            connn.Parameters.AddWithValue("@Genre", Genre);
            connn.Parameters.AddWithValue("@Email", Email);

            connn.ExecuteNonQuery();
        }
        public void AddPlatt(string Platt)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.NewPL();


            connn.Parameters.AddWithValue("@Plattform", Platt);
         

            connn.ExecuteNonQuery();
        }
        public DataTable LoadPlatt()
        {
            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            using (var conn = dbClass.Platt())
            {

                DataTableFunk dataTablesFunktions = new DataTableFunk();
                SqlDataReader reader;
                reader = conn.ExecuteReader();

                DataTable dt = dataTablesFunktions.dt();


                dt.Load(reader);

                return dt;
            }



        }
        public DataTable LoadGenre(string Email)
        {
            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            using (var conn = dbClass.Genre())
            {
                conn.Parameters.AddWithValue("@Email", Email);
                DataTableFunk dataTablesFunktions = new DataTableFunk();
                SqlDataReader reader;
                reader = conn.ExecuteReader();

                DataTable dt = dataTablesFunktions.dt();


                dt.Load(reader);

                return dt;
            }



        }
        string mul;
        public string Multipli(string Email, string Genre)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            using (var conn = dbClass.Multiplo())
            {
                conn.Parameters.AddWithValue("@Email", Email);
                conn.Parameters.AddWithValue("@Genre", Genre);
                DataTableFunk dataTablesFunktions = new DataTableFunk();
                SqlDataReader reader;
                reader = conn.ExecuteReader();
                //string mul = conn.ToString();
                DataTable dt3 = dataTablesFunktions.dt3();
                //  conn
                while (reader.Read())
                {
                    mul = reader[0].ToString();
                }
                // dt3.Load(reader);

                return mul;
            }




        }
        public void CreateGame(string Name, string Genre )
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.NewGame();
            connn.Parameters.AddWithValue("@Game", Name);
            connn.Parameters.AddWithValue("@Genre", Genre);
            connn.ExecuteNonQuery();
        }
        public void CreateGame2(string Name, string Platt)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.NewGame2();
            connn.Parameters.AddWithValue("@Game", Name);
            connn.Parameters.AddWithValue("@Plattform", Platt);
            connn.ExecuteNonQuery();
        }
    
        public void CreateGame3(string Name, decimal Price,int PlayTime, string Email,int Bewertung, decimal Result, bool Finish, string Wertung)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.NewGame3();
            connn.Parameters.AddWithValue("@Bewertung", Bewertung);
            connn.Parameters.AddWithValue("@Price", Price);
            connn.Parameters.AddWithValue("@PlayTime", PlayTime);
            connn.Parameters.AddWithValue("@Finish", Finish);
            connn.Parameters.AddWithValue("@Email", Email);
            connn.Parameters.AddWithValue("@Game", Name);
            connn.Parameters.AddWithValue("@Result", Result);
            connn.Parameters.AddWithValue("@Wertung", Wertung);

            connn.ExecuteNonQuery();
        }
        public void UpdateBill( string Email)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.UpdateBilanz();
            
            connn.Parameters.AddWithValue("@Email", Email);
            connn.ExecuteNonQuery();
        }
        public bool GameCheck(string Game)
        {
            bool isUserExisted = false;
            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.GameExist();
            cmd.Parameters.AddWithValue("@Game", Game);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    isUserExisted = true;
                    break;
                }

            }
            return isUserExisted;
        }
        public bool GameCheck2(string Game, string Email)
        {
            bool isUserExisted = false;
            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.GameExist2();
            cmd.Parameters.AddWithValue("@Game", Game);
            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    isUserExisted = true;
                    break;
                }

            }
            return isUserExisted;
        }
        public void UpdateEi(string Name, decimal Price, int PlayTime, string Email, int Bewertung, decimal Result, bool Finish, string Wertung)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.UpdateGame();


            connn.Parameters.AddWithValue("@Game", Name);
            connn.Parameters.AddWithValue("@Price", Price);
            connn.Parameters.AddWithValue("@Email", Email);
            connn.Parameters.AddWithValue("@PlayTime", PlayTime);
            connn.Parameters.AddWithValue("@Bewertung", Bewertung);
            connn.Parameters.AddWithValue("@Result", Result);
            connn.Parameters.AddWithValue("@Finish", Finish);
            connn.Parameters.AddWithValue("@Wertung", Wertung);
            connn.ExecuteNonQuery();
        }
        public DataTable Grid(string Email)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            using (var conn = dbClass.Rang())
            {
        
                conn.Parameters.AddWithValue("@Email", Email);
               
                DataTableFunk dataTablesFunktions = new DataTableFunk();
                SqlDataReader reader;
                reader = conn.ExecuteReader();

                DataTable dt = dataTablesFunktions.Grids();


                dt.Load(reader);

                return dt;
                //cboAbsence.Items.Add("Keine Asenze");




            }
        }
        string MaxTime;
        public string MaXT( string Email)
        {
            
            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.MaxTime();
           
            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    MaxTime = dr[0].ToString();
                }

            }
            return MaxTime;
        }
        string AvgTime;
        public string AvgT(string Email)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.AvgTime();

            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    AvgTime = dr[0].ToString();
                }

            }
            return AvgTime;
        }
        string Bilanz;
        public string BilanzPlayer(string Email)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.Bilanz();

            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    Bilanz = dr[0].ToString();
                }

            }
            return Bilanz;
        }
        string MaxMoney;
        public string MaXM(string Email)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.MaxMoney();

            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    MaxMoney = dr[0].ToString();
                }

            }
            return MaxMoney;
        }
        string AVGMoney;
        public string AvgM(string Email)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.AVGMoney();

            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    AVGMoney = dr[0].ToString();
                }

            }
            return AVGMoney;
        }
        string CountGame;
        public string CGame(string Email)
        {

            PlaGaDBfunk dbClass = new PlaGaDBfunk();
            SqlCommand cmd = dbClass.Games();

            cmd.Parameters.AddWithValue("@Email", Email);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    CountGame = dr[0].ToString();
                }

            }
            return CountGame;
        }
    }
}
