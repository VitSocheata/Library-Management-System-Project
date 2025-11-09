using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Comfirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewwBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs =new AddBooks();
            abs.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent asd =new AddStudent();
            asd.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentView sv = new StudentView();
            sv.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook isb = new IssueBook();
            isb.Show();

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBook sb = new CompleteBook();
            sb.Show();
        }
    }
}
