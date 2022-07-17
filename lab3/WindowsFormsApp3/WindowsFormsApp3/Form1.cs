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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddFruitb_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "shop item number = " + listBox1.Items.Count +
                "\ncart item number = " + listBox2.Items.Count;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) {
                return;
            }
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count;) 
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
            }
    
        }
    }
}
