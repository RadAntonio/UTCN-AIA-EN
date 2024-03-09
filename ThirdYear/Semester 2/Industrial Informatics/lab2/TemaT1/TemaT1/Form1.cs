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

namespace TemaT1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            WelcomeText.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void WelcomeText_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\TemaT1\\admin.txt");
            StreamReader st = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\TemaT1\\password.txt");
            try
            {        
                string admin = sr.ReadLine();
                string password = st.ReadLine();

                if (textBox1.Text.Equals(admin) & textBox2.Text.Equals(password))
                {
                    Form2 form2 = new Form2();
                    form2.Username = admin;
                    form2.Show();
                    
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
    }
}
