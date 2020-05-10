namespace ShopOfProd
{
    partial class AdminInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelSubFAQ = new System.Windows.Forms.Panel();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClientandCassir = new System.Windows.Forms.Button();
            this.btnFAQ = new FontAwesome.Sharp.IconButton();
            this.btnPROD = new FontAwesome.Sharp.IconButton();
            this.btnLC = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSubFAQ.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panelSubFAQ);
            this.panel1.Controls.Add(this.btnFAQ);
            this.panel1.Controls.Add(this.btnPROD);
            this.panel1.Controls.Add(this.btnLC);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 28;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(158, 51);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Выйти";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSubFAQ
            // 
            this.panelSubFAQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubFAQ.Controls.Add(this.btnVersion);
            this.panelSubFAQ.Controls.Add(this.btnAbout);
            this.panelSubFAQ.Controls.Add(this.btnClientandCassir);
            this.panelSubFAQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubFAQ.Location = new System.Drawing.Point(0, 278);
            this.panelSubFAQ.Name = "panelSubFAQ";
            this.panelSubFAQ.Size = new System.Drawing.Size(158, 130);
            this.panelSubFAQ.TabIndex = 20;
            // 
            // btnVersion
            // 
            this.btnVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVersion.FlatAppearance.BorderSize = 0;
            this.btnVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVersion.ForeColor = System.Drawing.Color.LightGray;
            this.btnVersion.Location = new System.Drawing.Point(0, 80);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVersion.Size = new System.Drawing.Size(158, 40);
            this.btnVersion.TabIndex = 3;
            this.btnVersion.Text = "Версия приложения";
            this.btnVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.UseVisualStyleBackColor = true;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.LightGray;
            this.btnAbout.Location = new System.Drawing.Point(0, 40);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(158, 40);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "О приложении";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClientandCassir
            // 
            this.btnClientandCassir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientandCassir.FlatAppearance.BorderSize = 0;
            this.btnClientandCassir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientandCassir.ForeColor = System.Drawing.Color.LightGray;
            this.btnClientandCassir.Location = new System.Drawing.Point(0, 0);
            this.btnClientandCassir.Name = "btnClientandCassir";
            this.btnClientandCassir.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientandCassir.Size = new System.Drawing.Size(158, 40);
            this.btnClientandCassir.TabIndex = 1;
            this.btnClientandCassir.Text = "Клиент и Кассир";
            this.btnClientandCassir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientandCassir.UseVisualStyleBackColor = true;
            this.btnClientandCassir.Click += new System.EventHandler(this.btnClientandCassir_Click);
            // 
            // btnFAQ
            // 
            this.btnFAQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFAQ.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFAQ.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnFAQ.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFAQ.IconSize = 28;
            this.btnFAQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.Location = new System.Drawing.Point(0, 227);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFAQ.Rotation = 0D;
            this.btnFAQ.Size = new System.Drawing.Size(158, 51);
            this.btnFAQ.TabIndex = 19;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnPROD
            // 
            this.btnPROD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPROD.FlatAppearance.BorderSize = 0;
            this.btnPROD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPROD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPROD.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPROD.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnPROD.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPROD.IconSize = 28;
            this.btnPROD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPROD.Location = new System.Drawing.Point(0, 173);
            this.btnPROD.Name = "btnPROD";
            this.btnPROD.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPROD.Rotation = 0D;
            this.btnPROD.Size = new System.Drawing.Size(158, 54);
            this.btnPROD.TabIndex = 16;
            this.btnPROD.Text = "Продукты";
            this.btnPROD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPROD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPROD.UseVisualStyleBackColor = true;
            this.btnPROD.Click += new System.EventHandler(this.btnPROD_Click);
            // 
            // btnLC
            // 
            this.btnLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLC.FlatAppearance.BorderSize = 0;
            this.btnLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLC.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnLC.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLC.IconSize = 28;
            this.btnLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLC.Location = new System.Drawing.Point(0, 120);
            this.btnLC.Name = "btnLC";
            this.btnLC.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnLC.Rotation = 0D;
            this.btnLC.Size = new System.Drawing.Size(158, 53);
            this.btnLC.TabIndex = 14;
            this.btnLC.Text = "Пользователи";
            this.btnLC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLC.UseVisualStyleBackColor = true;
            this.btnLC.Click += new System.EventHandler(this.btnLC_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(158, 120);
            this.panelLogo.TabIndex = 2;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopOfProd.Properties.Resources._257_2572499_close_shopping_cart_light_gray_shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(312, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 124);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы находитесь в главном меню \r\nуправления  у администратора\r\nПолный функционал по" +
    "льзователя\r\nвы можете наблюдать слева\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерфейс администратора";
            this.panel1.ResumeLayout(false);
            this.panelSubFAQ.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelSubFAQ;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClientandCassir;
        private FontAwesome.Sharp.IconButton btnFAQ;
        private FontAwesome.Sharp.IconButton btnPROD;
        private FontAwesome.Sharp.IconButton btnLC;
        private System.Windows.Forms.Label label1;
    }
}