using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPaint {
    public partial class Form1 : Form {
        int x, y, h, w;
        Pen pen = new Pen(Color.Red, 3);

        public Form1() {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            h = e.X - x;
            w = e.Y - y;
            Graphics graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(x, y, h, w);
            if (rbEllipse.Checked) {
                graphics.DrawEllipse(pen, rectangle);
            }
            else if (rbRectangle.Checked) {
                graphics.DrawRectangle(pen, rectangle);
            }
        }

    }
}
