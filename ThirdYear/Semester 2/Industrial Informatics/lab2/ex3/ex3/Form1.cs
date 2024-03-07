using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double valueNumber1 = double.Parse(textBox1.Text);
            double valueNumber2 = double.Parse(textBox2.Text);
            double result = valueNumber1 - valueNumber2;
            textBox3.Text = result.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double valueNumber1 = double.Parse(textBox1.Text);
            double valueNumber2 = double.Parse(textBox2.Text);
            double result = valueNumber1 / valueNumber2;
            textBox3.Text = result.ToString();
        }

        private void muLtiplicationxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double valueNumber1 = double.Parse(textBox1.Text);
            double valueNumber2 = double.Parse(textBox2.Text);
            double result = valueNumber1 * valueNumber2;
            textBox3.Text = result.ToString();
        }

        private void additionToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            double valueNumber1 = double.Parse(textBox1.Text);
            double valueNumber2 = double.Parse(textBox2.Text);
            double result = valueNumber1 + valueNumber2;
            textBox3.Text = result.ToString();*/
            string txt1 = textBox1.Text;
            string txt2 = textBox2.Text;
            textBox3.Text = txt1 + txt2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
