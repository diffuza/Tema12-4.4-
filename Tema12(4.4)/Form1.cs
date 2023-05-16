using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_4._4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Point[] p = {
            new Point() {X=20, Y=20},
            new Point() {X=200, Y=20},
            new Point() {X=120, Y=150}
            };
            PathGradientBrush myPathGradientBrush = new PathGradientBrush(p);
            Color c = Color.FromArgb(255 / 4, 255 / 4, 255 / 4);
            myPathGradientBrush.CenterColor = c;
            myPathGradientBrush.SurroundColors = new Color[3] { Color.Red, Color.Green, Color.Blue };
            g.FillPolygon(myPathGradientBrush, p);
        }
    }
}
