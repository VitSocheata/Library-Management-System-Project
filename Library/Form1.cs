using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/socheata.783273");
        }

        private void pictureBoxPinterest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pinterest.com/anita_sct");
        }

        private void pictureBoxInstragram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/annitaa_nine/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(); 
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where username = '"+txtUsername.Text+"' and pass = '"+txtPassword.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard das = new Dashboard();
                das.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
