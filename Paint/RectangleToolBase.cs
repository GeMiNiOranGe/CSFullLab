using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace STT5_Retarded_Paint {
    public abstract class RectangleToolBase : Tool {
        protected bool drawing;
        protected Point sPoint;

        public RectangleToolBase(ToolArgs args) : base(args) {
            drawing = false;
            args.pictureBox.Cursor = Cursors.Cross;
            args.pictureBox.MouseDown += PictureBox_MouseDown;
            args.pictureBox.MouseMove += PictureBox_MouseMove;
            args.pictureBox.MouseUp += PictureBox_MouseUp; ;
        }

        protected abstract void PictureBox_MouseUp(object sender, MouseEventArgs e);
        protected abstract void PictureBox_MouseMove(object sender, MouseEventArgs e);
        protected abstract void PictureBox_MouseDown(object sender, MouseEventArgs e);

        //protected abstract void OnMouseUp(object sender, MouseEventArgs e);
        //protected abstract void OnMouseDown(object sender, MouseEventArgs e);
        //protected abstract void OnMouseMove(object sender, MouseEventArgs e);

        public override void UnloadTool() {
            args.pictureBox.Cursor = Cursors.Arrow;
            args.pictureBox.MouseDown -= PictureBox_MouseDown;
            args.pictureBox.MouseMove -= PictureBox_MouseMove;
            args.pictureBox.MouseUp -= PictureBox_MouseUp;
        }
    }
}
