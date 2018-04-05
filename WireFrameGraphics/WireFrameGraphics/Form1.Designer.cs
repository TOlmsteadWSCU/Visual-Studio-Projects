namespace WireFrameGraphics
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
            this.panel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RotateX = new System.Windows.Forms.TrackBar();
            this.rotateY = new System.Windows.Forms.TrackBar();
            this.rotateZ = new System.Windows.Forms.TrackBar();
            this.scale = new System.Windows.Forms.TrackBar();
            this.translateX = new System.Windows.Forms.TrackBar();
            this.translateY = new System.Windows.Forms.TrackBar();
            this.translateZ = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RotateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateZ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(173, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(825, 538);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RotateX
            // 
            this.RotateX.Location = new System.Drawing.Point(1004, 12);
            this.RotateX.Maximum = 90;
            this.RotateX.Minimum = -90;
            this.RotateX.Name = "RotateX";
            this.RotateX.Size = new System.Drawing.Size(179, 56);
            this.RotateX.TabIndex = 1;
            this.RotateX.Scroll += new System.EventHandler(this.rotateX_Scroll);
            // 
            // rotateY
            // 
            this.rotateY.Location = new System.Drawing.Point(1004, 95);
            this.rotateY.Maximum = 90;
            this.rotateY.Minimum = -90;
            this.rotateY.Name = "rotateY";
            this.rotateY.Size = new System.Drawing.Size(179, 56);
            this.rotateY.TabIndex = 2;
            this.rotateY.Scroll += new System.EventHandler(this.rotateY_Scroll);
            // 
            // rotateZ
            // 
            this.rotateZ.Location = new System.Drawing.Point(1004, 174);
            this.rotateZ.Maximum = 90;
            this.rotateZ.Minimum = -90;
            this.rotateZ.Name = "rotateZ";
            this.rotateZ.Size = new System.Drawing.Size(179, 56);
            this.rotateZ.TabIndex = 3;
            this.rotateZ.Scroll += new System.EventHandler(this.rotateZ_Scroll);
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(1004, 256);
            this.scale.Maximum = 150;
            this.scale.Minimum = 50;
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(179, 56);
            this.scale.TabIndex = 4;
            this.scale.Value = 100;
            this.scale.Scroll += new System.EventHandler(this.scale_Scroll);
            // 
            // translateX
            // 
            this.translateX.Location = new System.Drawing.Point(1004, 335);
            this.translateX.Maximum = 5;
            this.translateX.Minimum = -5;
            this.translateX.Name = "translateX";
            this.translateX.Size = new System.Drawing.Size(179, 56);
            this.translateX.TabIndex = 5;
            this.translateX.Scroll += new System.EventHandler(this.translateX_Scroll);
            // 
            // translateY
            // 
            this.translateY.Location = new System.Drawing.Point(1004, 414);
            this.translateY.Maximum = 5;
            this.translateY.Minimum = -5;
            this.translateY.Name = "translateY";
            this.translateY.Size = new System.Drawing.Size(179, 56);
            this.translateY.TabIndex = 6;
            this.translateY.Scroll += new System.EventHandler(this.translateY_Scroll);
            // 
            // translateZ
            // 
            this.translateZ.Location = new System.Drawing.Point(1004, 494);
            this.translateZ.Maximum = 5;
            this.translateZ.Minimum = -5;
            this.translateZ.Name = "translateZ";
            this.translateZ.Size = new System.Drawing.Size(179, 56);
            this.translateZ.TabIndex = 7;
            this.translateZ.Scroll += new System.EventHandler(this.translateZ_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1001, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "TranslationZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1001, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "TranslationY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1001, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "TranslationX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1004, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Scale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1001, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "RotateZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1001, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "RotateY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1001, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "RotateX";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(155, 47);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(12, 65);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(155, 46);
            this.pauseButton.TabIndex = 16;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 562);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translateZ);
            this.Controls.Add(this.translateY);
            this.Controls.Add(this.translateX);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.rotateZ);
            this.Controls.Add(this.rotateY);
            this.Controls.Add(this.RotateX);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RotateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar RotateX;
        private System.Windows.Forms.TrackBar rotateY;
        private System.Windows.Forms.TrackBar rotateZ;
        private System.Windows.Forms.TrackBar scale;
        private System.Windows.Forms.TrackBar translateX;
        private System.Windows.Forms.TrackBar translateY;
        private System.Windows.Forms.TrackBar translateZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
    }
}

