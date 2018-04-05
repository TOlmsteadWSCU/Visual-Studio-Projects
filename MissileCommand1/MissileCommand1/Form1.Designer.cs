namespace MissileCommand1
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
            this.gameLabel = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.scoreLabel1 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.cityLabel2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusLabel = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.BackColor = System.Drawing.Color.Black;
            this.gameLabel.Location = new System.Drawing.Point(12, 26);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(850, 641);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.TabStop = false;
            this.gameLabel.Click += new System.EventHandler(this.gameLabel_Click);
            this.gameLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameLabel_Paint);
            this.gameLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameLabel_MouseClick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1086, 46);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 45);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // scoreLabel1
            // 
            this.scoreLabel1.AutoSize = true;
            this.scoreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel1.Location = new System.Drawing.Point(1083, 180);
            this.scoreLabel1.Name = "scoreLabel1";
            this.scoreLabel1.Size = new System.Drawing.Size(119, 44);
            this.scoreLabel1.TabIndex = 2;
            this.scoreLabel1.Text = "Score";
            this.scoreLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel2.Location = new System.Drawing.Point(1088, 272);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(26, 29);
            this.scoreLabel2.TabIndex = 3;
            this.scoreLabel2.Text = "0";
            // 
            // cityLabel1
            // 
            this.cityLabel1.AutoSize = true;
            this.cityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel1.Location = new System.Drawing.Point(1090, 345);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(116, 44);
            this.cityLabel1.TabIndex = 4;
            this.cityLabel1.Text = "Cities";
            // 
            // cityLabel2
            // 
            this.cityLabel2.AutoSize = true;
            this.cityLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel2.Location = new System.Drawing.Point(1095, 454);
            this.cityLabel2.Name = "cityLabel2";
            this.cityLabel2.Size = new System.Drawing.Size(26, 29);
            this.cityLabel2.TabIndex = 5;
            this.cityLabel2.Text = "0";
            this.cityLabel2.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(1054, 586);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(219, 36);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Waiting to Start";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 50;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1088, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Travis Olmstead";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.cityLabel2);
            this.Controls.Add(this.cityLabel1);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.scoreLabel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label scoreLabel1;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label cityLabel2;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label label1;
    }
}

