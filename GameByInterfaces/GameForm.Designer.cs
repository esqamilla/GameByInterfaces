
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.gun = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.Label();
            this.heartsPanel = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.PictureBox();
            this.heart5 = new System.Windows.Forms.PictureBox();
            this.heart4 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.CreateBirdTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerForBird1 = new System.Windows.Forms.Timer(this.components);
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gun)).BeginInit();
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
            this.gamePanel.Controls.Add(this.pictureBox2);
            this.gamePanel.Controls.Add(this.pictureBox1);
            this.gamePanel.Controls.Add(this.bottomPanel);
            this.gamePanel.Controls.Add(this.heartsPanel);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(900, 540);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Click += new System.EventHandler(this.gamePanel_Click);
            this.gamePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(620, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.gun);
            this.bottomPanel.Controls.Add(this.Count);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 418);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(900, 122);
            this.bottomPanel.TabIndex = 2;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomPanel_Paint);
            this.bottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // gun
            // 
            this.gun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gun.Image = ((System.Drawing.Image)(resources.GetObject("gun.Image")));
            this.gun.Location = new System.Drawing.Point(362, 0);
            this.gun.Margin = new System.Windows.Forms.Padding(0);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(151, 122);
            this.gun.TabIndex = 1;
            this.gun.TabStop = false;
            this.gun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gun_MouseMove);
            // 
            // Count
            // 
            this.Count.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Count.Font = new System.Drawing.Font("Montserrat", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Count.ForeColor = System.Drawing.Color.Black;
            this.Count.Location = new System.Drawing.Point(0, 60);
            this.Count.Name = "Count";
            this.Count.Padding = new System.Windows.Forms.Padding(50, 0, 0, 30);
            this.Count.Size = new System.Drawing.Size(900, 62);
            this.Count.TabIndex = 0;
            this.Count.Text = "Очки: 0";
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
            this.heartsPanel.Size = new System.Drawing.Size(900, 57);
            this.heartsPanel.TabIndex = 0;
            this.heartsPanel.Click += new System.EventHandler(this.heartsPanel_Click);
            this.heartsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.heartsPanel_MouseMove);
            // 
            // pause
            // 
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Dock = System.Windows.Forms.DockStyle.Right;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(827, 30);
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
            // CreateBirdTimer
            // 
            this.CreateBirdTimer.Interval = 1000;
            this.CreateBirdTimer.Tick += new System.EventHandler(this.CreateBirdTimer_Tick);
            // 
            // TimerForBird1
            // 
            this.TimerForBird1.Interval = 10;
            this.TimerForBird1.Tick += new System.EventHandler(this.TimerForBirdMovement_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.gamePanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "GameForm";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Click += new System.EventHandler(this.GameForm_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gun)).EndInit();
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
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.PictureBox gun;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Timer CreateBirdTimer;
        private System.Windows.Forms.Timer TimerForBird1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

