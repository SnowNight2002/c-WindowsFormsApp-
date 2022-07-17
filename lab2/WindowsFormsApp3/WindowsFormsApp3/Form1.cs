using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "The following item is added: " + txtName.Text;
            lstStudents.Items.Add(txtName.Text);
            txtName.Clear();
        }


        private void frmStudents_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");
        }

        private void lstStudents_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "The following item is selected: "+ lstStudents.SelectedItem;
        }

        private void lblDelete_DoubleClick(object sender, EventArgs e)
        {
            lblMessage.Text = "The following item is deleted: " + lstStudents.SelectedItem;
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }
    }
}
