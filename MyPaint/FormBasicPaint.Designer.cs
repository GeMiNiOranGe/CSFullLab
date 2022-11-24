namespace MyPaint {
    partial class FormBasicPaint {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBorderSize = new System.Windows.Forms.NumericUpDown();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeShape = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBorderSize);
            this.groupBox1.Controls.Add(this.btnBorderColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(124, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // nudBorderSize
            // 
            this.nudBorderSize.Location = new System.Drawing.Point(61, 54);
            this.nudBorderSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudBorderSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBorderSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBorderSize.Name = "nudBorderSize";
            this.nudBorderSize.Size = new System.Drawing.Size(50, 24);
            this.nudBorderSize.TabIndex = 3;
            this.nudBorderSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorderColor.Location = new System.Drawing.Point(61, 23);
            this.btnBorderColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(50, 25);
            this.btnBorderColor.TabIndex = 0;
            this.btnBorderColor.UseVisualStyleBackColor = false;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // cbTypeShape
            // 
            this.cbTypeShape.FormattingEnabled = true;
            this.cbTypeShape.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbTypeShape.Location = new System.Drawing.Point(16, 32);
            this.cbTypeShape.Name = "cbTypeShape";
            this.cbTypeShape.Size = new System.Drawing.Size(124, 25);
            this.cbTypeShape.TabIndex = 3;
            this.cbTypeShape.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFillColor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(124, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // btnFillColor
            // 
            this.btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillColor.Location = new System.Drawing.Point(61, 23);
            this.btnFillColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(50, 25);
            this.btnFillColor.TabIndex = 0;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Location = new System.Drawing.Point(147, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(525, 437);
            this.pnl.TabIndex = 4;
            this.pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseDown);
            this.pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseMove);
            this.pnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseUp);
            // 
            // FormBasicPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.cbTypeShape);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBasicPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic paint";
            this.Load += new System.EventHandler(this.FormBasicPaint_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBasicPaint_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeShape;
        private System.Windows.Forms.NumericUpDown nudBorderSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl;
    }
}

