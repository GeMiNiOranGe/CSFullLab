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
            bitmap = new Bitmap(picBox.Width, picBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            picBox.Image = bitmap;
        }

        //private void FormBasicPaint_Paint(object sender, PaintEventArgs e) {
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
        //}

        private Color borderColor;
        private Color fillColor;
        private bool isMousePressDown;
        private Point startPoint, endPoint;
        private Graphics graphics;
        private Bitmap bitmap;
        private Rectangle rectangleTemp;

        private void FormBasicPaint_Load(object sender, EventArgs e) {
            graphics = picBox.CreateGraphics();
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

        private void picBox_MouseDown(object sender, MouseEventArgs e) {
            isMousePressDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e) {
            isMousePressDown = false;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e) {
            if (isMousePressDown) {
                picBox.Refresh();
                endPoint = new Point(e.X, e.Y);
                switch (cbTypeShape.SelectedIndex) {
                    //line
                    case 0:
                        graphics.DrawLine(new Pen(borderColor, (int)nudBorderSize.Value),
                            startPoint, endPoint);
                        break;
                    //empty ellipse.
                    case 1:
                        graphics.DrawEllipse(new Pen(borderColor, (int)nudBorderSize.Value),
                            GetRectangleFromPoints(startPoint, endPoint));
                        break;
                    //filled ellipse
                    case 2:
                        graphics.DrawEllipse(new Pen(borderColor, (int)nudBorderSize.Value),
                            GetRectangleFromPoints(startPoint, endPoint));
                        graphics.FillEllipse(new SolidBrush(fillColor),
                            GetRectangleFromPoints(startPoint, endPoint));
                        break;
                    //empty rectangle
                    case 3:
                        graphics.DrawRectangle(new Pen(borderColor, (int)nudBorderSize.Value),
                            GetRectangleFromPoints(startPoint, endPoint));
                        break;
                    //filled rectangle
                    case 4:
                        graphics.DrawRectangle(new Pen(borderColor, (int)nudBorderSize.Value),
                            GetRectangleFromPoints(startPoint, endPoint));
                        graphics.FillRectangle(new SolidBrush(fillColor),
                            GetRectangleFromPoints(startPoint, endPoint));
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
