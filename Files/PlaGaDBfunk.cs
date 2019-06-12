using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeMoneyController
{
    class PlaGaDBfunk
    {
        private static string cs = Properties.Settings.Default.ConnectionString;
        public SqlConnection Conect()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            return con;
        }
        public SqlCommand NewUser()
        {
            string conns = ("INSERT INTO Player(Name, Surname, Email, Password) VALUES(@Name, @Surname, @Email, @Password)");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand LogUser()
        {
            string conns = (" Select Name, Surname, Email, Password from Player where Email=@Email and Password= @Password ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
    }
}
