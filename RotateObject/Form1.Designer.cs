
namespace RotateObject
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
            this.tmrSpaceship = new System.Windows.Forms.Timer(this.components);
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.LbsScore = new System.Windows.Forms.Label();
            this.LbsScore1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrSpaceship
            // 
            this.tmrSpaceship.Enabled = true;
            this.tmrSpaceship.Interval = 1;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // tmrShoot
            // 
            this.tmrShoot.Enabled = true;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // LbsScore
            // 
            this.LbsScore.AutoSize = true;
            this.LbsScore.Location = new System.Drawing.Point(404, 53);
            this.LbsScore.Name = "LbsScore";
            this.LbsScore.Size = new System.Drawing.Size(35, 13);
            this.LbsScore.TabIndex = 0;
            this.LbsScore.Text = "Score";
            this.LbsScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbsScore1
            // 
            this.LbsScore1.AutoSize = true;
            this.LbsScore1.Location = new System.Drawing.Point(445, 53);
            this.LbsScore1.Name = "LbsScore1";
            this.LbsScore1.Size = new System.Drawing.Size(13, 13);
            this.LbsScore1.TabIndex = 1;
            this.LbsScore1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RotateObject.Properties.Resources.image1;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.LbsScore1);
            this.Controls.Add(this.LbsScore);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpaceship;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Label LbsScore;
        private System.Windows.Forms.Label LbsScore1;
    }
}

