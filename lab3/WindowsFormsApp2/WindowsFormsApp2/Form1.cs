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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int c = 1;
            Double B = Convert.ToInt32(txtRate.Text) * 0.01;
            Double y = Math.Pow((1 + B), 10);
            Double z = Convert.ToInt32(txtAmount.Text) *y;
            for (Double i = Convert.ToInt32(txtAmount.Text); i <= 1000000;) {
                c++;
                Double w = Math.Pow((1 + B), c);
                i = Convert.ToInt32(txtAmount.Text) * w;
                
            }
            
            lblValue2.Text = Convert.ToString(z);
            lblMillion2.Text = Convert.ToString(c);
        }
    }
}
