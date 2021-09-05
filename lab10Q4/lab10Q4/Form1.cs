using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int no = 1;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            no = 0;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            no = 2;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (no == 1)
            {
                Graphics g = CreateGraphics();
                Pen p1 = new Pen(Color.Purple);
                g.DrawEllipse(p1, e.X, e.Y, 34, 23);
            }
            else if (no == 2)
            {
                Graphics g = CreateGraphics();
                Pen p1 = new Pen(Color.PaleGoldenrod);
                g.DrawEllipse(p1, e.X, e.Y, 34, 23);
            }
            else
            {
                Graphics g = CreateGraphics();
                Pen p1 = new Pen(Color.PaleVioletRed);
                g.DrawEllipse(p1, e.X, e.Y, 34, 23);
            }
        }
    }
}
