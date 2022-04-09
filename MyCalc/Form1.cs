using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double firstnum, secondnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }    

            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }

        }

        private void BtnCC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            String f, s;

            f = Convert.ToString(firstnum);
            s = Convert.ToString(secondnum);

            s = "0";
            f = "0";

        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void BS(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
