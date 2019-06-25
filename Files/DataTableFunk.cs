using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeMoneyController
{
    class DataTableFunk
    {
        public DataTable dt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Plattform", typeof(string));
            dt.Columns.Add("Id", typeof(int));
        //    dt.Rows.Add("Keine Absenze");
            return dt;
        }
        public DataTable dt2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("MoneyTimeRech", typeof(decimal));
        
          
            //    dt.Rows.Add("Keine Absenze");
            return dt;
        }
        public DataTable dt3()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
         
            dt.Columns.Add("MoneyTimeRech", typeof(decimal));


            //    dt.Rows.Add("Keine Absenze");
            return dt;
        }
        public DataTable Grids()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Game", typeof(string));
            dt.Columns.Add("Plattform", typeof(string));
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("PlayTime", typeof(int));
            dt.Columns.Add("Result", typeof(decimal));
            dt.Columns.Add("Bewertung", typeof(int));
            dt.Columns.Add("Wertung", typeof(string));
            dt.Columns.Add("Finish", typeof(bool));
            dt.Columns["Game"].ReadOnly = true;
            dt.Columns["Plattform"].ReadOnly = true;
            dt.Columns["Genre"].ReadOnly = true;
            dt.Columns["Price"].ReadOnly = true;
            dt.Columns["PlayTime"].ReadOnly = true;
            dt.Columns["Result"].ReadOnly = true;
            dt.Columns["Bewertung"].ReadOnly = true;
            dt.Columns["Wertung"].ReadOnly = true;
            dt.Columns["Finish"].ReadOnly = true;
            return dt;
        }
    }
}
