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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtBookAuthor.Text != "" && txtPublication.Text != "" && txtBookPrice.Text != "" && txtBookQuantity.Text != "")
            {

                String bname = txtBookName.Text;
                String bauthor = txtBookAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                int price = int.Parse(txtBookPrice.Text);
                int quan = int.Parse(txtBookQuantity.Text);
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook(bName, bAuthor, bPubl, bPDate, bPrice, bQuan)" +
                    " values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Date Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtBookAuthor.Clear();
                txtPublication.Clear();
                txtBookPrice.Clear();
                txtBookQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field not allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data.","Are you sure?",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
