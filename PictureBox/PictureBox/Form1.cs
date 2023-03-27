using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\mans.jildestrand\Pictures\OIP (1).jpg");
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\mans.jildestrand\Pictures\OIP (2).jpg");
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            pictureBox6.Image = Image.FromFile(filepath);
        }
    }
}
