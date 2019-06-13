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
    }
}
