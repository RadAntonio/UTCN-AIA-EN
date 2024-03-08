using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4Bun
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Image> itemImageMap;
        public Form1()
        {
            InitializeComponent();

            itemImageMap = new Dictionary<string, Image>();
            itemImageMap.Add("Car", Properties.Resources.masina);
            itemImageMap.Add("Apple", Properties.Resources.apple);
            itemImageMap.Add("Woman", Properties.Resources.woman);


            foreach (var item in itemImageMap.Keys)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();

            // Get the corresponding image from the dictionary
            if (itemImageMap.TryGetValue(selectedItem, out Image selectedImage))
            {
                // Display the image in the PictureBox
                pictureBox1.Image = selectedImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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
