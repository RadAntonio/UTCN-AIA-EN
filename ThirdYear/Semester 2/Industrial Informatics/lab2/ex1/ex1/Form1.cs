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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                MessageBox.Show("Read Credentials From File!");
            }
            else if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Read Credentials From File!");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void ReadCredentialsFromFile_Click(object sender, EventArgs e)
        {
            StreamReader streamReaderUser = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\ex1\\user.txt");
            {
                string line;
                while ((line = streamReaderUser.ReadLine()) != null)
                    UserTextBox.Text =line;
                
            }
            StreamReader streamReaderPassword = new StreamReader(path: "C:\\Users\\tonir\\Desktop\\UTCN-AIA-EN\\ThirdYear\\Semester 2\\Industrial Informatics\\lab2\\ex1\\password.txt");
            {
                string line;
                while ((line = streamReaderPassword.ReadLine()) != null)
                    PasswordTextBox.Text = line;

            }

        }
    }
}
