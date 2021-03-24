namespace spaceRace
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.hero1Score = new System.Windows.Forms.Label();
            this.hero2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(194, 88);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(181, 38);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Space Race";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.subTitleLabel.Location = new System.Drawing.Point(65, 172);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(445, 37);
            this.subTitleLabel.TabIndex = 4;
            this.subTitleLabel.Text = "Press Spacebar to Begin or ESC to Escape";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hero1Score
            // 
            this.hero1Score.BackColor = System.Drawing.Color.Transparent;
            this.hero1Score.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero1Score.ForeColor = System.Drawing.Color.Red;
            this.hero1Score.Location = new System.Drawing.Point(12, 337);
            this.hero1Score.Name = "hero1Score";
            this.hero1Score.Size = new System.Drawing.Size(86, 54);
            this.hero1Score.TabIndex = 5;
            this.hero1Score.Text = "0";
            this.hero1Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hero2Score
            // 
            this.hero2Score.BackColor = System.Drawing.Color.Transparent;
            this.hero2Score.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero2Score.ForeColor = System.Drawing.Color.Red;
            this.hero2Score.Location = new System.Drawing.Point(494, 337);
            this.hero2Score.Name = "hero2Score";
            this.hero2Score.Size = new System.Drawing.Size(94, 54);
            this.hero2Score.TabIndex = 6;
            this.hero2Score.Text = "0";
            this.hero2Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.hero2Score);
            this.Controls.Add(this.hero1Score);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Label hero1Score;
        private System.Windows.Forms.Label hero2Score;
    }
}

