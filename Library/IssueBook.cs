using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook",con);
            SqlDataReader dr = cmd .ExecuteReader();

            while (dr.Read()) { 
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            con.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtStudentEnroll.Text != "")
            {
                String eid = txtStudentEnroll.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select * from NewStudent where enroll = '"+eid+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll  = '" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0) 
                {
                    txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepartament.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();      
                }
                else
                {
                    txtStudentName.Clear();
                    txtDepartament.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Enrollment No","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
                String enroll = txtStudentEnroll.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";

                con.Open();
                SqlCommand cmd1 = new SqlCommand("select count(*) from IRBook where std_enroll='" + enroll + "'", con);
                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();

                if (comboBoxBooks.SelectedIndex != -1 && count < 3) // fixed condition here
                {
                    String sname = txtStudentName.Text;
                    String sdep = txtDepartament.Text;
                    String sem = txtSemester.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker1.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) " +
                                      "values ('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book OR Maximum number of books has been issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the issue process? Any unsaved data will be lost.", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtStudentEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtStudentEnroll.Text == "")
            {
                txtStudentName.Clear();
                txtDepartament.Clear();
                txtSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear();

            }
        }
    }
}
