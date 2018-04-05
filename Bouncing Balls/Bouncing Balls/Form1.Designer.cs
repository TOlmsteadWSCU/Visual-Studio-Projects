namespace Bouncing_Balls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.scrollbar1 = new System.Windows.Forms.HScrollBar();
            this.colorD1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab2 = new System.Windows.Forms.Label();
            this.track1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.LightGreen;
            this.pic1.Location = new System.Drawing.Point(36, 42);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(372, 415);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            this.pic1.Paint += new System.Windows.Forms.PaintEventHandler(this.pic1_Paint);
            this.pic1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseClick);
            this.pic1.Move += new System.EventHandler(this.pic1_Move);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Plum;
            this.pic2.Location = new System.Drawing.Point(463, 42);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 108);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Paint += new System.Windows.Forms.PaintEventHandler(this.pic2_Paint);
            this.pic2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseClick);
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Black;
            this.pic3.Location = new System.Drawing.Point(463, 211);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(37, 37);
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // scrollbar1
            // 
            this.scrollbar1.Location = new System.Drawing.Point(463, 345);
            this.scrollbar1.Maximum = 300;
            this.scrollbar1.Minimum = 10;
            this.scrollbar1.Name = "scrollbar1";
            this.scrollbar1.Size = new System.Drawing.Size(181, 30);
            this.scrollbar1.TabIndex = 3;
            this.scrollbar1.Value = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.BackColor = System.Drawing.Color.GreenYellow;
            this.lab2.Location = new System.Drawing.Point(584, 231);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(16, 17);
            this.lab2.TabIndex = 5;
            this.lab2.Text = "0";
            this.lab2.Click += new System.EventHandler(this.lab2_Click);
            // 
            // track1
            // 
            this.track1.Location = new System.Drawing.Point(463, 418);
            this.track1.Maximum = 30;
            this.track1.Minimum = -30;
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(241, 56);
            this.track1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 540);
            this.Controls.Add(this.track1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.scrollbar1);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Bouncing Balls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.HScrollBar scrollbar1;
        private System.Windows.Forms.ColorDialog colorD1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TrackBar track1;
    }
}

