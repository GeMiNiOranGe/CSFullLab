namespace TestPaint {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnVeDuong = new System.Windows.Forms.Button();
            this.btnChuNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTron = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnTron);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnChuNhat);
            this.panel1.Controls.Add(this.btnVeDuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 43);
            this.panel2.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 100);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(584, 318);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // btnVeDuong
            // 
            this.btnVeDuong.Location = new System.Drawing.Point(183, 50);
            this.btnVeDuong.Name = "btnVeDuong";
            this.btnVeDuong.Size = new System.Drawing.Size(75, 23);
            this.btnVeDuong.TabIndex = 0;
            this.btnVeDuong.Text = "ve duong";
            this.btnVeDuong.UseVisualStyleBackColor = true;
            this.btnVeDuong.Click += new System.EventHandler(this.btnVeDuong_Click);
            // 
            // btnChuNhat
            // 
            this.btnChuNhat.Location = new System.Drawing.Point(497, 50);
            this.btnChuNhat.Name = "btnChuNhat";
            this.btnChuNhat.Size = new System.Drawing.Size(75, 23);
            this.btnChuNhat.TabIndex = 0;
            this.btnChuNhat.Text = "chu nhat";
            this.btnChuNhat.UseVisualStyleBackColor = true;
            this.btnChuNhat.Click += new System.EventHandler(this.btnChuNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(381, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTron
            // 
            this.btnTron.Location = new System.Drawing.Point(280, 50);
            this.btnTron.Name = "btnTron";
            this.btnTron.Size = new System.Drawing.Size(75, 23);
            this.btnTron.TabIndex = 0;
            this.btnTron.Text = "tron";
            this.btnTron.UseVisualStyleBackColor = true;
            this.btnTron.Click += new System.EventHandler(this.btnTron_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTron;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChuNhat;
        private System.Windows.Forms.Button btnVeDuong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBox;
    }
}

