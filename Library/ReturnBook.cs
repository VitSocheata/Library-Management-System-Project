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

namespace Library
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String eid = txtEnroll.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
        

            cmd.CommandText = "select * from IRBook where std_enroll = '" + txtEnroll.Text + "' and book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            txtEnroll.Clear();
        }

        String bname;
        String bdate;
        int rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBName.Text = bname;
            txtISD.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            String eid = txtEnroll.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOCHEATA\\SQLEXPRESS04; Initial Catalog = Library; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date  = '"+dateTimePicker2.Text+"' where std_enroll = '"+txtEnroll.Text+"' and id = "+rowid+" ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Succesful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ReturnBook_Load(this, null);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the return process? Any unsaved data will be lost.", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
        }
    }
}
