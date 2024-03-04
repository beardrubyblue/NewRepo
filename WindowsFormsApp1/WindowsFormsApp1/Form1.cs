using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width,
            pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Pen p5 = new Pen(Color.Gray, 4); // Ширина 4 пиксела
            gr.FillRectangle(Brushes.Black, 10, 10, 40, 20);
            gr.DrawRectangle(p5, 10, 10, 40, 20);
            gr.FillRectangle(Brushes.Black, 20, 20, 80, 40);
            gr.DrawRectangle(p5, 20, 20, 80, 40);
            gr.FillRectangle(Brushes.Black, 30, 30, 160, 80);
            gr.DrawRectangle(p5, 30, 30, 160, 80);
            gr.FillRectangle(Brushes.Black, 40, 40, 180, 100);
            gr.DrawRectangle(p5, 40, 40, 180, 100);
            pictureBox1.Image = bmp;
        }
    }
}
