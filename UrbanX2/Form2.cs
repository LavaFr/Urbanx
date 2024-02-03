using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanX2
{
    public partial class Form2 : Form
    {
        DB dB= new DB();


        public Form2()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Please Enter Username.", "required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                MessageBox.Show("Please Enter password.", "required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
                return;
            }
            string query = string.Concat("SELECT COUNT(*) FROM email3 where username= '", this.textBox1.Text, "'and password= '", this.textBox2.Text, "'");
            if (Convert.ToInt16(dB.QueryScalar(query)) <= 0)
            {

                MessageBox.Show("Username or password is incorrect. Please try again");
                return;
            }
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();



        }
    }
}
