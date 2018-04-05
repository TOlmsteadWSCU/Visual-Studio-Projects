namespace GameOfLife1
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
            this.worldPanel = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.generationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.HScrollBar();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.size = new System.Windows.Forms.TextBox();
            this.saveFile1 = new System.Windows.Forms.SaveFileDialog();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.generationNumber = new System.Windows.Forms.Label();
            this.wrap = new System.Windows.Forms.CheckBox();
            this.shootButton = new System.Windows.Forms.Button();
            this.cityLabel2 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // worldPanel
            // 
            this.worldPanel.BackColor = System.Drawing.Color.GreenYellow;
            this.worldPanel.Location = new System.Drawing.Point(48, 71);
            this.worldPanel.Name = "worldPanel";
            this.worldPanel.Size = new System.Drawing.Size(1000, 515);
            this.worldPanel.TabIndex = 0;
            this.worldPanel.TabStop = false;
            this.worldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.worldPanel_Paint);
            this.worldPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.worldPanel_MouseClick);
            this.worldPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.worldPanel_MouseDown);
            this.worldPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.worldPanel_MouseMove);
            this.worldPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.worldPanel_MouseUp);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1121, 163);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(156, 42);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // generationButton
            // 
            this.generationButton.Location = new System.Drawing.Point(1121, 12);
            this.generationButton.Name = "generationButton";
            this.generationButton.Size = new System.Drawing.Size(156, 42);
            this.generationButton.TabIndex = 2;
            this.generationButton.Text = "Generation";
            this.generationButton.UseVisualStyleBackColor = true;
            this.generationButton.Click += new System.EventHandler(this.generationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Of Life by Travis Olmstead";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(1121, 270);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(156, 46);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play/Pause";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(1121, 361);
            this.speed.Maximum = 1000;
            this.speed.Minimum = 50;
            this.speed.Name = "speed";
            this.speed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speed.Size = new System.Drawing.Size(156, 37);
            this.speed.TabIndex = 5;
            this.speed.Value = 50;
            this.speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speed_Scroll);
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(1121, 419);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(156, 22);
            this.size.TabIndex = 6;
            this.size.Enter += new System.EventHandler(this.size_Enter);
            // 
            // openFile1
            // 
            this.openFile1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1121, 447);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 43);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generationNumber
            // 
            this.generationNumber.AutoSize = true;
            this.generationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generationNumber.Location = new System.Drawing.Point(42, 610);
            this.generationNumber.Name = "generationNumber";
            this.generationNumber.Size = new System.Drawing.Size(180, 32);
            this.generationNumber.TabIndex = 9;
            this.generationNumber.Text = "Generation #\r\n";
            // 
            // wrap
            // 
            this.wrap.AutoSize = true;
            this.wrap.Location = new System.Drawing.Point(1163, 496);
            this.wrap.Name = "wrap";
            this.wrap.Size = new System.Drawing.Size(114, 21);
            this.wrap.TabIndex = 10;
            this.wrap.Text = "Wrap Around";
            this.wrap.UseVisualStyleBackColor = true;
            this.wrap.CheckedChanged += new System.EventHandler(this.wrap_CheckedChanged);
            // 
            // shootButton
            // 
            this.shootButton.Location = new System.Drawing.Point(1121, 84);
            this.shootButton.Name = "shootButton";
            this.shootButton.Size = new System.Drawing.Size(156, 48);
            this.shootButton.TabIndex = 11;
            this.shootButton.Text = "Shoot";
            this.shootButton.UseVisualStyleBackColor = true;
            this.shootButton.Click += new System.EventHandler(this.shootButton_Click);
            // 
            // cityLabel2
            // 
            this.cityLabel2.AutoSize = true;
            this.cityLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel2.Location = new System.Drawing.Point(1118, 552);
            this.cityLabel2.Name = "cityLabel2";
            this.cityLabel2.Size = new System.Drawing.Size(74, 29);
            this.cityLabel2.TabIndex = 12;
            this.cityLabel2.Text = "Cities";
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel2.Location = new System.Drawing.Point(1118, 610);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(77, 29);
            this.scoreLabel2.TabIndex = 13;
            this.scoreLabel2.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 731);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.cityLabel2);
            this.Controls.Add(this.shootButton);
            this.Controls.Add(this.wrap);
            this.Controls.Add(this.generationNumber);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generationButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.worldPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.worldPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox worldPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button generationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.HScrollBar speed;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.SaveFileDialog saveFile1;
        private System.Windows.Forms.OpenFileDialog openFile1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label generationNumber;
        private System.Windows.Forms.CheckBox wrap;
        private System.Windows.Forms.Button shootButton;
        private System.Windows.Forms.Label cityLabel2;
        private System.Windows.Forms.Label scoreLabel2;
    }
}

