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
        public SqlCommand ChangeUser()
        {
            string conns = ("Update Player Set Name = @Name,  Surname = @Surname,  Email = @Email,  Password = @Password where Email= @ExEmail");
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
        public SqlCommand NewGame()
        {
            string conns = ("INSERT INTO Game (Game,GeId) VALUES(@Game,( Select Id From Genre where Genre = @Genre))");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand NewGame2()
        {
            string conns = ("INSERT INTO Plattform_Game (PaId,GId) VALUES(( Select Id From Plattform where Plattform = @Plattform),( Select Id From Game where Game = @Game))");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand NewGame3()
        {
            string conns = ("INSERT INTO Player_Formel_Game (Bewertung,Price,PlayTime,Finish,PId,GId,Result,WId) VALUES(@Bewertung,@Price,@PlayTime,@Finish,( Select Id From Player where Email = @Email),( Select Id From Game where Game = @Game),@Result,( Select Id From Wertung where Wertung = @Wertung))");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand UpdateBilanz()
        {
            string conns = ("Update Player Set Bilanz = (Select SUM(Result)/ Count(Result) From Player_Formel_Game) where Email= @Email");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand GameExist()
        {
            string conns = ("Select Game from Game where Game=@Game ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
       
        public SqlCommand GameExist2()
        {
            string conns = (" Select PId,GId" + " from Player_Formel_Game" + " LEFT Join Player" + " ON Player_Formel_Game.PId = Player.Id" + " Left Join Game" + " ON Player_Formel_Game.GId = Game.Id " + " WHERE  Email = @Email And Game = @Game");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand UpdateGame()
        {
            string conns = ("Update Player_Formel_Game Set Bewertung = @Bewertung,  Price= @Price,  PlayTime= @PlayTime,  Finish= @Finish, Result=@Result, WId=( Select Id From Wertung where Wertung = @Wertung) where Gid=( Select Id From Game where Game = @Game) and PId =( Select Id From Player where Email = @Email)");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
      
       
        public SqlCommand Rang()
        {
            string conns = (" Select Game, Plattform, Genre,Price,PlayTime,Result,Bewertung,Wertung,Finish " + "From Player_Formel_Game " + " LEFT Join Game" + " ON Player_Formel_Game.GId = Game.Id" + " Left Join Wertung" + " ON Player_Formel_Game.WId = Wertung.Id " + " Left Join Genre" + " ON Game.GeId = Genre.Id " + " Left Join Plattform_Game" + " ON Game.Id = Plattform_Game.GId" + " Left Join Plattform" + " ON Plattform_Game.PaId = Plattform.Id" + " Left Join Player" + " ON Player_Formel_Game.GId = Player.Id" + " WHERE Player_Formel_Game.PId =( Select Id From Player where Email = @Email) ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand MaxTime()
        {
            string conns = ("Select Sum(PlayTime) from Player_Formel_Game " + " LEFT Join Player" + " ON Player_Formel_Game.PId = Player.Id" + " where Email=@Email ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand AvgTime()
        {
            string conns = ("Select AVG(PlayTime) from Player_Formel_Game " + " LEFT Join Player" + " ON Player_Formel_Game.PId = Player.Id" + " where Email=@Email ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand Bilanz()
        {
            string conns = ("Select Bilanz from Player where Email=@Email ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand MaxMoney()
        {
            string conns = ("Select Sum(Price) from Player_Formel_Game " + " LEFT Join Player" + " ON Player_Formel_Game.PId = Player.Id" + " where Email=@Email ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand AVGMoney()
        {
            string conns = ("Select AVG(Price) from Player_Formel_Game " + " LEFT Join Player" + " ON Player_Formel_Game.PId = Player.Id" + " where Email=@Email ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand Games()
        {
            string conns = ("Select Count(Player_Formel_Game.Id) from Player_Formel_Game " + " LEFT Join Player" + " ON Player_Formel_Game.PId = Player.Id" + " where Email=@Email ");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
    }
}
