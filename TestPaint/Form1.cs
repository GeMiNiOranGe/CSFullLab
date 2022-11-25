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
        public Form1() {
            InitializeComponent();
            bm = new Bitmap(picBox.Width, picBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            picBox.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        private void picBox_MouseDown(object sender, MouseEventArgs e) {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e) {
            if (paint) {
                if (index == 1) {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2) {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            picBox.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e) {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3) {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4) {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
        }

        private void btnVeDuong_Click(object sender, EventArgs e) {
            index = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            index = 2;
        }

        private void btnTron_Click(object sender, EventArgs e) {
            index = 3;
        }

        private void btnChuNhat_Click(object sender, EventArgs e) {
            index = 4;
        }

        private void picBox_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            if (paint) {
                if (index == 3) {
                    graphics.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4) {
                    graphics.DrawRectangle(p, cX, cY, sX, sY);
                }
            }
        }
    }
}
