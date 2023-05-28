namespace Pie_Pie_Snake_Game
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
            this.snapButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.DarkGray;
            this.snapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.Location = new System.Drawing.Point(713, 69);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(75, 35);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.RosyBrown;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(713, 28);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.Start);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(103, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(523, 481);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.BackColor = System.Drawing.Color.White;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(664, 206);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(98, 20);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "HighScore ";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.White;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(664, 155);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(81, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 567);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.snapButton);
            this.Name = "Form1";
            this.Text = "Pie_Pie_Snake_Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

