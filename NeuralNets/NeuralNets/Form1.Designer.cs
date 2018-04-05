namespace NeuralNets
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trainBar = new System.Windows.Forms.HScrollBar();
            this.trainLabel = new System.Windows.Forms.Label();
            this.neuronsLabel = new System.Windows.Forms.Label();
            this.neuronsBar = new System.Windows.Forms.HScrollBar();
            this.learnLabel = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(947, 688);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trainBar
            // 
            this.trainBar.Location = new System.Drawing.Point(1061, 85);
            this.trainBar.Maximum = 50009;
            this.trainBar.Minimum = 1000;
            this.trainBar.Name = "trainBar";
            this.trainBar.Size = new System.Drawing.Size(234, 41);
            this.trainBar.TabIndex = 1;
            this.trainBar.Value = 1000;
            this.trainBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trainBar_Scroll);
            // 
            // trainLabel
            // 
            this.trainLabel.AutoSize = true;
            this.trainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainLabel.Location = new System.Drawing.Point(1013, 56);
            this.trainLabel.Name = "trainLabel";
            this.trainLabel.Size = new System.Drawing.Size(120, 29);
            this.trainLabel.TabIndex = 2;
            this.trainLabel.Text = "Trainings:";
            // 
            // neuronsLabel
            // 
            this.neuronsLabel.AutoSize = true;
            this.neuronsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuronsLabel.Location = new System.Drawing.Point(1013, 154);
            this.neuronsLabel.Name = "neuronsLabel";
            this.neuronsLabel.Size = new System.Drawing.Size(230, 29);
            this.neuronsLabel.TabIndex = 3;
            this.neuronsLabel.Text = "Number of Neurons:";
            // 
            // neuronsBar
            // 
            this.neuronsBar.Location = new System.Drawing.Point(1061, 207);
            this.neuronsBar.Maximum = 109;
            this.neuronsBar.Name = "neuronsBar";
            this.neuronsBar.Size = new System.Drawing.Size(234, 45);
            this.neuronsBar.TabIndex = 4;
            this.neuronsBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.neuronsBar_Scroll);
            // 
            // learnLabel
            // 
            this.learnLabel.AutoSize = true;
            this.learnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnLabel.Location = new System.Drawing.Point(1015, 285);
            this.learnLabel.Name = "learnLabel";
            this.learnLabel.Size = new System.Drawing.Size(202, 32);
            this.learnLabel.TabIndex = 6;
            this.learnLabel.Text = "Learning Rate:";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(1061, 345);
            this.trackBar.Maximum = 2;
            this.trackBar.Minimum = -2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(234, 56);
            this.trackBar.TabIndex = 7;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Sin Wave",
            "Cone"});
            this.comboBox.Location = new System.Drawing.Point(1122, 440);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(131, 24);
            this.comboBox.TabIndex = 8;
            this.comboBox.Text = "Sin Wave";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 804);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.learnLabel);
            this.Controls.Add(this.neuronsBar);
            this.Controls.Add(this.neuronsLabel);
            this.Controls.Add(this.trainLabel);
            this.Controls.Add(this.trainBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HScrollBar trainBar;
        private System.Windows.Forms.Label trainLabel;
        private System.Windows.Forms.Label neuronsLabel;
        private System.Windows.Forms.HScrollBar neuronsBar;
        private System.Windows.Forms.Label learnLabel;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

