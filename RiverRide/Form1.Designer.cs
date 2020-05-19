namespace RiverRide
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.t1 = new System.Windows.Forms.PictureBox();
            this.plane = new System.Windows.Forms.PictureBox();
            this.BgTimer = new System.Windows.Forms.Timer(this.components);
            this.o6 = new System.Windows.Forms.PictureBox();
            this.o8 = new System.Windows.Forms.PictureBox();
            this.o1 = new System.Windows.Forms.PictureBox();
            this.o4 = new System.Windows.Forms.PictureBox();
            this.o3 = new System.Windows.Forms.PictureBox();
            this.o2 = new System.Windows.Forms.PictureBox();
            this.o5 = new System.Windows.Forms.PictureBox();
            this.o7 = new System.Windows.Forms.PictureBox();
            this.BulletMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftTimer = new System.Windows.Forms.Timer(this.components);
            this.RightTimer = new System.Windows.Forms.Timer(this.components);
            this.UpTimer = new System.Windows.Forms.Timer(this.components);
            this.DownTimer = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.petrol = new System.Windows.Forms.PictureBox();
            this.PetrolUsageTimer = new System.Windows.Forms.Timer(this.components);
            this.petrolLabel = new System.Windows.Forms.Label();
            this.petrolBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.ShipCollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.t1.Location = new System.Drawing.Point(-1, -3);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(228, 679);
            this.t1.TabIndex = 0;
            this.t1.TabStop = false;
            // 
            // plane
            // 
            this.plane.Image = ((System.Drawing.Image)(resources.GetObject("plane.Image")));
            this.plane.Location = new System.Drawing.Point(431, 554);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(54, 65);
            this.plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plane.TabIndex = 1;
            this.plane.TabStop = false;
            // 
            // BgTimer
            // 
            this.BgTimer.Enabled = true;
            this.BgTimer.Interval = 10;
            this.BgTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // o6
            // 
            this.o6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o6.Image = ((System.Drawing.Image)(resources.GetObject("o6.Image")));
            this.o6.Location = new System.Drawing.Point(932, 630);
            this.o6.Name = "o6";
            this.o6.Size = new System.Drawing.Size(74, 70);
            this.o6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o6.TabIndex = 2;
            this.o6.TabStop = false;
            // 
            // o8
            // 
            this.o8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o8.Image = ((System.Drawing.Image)(resources.GetObject("o8.Image")));
            this.o8.Location = new System.Drawing.Point(876, 314);
            this.o8.Name = "o8";
            this.o8.Size = new System.Drawing.Size(74, 70);
            this.o8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o8.TabIndex = 2;
            this.o8.TabStop = false;
            // 
            // o1
            // 
            this.o1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o1.Image = ((System.Drawing.Image)(resources.GetObject("o1.Image")));
            this.o1.Location = new System.Drawing.Point(40, 554);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(74, 70);
            this.o1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o1.TabIndex = 2;
            this.o1.TabStop = false;
            // 
            // o4
            // 
            this.o4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o4.Image = ((System.Drawing.Image)(resources.GetObject("o4.Image")));
            this.o4.Location = new System.Drawing.Point(102, 183);
            this.o4.Name = "o4";
            this.o4.Size = new System.Drawing.Size(74, 70);
            this.o4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o4.TabIndex = 2;
            this.o4.TabStop = false;
            // 
            // o3
            // 
            this.o3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o3.Image = ((System.Drawing.Image)(resources.GetObject("o3.Image")));
            this.o3.Location = new System.Drawing.Point(49, -18);
            this.o3.Name = "o3";
            this.o3.Size = new System.Drawing.Size(74, 70);
            this.o3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o3.TabIndex = 2;
            this.o3.TabStop = false;
            // 
            // o2
            // 
            this.o2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o2.Image = ((System.Drawing.Image)(resources.GetObject("o2.Image")));
            this.o2.Location = new System.Drawing.Point(130, 372);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(74, 70);
            this.o2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o2.TabIndex = 2;
            this.o2.TabStop = false;
            // 
            // o5
            // 
            this.o5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o5.Image = ((System.Drawing.Image)(resources.GetObject("o5.Image")));
            this.o5.Location = new System.Drawing.Point(811, 477);
            this.o5.Name = "o5";
            this.o5.Size = new System.Drawing.Size(74, 70);
            this.o5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o5.TabIndex = 2;
            this.o5.TabStop = false;
            // 
            // o7
            // 
            this.o7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.o7.Image = ((System.Drawing.Image)(resources.GetObject("o7.Image")));
            this.o7.Location = new System.Drawing.Point(811, 12);
            this.o7.Name = "o7";
            this.o7.Size = new System.Drawing.Size(74, 70);
            this.o7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.o7.TabIndex = 2;
            this.o7.TabStop = false;
            // 
            // BulletMovementTimer
            // 
            this.BulletMovementTimer.Enabled = true;
            this.BulletMovementTimer.Interval = 5;
            this.BulletMovementTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LeftTimer
            // 
            this.LeftTimer.Interval = 20;
            this.LeftTimer.Tick += new System.EventHandler(this.LeftTimer_Tick);
            // 
            // RightTimer
            // 
            this.RightTimer.Interval = 20;
            this.RightTimer.Tick += new System.EventHandler(this.RightTimer_Tick);
            // 
            // UpTimer
            // 
            this.UpTimer.Interval = 20;
            this.UpTimer.Tick += new System.EventHandler(this.UpTimer_Tick);
            // 
            // DownTimer
            // 
            this.DownTimer.Interval = 20;
            this.DownTimer.Tick += new System.EventHandler(this.DownTimer_Tick);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Yellow;
            this.scorelabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scorelabel.Location = new System.Drawing.Point(12, 32);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(72, 20);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.Text = "Score: 0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelGameOver.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(303, 267);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(387, 62);
            this.labelGameOver.TabIndex = 6;
            this.labelGameOver.Text = "GAME OVER";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameOver.Visible = false;
            // 
            // petrol
            // 
            this.petrol.BackColor = System.Drawing.Color.Transparent;
            this.petrol.Image = ((System.Drawing.Image)(resources.GetObject("petrol.Image")));
            this.petrol.Location = new System.Drawing.Point(627, 160);
            this.petrol.Name = "petrol";
            this.petrol.Size = new System.Drawing.Size(28, 48);
            this.petrol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.petrol.TabIndex = 3;
            this.petrol.TabStop = false;
            // 
            // PetrolUsageTimer
            // 
            this.PetrolUsageTimer.Enabled = true;
            this.PetrolUsageTimer.Interval = 500;
            this.PetrolUsageTimer.Tick += new System.EventHandler(this.PetrolUsageTimer_Tick);
            // 
            // petrolLabel
            // 
            this.petrolLabel.AutoSize = true;
            this.petrolLabel.BackColor = System.Drawing.Color.Yellow;
            this.petrolLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.petrolLabel.Location = new System.Drawing.Point(678, 615);
            this.petrolLabel.Name = "petrolLabel";
            this.petrolLabel.Size = new System.Drawing.Size(83, 20);
            this.petrolLabel.TabIndex = 4;
            this.petrolLabel.Text = "Fuel: 55%";
            // 
            // petrolBar
            // 
            this.petrolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.petrolBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.petrolBar.Location = new System.Drawing.Point(672, 638);
            this.petrolBar.Name = "petrolBar";
            this.petrolBar.Size = new System.Drawing.Size(100, 23);
            this.petrolBar.TabIndex = 7;
            this.petrolBar.Value = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(388, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Play again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShipCollisionTimer
            // 
            this.ShipCollisionTimer.Enabled = true;
            this.ShipCollisionTimer.Interval = 50;
            this.ShipCollisionTimer.Tick += new System.EventHandler(this.ShipCollisionTimer_Tick);
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.t2.Location = new System.Drawing.Point(778, -3);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(228, 679);
            this.t2.TabIndex = 0;
            this.t2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.howToPlayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.petrolBar);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.petrolLabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.petrol);
            this.Controls.Add(this.o7);
            this.Controls.Add(this.o5);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.o3);
            this.Controls.Add(this.o4);
            this.Controls.Add(this.o1);
            this.Controls.Add(this.o8);
            this.Controls.Add(this.o6);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " River Raid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.Timer BgTimer;
        private System.Windows.Forms.PictureBox o6;
        private System.Windows.Forms.PictureBox o8;
        private System.Windows.Forms.PictureBox o1;
        private System.Windows.Forms.PictureBox o4;
        private System.Windows.Forms.PictureBox o3;
        private System.Windows.Forms.PictureBox o2;
        private System.Windows.Forms.PictureBox o5;
        private System.Windows.Forms.PictureBox o7;
        private System.Windows.Forms.Timer BulletMovementTimer;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Timer RightTimer;
        private System.Windows.Forms.Timer UpTimer;
        private System.Windows.Forms.Timer DownTimer;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.PictureBox petrol;
        private System.Windows.Forms.Timer PetrolUsageTimer;
        private System.Windows.Forms.Label petrolLabel;
        private System.Windows.Forms.ProgressBar petrolBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer ShipCollisionTimer;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

