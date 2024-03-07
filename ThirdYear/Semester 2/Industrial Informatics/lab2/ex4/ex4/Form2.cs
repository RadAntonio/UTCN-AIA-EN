using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGroup1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked)
            {
                MessageBox.Show(radioButton1.Text + " " + radioButton3.Text);
            }
            if (radioButton1.Checked && radioButton4.Checked)
            {
                MessageBox.Show(radioButton1.Text + " " + radioButton4.Text);
            }
            if (radioButton2.Checked && radioButton3.Checked)
            {
                MessageBox.Show(radioButton2.Text + " " + radioButton3.Text);
            }
            if (radioButton2.Checked && radioButton4.Checked)
            {
                MessageBox.Show(radioButton2.Text + " " + radioButton4.Text);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            radioButtonGroup1_CheckedChanged(sender, e);
        }
    }
}