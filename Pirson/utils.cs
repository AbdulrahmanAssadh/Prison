using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Pirson
{
   public class utils
    {

       public static OleDbConnection con;
       public static OleDbDataAdapter d1, d2, d3, d4,d5,d6;
       public static OleDbCommandBuilder com1, com2, com3, com4,com5,com6;
       public static DataSet ds;
      
       public static BindingSource bs1, bs2, bs3, bs4,bs5,bs6;

        public static string name_prison;
        public static string id_prison;


    }
}
