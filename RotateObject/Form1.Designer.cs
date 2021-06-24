
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
            this.Lable1 = new System.Windows.Forms.Label();
            this.LbLives = new System.Windows.Forms.Label();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSpaceship
            // 
            this.tmrSpaceship.Interval = 1;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // tmrShoot
            // 
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
            this.LbsScore1.Click += new System.EventHandler(this.LbsScore1_Click);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(404, 93);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(32, 13);
            this.Lable1.TabIndex = 2;
            this.Lable1.Text = "Lives";
            // 
            // LbLives
            // 
            this.LbLives.AutoSize = true;
            this.LbLives.Location = new System.Drawing.Point(444, 95);
            this.LbLives.Name = "LbLives";
            this.LbLives.Size = new System.Drawing.Size(13, 13);
            this.LbLives.TabIndex = 3;
            this.LbLives.Text = "5";
            this.LbLives.Click += new System.EventHandler(this.LbLives_Click);
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RotateObject.Properties.Resources.image1;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.LbLives);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.LbsScore1);
            this.Controls.Add(this.LbsScore);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpaceship;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Label LbsScore;
        private System.Windows.Forms.Label LbsScore1;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label LbLives;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}

