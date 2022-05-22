
namespace GameByInterfaces
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.heartsPanel = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.PictureBox();
            this.heart5 = new System.Windows.Forms.PictureBox();
            this.heart4 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.heartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.button2);
            this.gamePanel.Controls.Add(this.button1);
            this.gamePanel.Controls.Add(this.heartsPanel);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(884, 501);
            this.gamePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(347, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Убрать сердечко";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heartsPanel
            // 
            this.heartsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heartsPanel.BackColor = System.Drawing.Color.Transparent;
            this.heartsPanel.Controls.Add(this.pause);
            this.heartsPanel.Controls.Add(this.heart5);
            this.heartsPanel.Controls.Add(this.heart4);
            this.heartsPanel.Controls.Add(this.heart3);
            this.heartsPanel.Controls.Add(this.heart2);
            this.heartsPanel.Controls.Add(this.heart1);
            this.heartsPanel.Location = new System.Drawing.Point(0, 0);
            this.heartsPanel.Name = "heartsPanel";
            this.heartsPanel.Padding = new System.Windows.Forms.Padding(50, 30, 50, 0);
            this.heartsPanel.Size = new System.Drawing.Size(884, 57);
            this.heartsPanel.TabIndex = 0;
            // 
            // pause
            // 
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Dock = System.Windows.Forms.DockStyle.Right;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(811, 30);
            this.pause.Margin = new System.Windows.Forms.Padding(0, 0, 300, 0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(23, 27);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause.TabIndex = 5;
            this.pause.TabStop = false;
            // 
            // heart5
            // 
            this.heart5.Dock = System.Windows.Forms.DockStyle.Left;
            this.heart5.Image = ((System.Drawing.Image)(resources.GetObject("heart5.Image")));
            this.heart5.Location = new System.Drawing.Point(170, 30);
            this.heart5.Name = "heart5";
            this.heart5.Size = new System.Drawing.Size(30, 27);
            this.heart5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart5.TabIndex = 4;
            this.heart5.TabStop = false;
            // 
            // heart4
            // 
            this.heart4.Dock = System.Windows.Forms.DockStyle.Left;
            this.heart4.Image = ((System.Drawing.Image)(resources.GetObject("heart4.Image")));
            this.heart4.Location = new System.Drawing.Point(140, 30);
            this.heart4.Name = "heart4";
            this.heart4.Size = new System.Drawing.Size(30, 27);
            this.heart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart4.TabIndex = 3;
            this.heart4.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.Dock = System.Windows.Forms.DockStyle.Left;
            this.heart3.Image = ((System.Drawing.Image)(resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(110, 30);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(30, 27);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 2;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Dock = System.Windows.Forms.DockStyle.Left;
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(80, 30);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(30, 27);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 1;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.Dock = System.Windows.Forms.DockStyle.Left;
            this.heart1.Image = ((System.Drawing.Image)(resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(50, 30);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(30, 27);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 0;
            this.heart1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.gamePanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "GameForm";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.gamePanel.ResumeLayout(false);
            this.heartsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel heartsPanel;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart5;
        private System.Windows.Forms.PictureBox heart4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.Button button2;
    }
}

