using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UrbanX2
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            string server = "localhost";         // next 4 is basic info for connecting
            string uid = "root";
            string password = "UrbanXfortnite48492";
            string database = "urbanlogin";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;  //more complicated version of connection|
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();


          


        }
    }
}
