using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Image> itemImageMap;
        public Form1()
        {
            InitializeComponent();
            itemImageMap = new Dictionary<string, Image>();
            itemImageMap.Add("Car", Properties.Resources.masina);
            itemImageMap.Add("Woman", Properties.Resources.woman);
            itemImageMap.Add("Apple", Properties.Resources.apple);

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

        private void page2Button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
