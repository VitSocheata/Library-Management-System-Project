using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //assign data
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        int bid;
        int rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewBook where bid = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBookAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPdate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtBookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();



            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //    txtBookName.Text = row.Cells[1].Value.ToString();
            //    txtBookAuthor.Text = row.Cells[2].Value.ToString();
            //    txtPublication.Text = row.Cells[3].Value.ToString();
            //    txtPdate.Text = row.Cells[4].Value.ToString();
            //    txtBookPrice.Text = row.Cells[5].Value.ToString();
            //    txtBookQuantity.Text = row.Cells[6].Value.ToString();


            //    bid = int.Parse(row.Cells[0].Value.ToString());
            //}



        }

        private void txtBookView_TextChanged(object sender, EventArgs e)
        {
            if(txtBookView.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewBook where bName Like '"+txtBookView.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //assign data
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //assign data
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtBookView.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated. Comfirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {

                String bname = txtBookName.Text;
                String bauthor = txtBookAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = txtPdate.Text;
                int price = int.Parse(txtBookPrice.Text);
                int quan = int.Parse(txtBookQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "update NewBook set bName = '" + bname + "' ,bAuthor = '" + bauthor + "',bPubl='" + publication + "',  bPDate = '" + pdate + "',bPrice = " + price + ",bQuan = " + quan + " where bid = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Data Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be delete. Comfirmation Dialog", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete from NewBook where bid = "+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
