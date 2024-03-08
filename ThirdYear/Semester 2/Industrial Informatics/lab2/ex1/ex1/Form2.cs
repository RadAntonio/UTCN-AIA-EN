using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string UsernameFromForm1 { get; set; }   

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(UsernameFromForm1);
            label2.Text = "Hello " + UsernameFromForm1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
