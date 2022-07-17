using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void cloudy_CheckedChanged(object sender, EventArgs e)
        {
            piccloudy.Visible = true;
            picrainy.Visible = false;
            picsnowy.Visible = false;
            picsunny.Visible = false;
            Message.Text = "It’s going to be a cloudy day today," + TN.Text + ".";
        }

        private void rainy_CheckedChanged(object sender, EventArgs e)
        {
            piccloudy.Visible = false;
            picrainy.Visible = true;
            picsnowy.Visible = false;
            picsunny.Visible = false;
            Message.Text = "It’s going to be a rainy day today," + TN.Text + ".";
        }

        private void snowy_CheckedChanged(object sender, EventArgs e)
        {
            piccloudy.Visible = false;
            picrainy.Visible = false;
            picsnowy.Visible = true;
            picsunny.Visible = false;
            Message.Text = "It’s going to be a snowy day today," + TN.Text + ".";
        }

        private void sunny_CheckedChanged(object sender, EventArgs e)
        {
            piccloudy.Visible = false;
            picrainy.Visible = false;
            picsnowy.Visible = false;
            picsunny.Visible = true;
            Message.Text = "It’s going to be a sunny day today," + TN.Text + ".";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

