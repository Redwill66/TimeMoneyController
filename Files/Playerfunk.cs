using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeMoneyController
{
    class Playerfunk
    {
        public void Register(string Name, string Surname, string Email, string Passw)
        {
            PlaGaDBfunk PlaGaDB = new PlaGaDBfunk();
            var connn = PlaGaDB.NewUser();


            connn.Parameters.AddWithValue("@Name", Name);
            connn.Parameters.AddWithValue("@Surname", Surname);
            connn.Parameters.AddWithValue("@Email", Email);
            connn.Parameters.AddWithValue("@Password", Passw);
     
            connn.ExecuteNonQuery();
        }
        public bool Login(string Email, string Passw)
        {
            bool isUserExisted = false;
            //string Suc = "Willkommen";
            PlaGaDBfunk Timedb = new PlaGaDBfunk();
            SqlCommand connn = Timedb.LogUser();
            // SqlDataReader reader;
            // reader = connn.ExecuteReader();


            connn.Parameters.AddWithValue("@Email", Email);
            connn.Parameters.AddWithValue("@Password", Passw);
            SqlDataReader dr = connn.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    isUserExisted = true;
                    break;
                }

            }
            return isUserExisted;
            // reader = connn.ExecuteReader();

            // connn.ExecuteNonQuery();


            //   return Suc;

        }
    }
}
