using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schap_bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
               this.errorProvider1.SetError(ctr, "this is not avalid number");
                btneurtovnd.Enabled = false;
                btnusdtovnd.Enabled = false;
                btnvndtoeur.Enabled = false;
                btnvndtousd.Enabled = false;
            }     
            else
            {
                this.errorProvider1.Clear();
                btneurtovnd.Enabled = true;
                btnusdtovnd.Enabled = true;
                btnvndtoeur.Enabled= true;
                btnvndtousd.Enabled= true;
                

            }
                this.errorProvider1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btneurtovnd.Enabled=false;
            btnusdtovnd.Enabled=false;
            btnvndtoeur.Enabled =false;
            btnvndtousd.
        }

        private void btnvndtousd_Click(object sender, EventArgs e)
        {

        }
    }
}
