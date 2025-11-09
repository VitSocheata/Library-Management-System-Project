using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Library
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will exit your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtEnroll.Clear();
            txtStudentSemester.Clear();
            txtDepartament.Clear();
            txtStudentContact.Clear();
            txtStudentEmail.Clear();
            //txtStudentEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "" && txtEnroll.Text != "" && txtDepartament.Text != "" && txtStudentSemester.Text != "" && txtStudentContact.Text != "" && txtStudentEmail.Text != "")
            {
                String name = txtStudentName.Text;
                String enroll = txtEnroll.Text;
                String dep = txtDepartament.Text;
                String sem = txtStudentSemester.Text;
                int mobile = int.Parse(txtStudentContact.Text);
                String email = txtStudentEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent(sname,enroll,dep,sem,contact,email) " +
                                  "values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "','" + mobile + "','" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudentName.Clear();
                txtEnroll.Clear();
                txtStudentSemester.Clear();
                txtDepartament.Clear();
                txtStudentContact.Clear();
                txtStudentEmail.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill Empty Field", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
