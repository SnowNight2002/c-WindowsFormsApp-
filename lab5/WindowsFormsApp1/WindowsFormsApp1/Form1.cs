using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libDataSet.Books);

            libDataSetTableAdapters.BooksTableAdapter ta =
              new libDataSetTableAdapters.BooksTableAdapter();

            libDataSet.BooksDataTable booksTable =
              new libDataSet.BooksDataTable();

            ta.Fill(booksTable);

            dgvBooks.DataSource = booksTable;

            libDataSetTableAdapters.UsersTableAdapter taUsers =
                new libDataSetTableAdapters.UsersTableAdapter();

            libDataSet.UsersDataTable usersTable =
                new libDataSet.UsersDataTable();

            taUsers.Fill(usersTable);

            dgvUsers.DataSource = usersTable;

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();

        }
    }
}
