using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //assign data
            dataGridView1.DataSource = ds.Tables[0];
        }
        int stuid;
        int rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                stuid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where stuid = " + stuid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepartament.Text = ds.Tables[0].Rows[0][3].ToString();
            txtStudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
            txtStudentContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtStudentEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated. Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String name = txtStudentName.Text;
                String enroll = txtEnroll.Text;
                String dep = txtDepartament.Text;
                String sem = txtStudentSemester.Text;
                String mobile = txtStudentContact.Text;
                String email = txtStudentEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update NewStudent set sname='" + name + "', enroll='" + enroll + "', dep='" + dep + "', sem='" + sem + "', contact='" + mobile + "', email='" + email + "' where stuid=" + rowid + "";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent where enroll Like '" + txtStudentSearch.Text + "%'";
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
                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //assign data
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtStudentSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data will be delete. Comfirmation Dialog", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04 ; Initial Catalog = Library;  Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete from NewStudent where stuid = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
