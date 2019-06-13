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
        public SqlCommand NewFormel()
        {
            string conns = ("INSERT INTO Genre (MoneyTimeRech,Genre,PID) VALUES(@MoneyTimeRech,@Genre,( Select Id From Player where Email = @Email))");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand NewPL()
        {
            string conns = ("INSERT INTO Plattform (Plattform) VALUES(@Plattform)");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand Platt()
        {
            string conns = ("Select Id, Plattform from Plattform");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }

        }
        //string conns = (" select AbsenceReason, sum(Timespan)  from Stamp_User_Absence " + " LEFT Join User_Absence ON Stamp_User_Absence.UAId  = User_Absence.Id  " + " Left Join Stamp ON Stamp_User_Absence.[SId] = Stamp.id " + " Left  Join [User] ON User_Absence.[UId] = [User].[Id] " + " Left Join [Absence] ON User_Absence.AId = Absence.Id " + "where Not AbsenceReason ='null' And Email =@Email And  (DATEPART(mm, StampAnw) = @Day) " + " Group by AbsenceReason ");
          //  using (var conn = new SqlCommand(conns, Conect()))
           // {
        public SqlCommand Genre()
        {
            string conns = ("Select Genre,MoneyTimeRech from Genre" + " LEFT Join Player ON Genre.PId  = Player.Id " + "where Email = @Email");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }

        }
        public SqlCommand Multiplo()
        {
            string conns = ("Select MoneyTimeRech from Genre" + " LEFT Join Player ON Genre.PId  = Player.Id " + "where Email = @Email and Genre = @Genre");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }

        }
    }
}
