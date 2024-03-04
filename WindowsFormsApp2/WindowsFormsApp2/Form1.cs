using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            string coordX = textBox1.Text;
            string coordY = textBox3.Text;
            int newCoordX = int.Parse(coordX);
            int newCoordY = int.Parse(coordY);
            Bitmap bmp = new Bitmap(pictureBox1.Width,
pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.FillRectangle(Brushes.Black, int.Parse(coordX), int.Parse(coordY), 70, 25);
            gr.DrawString(textBox2.Text, new
            Font("Arial", 15), Brushes.Red, int.Parse(coordX), int.Parse(coordY));
            pictureBox1.Image = bmp;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
