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
    public partial class homeform : Form
    {
        public homeform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
            this.Hide();
        }
    }
}
