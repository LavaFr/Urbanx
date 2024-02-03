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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // THIS CODE GIVES ALL DATABASE ENTRIES ON BUTTON CLICK

        /*  private void button1_Click(object sender, EventArgs e)  
          {
              try
              {
                  string connstring = "server=localhost;uid=root;pwd=UrbanXfortnite48492;database=urbanlogin";  // Connection to a datatbase (urbanlogin)
                  MySqlConnection con = new MySqlConnection();
                  con.ConnectionString = connstring;
                  con.Open();
                  string sql = "select * from email3";   //selecting data from the email3 table
                  MySqlCommand cmd = new MySqlCommand(sql, con);
                  MySqlDataReader reader = cmd.ExecuteReader();
                  while (reader.Read()) // while loop goes through every single one.
                  {
                      MessageBox.Show("Name " + reader["username"] + " Email " + reader["email"]);  // speaks for itself, printing the columns
                  }

              }
              catch (MySqlException ex) 
              {
                  MessageBox.Show(ex.ToString());
              }

          }
         */


        private void button2_Click(object sender, EventArgs e)
        {
            string server = "localhost";         // next 4 is basic info for connecting
            string uid = "root";
            string password = "UrbanXfortnite48492";
            string database = "urbanlogin";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;  //more complicated version of connection|
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string query = "insert into email3(username,email,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();



            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Error fill out all boxes");
            }
            else
            {
                var newform = new homeform();
                newform.Show();
                this.Hide();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newform = new homeform();
            newform.Show();
            this.Hide();
        }
    }
}

