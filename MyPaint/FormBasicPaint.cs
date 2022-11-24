using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint {
    public partial class FormBasicPaint : Form {
        public FormBasicPaint() {
            InitializeComponent();
        }

        private void FormBasicPaint_Paint(object sender, PaintEventArgs e) {
            //Graphics graphics = this.CreateGraphics();

            //Pen pen = new Pen(Color.Red, 2);

            //graphics.DrawEllipse(pen, 50, 50, 120, 80);

            //Rectangle rectangle = new Rectangle(50, 50, 200, 100);
            //graphics.DrawArc(new Pen(Color.Blue), rectangle, 10, 124);

            //graphics.DrawPolygon(new Pen(Color.Green), new PointF[] {
            //    new PointF(20, 40),  new PointF(5, 4),
            //    new PointF(150, 20), new PointF(200, 50)
            //});

            //SolidBrush brush = new SolidBrush(Color.YellowGreen);

            //e.Graphics.FillRectangle(brush, 120, 180, 100, 60);

            //e.Graphics.FillEllipse(new SolidBrush(Color.SkyBlue), 300, 100, 100, 200);
        }

        private Color borderColor;
        private Color fillColor;
        private bool mouse_is_down = false;
        private Point start;
        private Graphics graphics;
        public List<Graphics> graphicsList;

        private void FormBasicPaint_Load(object sender, EventArgs e) {
            graphics = pnl.CreateGraphics();
            borderColor = Color.Black;
            btnBorderColor.BackColor = borderColor;
            fillColor = Color.Red;
            btnFillColor.BackColor = fillColor;
        }

        private void btnBorderColor_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                btnBorderColor.BackColor = colorDialog.Color;
                borderColor = colorDialog.Color;
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                btnFillColor.BackColor = colorDialog.Color;
                fillColor = colorDialog.Color;
            }
        }

        private void pnl_MouseDown(object sender, MouseEventArgs e) {
            mouse_is_down = true;
            start = new Point(e.X, e.Y);        }

        private void pnl_MouseUp(object sender, MouseEventArgs e) {
            mouse_is_down = false;
            if (!mouse_is_down) {
                graphics.Clear(pnl.BackColor);
                Point end = new Point(e.X, e.Y);
                switch (cbTypeShape.SelectedIndex) {
                    //line
                    case 0:
                        graphics.DrawLine(new Pen(borderColor, (int)nudBorderSize.Value),
                            start, end);
                        break;
                    //empty ellipse.
                    case 1:
                        graphics.DrawEllipse(new Pen(borderColor, (int)nudBorderSize.Value),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    //filled ellipse
                    case 2:
                        graphics.DrawEllipse(new Pen(borderColor, (int)nudBorderSize.Value),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        graphics.FillEllipse(new SolidBrush(fillColor),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    //empty rectangle
                    case 3:
                        graphics.DrawRectangle(new Pen(borderColor, (int)nudBorderSize.Value),
                            /*start.X, start.Y, e.X - start.X, e.Y - start.Y*/GetRectangleFromPoints(start, end));
                        break;
                    //filled rectangle
                    case 4:
                        graphics.DrawRectangle(new Pen(borderColor, (int)nudBorderSize.Value),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        graphics.FillRectangle(new SolidBrush(fillColor),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    default:
                        break;
                }
            }        }

        private void pnl_MouseMove(object sender, MouseEventArgs e) {
            if (mouse_is_down) {
                graphics.Clear(pnl.BackColor);
                Point end = new Point(e.X, e.Y);
                switch (cbTypeShape.SelectedIndex) { 
                    //line
                    case 0:
                        graphics.DrawLine(new Pen(borderColor, (int)nudBorderSize.Value),
                            start, end);
                        break;
                    //empty ellipse.
                    case 1:
                        graphics.DrawEllipse(new Pen(borderColor, (int)nudBorderSize.Value),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    //filled ellipse
                    case 2:
                        graphics.DrawEllipse(new Pen(borderColor, (int)nudBorderSize.Value),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        graphics.FillEllipse(new SolidBrush(fillColor),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    //empty rectangle
                    case 3:
                        graphics.DrawRectangle(new Pen(borderColor, (int)nudBorderSize.Value),
                            /*start.X, start.Y, e.X - start.X, e.Y - start.Y*/GetRectangleFromPoints(start,end));
                        break;
                    //filled rectangle
                    case 4:
                        graphics.DrawRectangle(new Pen(borderColor, (int)nudBorderSize.Value),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        graphics.FillRectangle(new SolidBrush(fillColor),
                            start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    default:
                        break;
                }
            }
        }

        protected Rectangle GetRectangleFromPoints(Point p1, Point p2) {
            Point oPoint;
            Rectangle rect;

            if ((p2.X > p1.X) && (p2.Y > p1.Y)) {
                rect = new Rectangle(p1, new Size(p2.X - p1.X, p2.Y - p1.Y));
            }
            else if ((p2.X < p1.X) && (p2.Y < p1.Y)) {
                rect = new Rectangle(p2, new Size(p1.X - p2.X, p1.Y - p2.Y));
            }
            else if ((p2.X > p1.X) && (p2.Y < p1.Y)) {
                oPoint = new Point(p1.X, p2.Y);
                rect = new Rectangle(oPoint, new Size(p2.X - p1.X, p1.Y - oPoint.Y));
            }
            else {
                oPoint = new Point(p2.X, p1.Y);
                rect = new Rectangle(oPoint, new Size(p1.X - p2.X, p2.Y - p1.Y));
            }
            return rect;
        }
    }
}
