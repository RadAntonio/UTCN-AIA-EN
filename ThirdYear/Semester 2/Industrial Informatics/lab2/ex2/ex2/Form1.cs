using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedText = listBox2.SelectedItem.ToString();
                listBox2.Items.Remove(selectedText);

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selectedText);

            }
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\ex2\\list1.txt");
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                    listBox1.Items.Add(line);
            }
        }
    }
}
