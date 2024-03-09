using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TemaT1
{
    public partial class Form2 : Form
    {
         
        public Form2()
        {
            InitializeComponent();
            welcomeText.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleTab1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBox1.Visible = false;          
        }
        public string Username { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            welcomeText.Text = "Welcome " + Username;
            numericUpDown1.Value = 24;
            numericUpDown1.Maximum = 34;
            numericUpDown1.Minimum = 14;
            StreamReader journal = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\TemaT1\\journal.txt");
            {
                string line;
                while ((line = journal.ReadLine()) != null)
                    richTextBox1.Text = line;
            }
            journal.Close();
        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            welcomeText.ForeColor = Color.Red;
        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            welcomeText.ForeColor = Color.Blue;
        }

        private void greenButton_CheckedChanged(object sender, EventArgs e)
        {
            welcomeText.ForeColor = Color.Green;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            welcomeText.Font = new Font("Arial", (float)numericUpDown1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void journalButton_Click(object sender, EventArgs e)
        {
            StreamReader st = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\TemaT1\\password.txt");
            try
            {
                string password = st.ReadLine();

                if (textBox1.Text.Equals(password))
                {
                    richTextBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Not Correct");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanges(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void SaveToFile(string filePath)
        {
            richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\TemaT1\\journal.txt";
            SaveToFile(filePath);
           
        }

        private void classicButton_Click(object sender, EventArgs e)
        {
            welcomeText.ForeColor = Color.Black;
            welcomeText.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericUpDown1.Value = 24;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
