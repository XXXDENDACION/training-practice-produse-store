namespace ShopOfProd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelSubFAQ = new System.Windows.Forms.Panel();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClientandCassir = new System.Windows.Forms.Button();
            this.btnFAQ = new FontAwesome.Sharp.IconButton();
            this.btnBasket = new FontAwesome.Sharp.IconButton();
            this.btnPROD = new FontAwesome.Sharp.IconButton();
            this.panelSubLC = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnLC = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSubFAQ.SuspendLayout();
            this.panelSubLC.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelSubFAQ);
            this.panelSideMenu.Controls.Add(this.btnFAQ);
            this.panelSideMenu.Controls.Add(this.btnBasket);
            this.panelSideMenu.Controls.Add(this.btnPROD);
            this.panelSideMenu.Controls.Add(this.panelSubLC);
            this.panelSideMenu.Controls.Add(this.btnLC);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSideMenu.Size = new System.Drawing.Size(206, 561);
            this.panelSideMenu.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(0, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(189, 51);
            this.btnExit.TabIndex = 13;
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
            this.panelSubFAQ.Location = new System.Drawing.Point(0, 438);
            this.panelSubFAQ.Name = "panelSubFAQ";
            this.panelSubFAQ.Size = new System.Drawing.Size(189, 130);
            this.panelSubFAQ.TabIndex = 12;
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
            this.btnVersion.Size = new System.Drawing.Size(189, 40);
            this.btnVersion.TabIndex = 3;
            this.btnVersion.Text = "Версия приложения";
            this.btnVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.UseVisualStyleBackColor = true;
            this.btnVersion.Click += new System.EventHandler(this.button13_Click_1);
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
            this.btnAbout.Size = new System.Drawing.Size(189, 40);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "О приложении";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button14_Click_1);
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
            this.btnClientandCassir.Size = new System.Drawing.Size(189, 40);
            this.btnClientandCassir.TabIndex = 1;
            this.btnClientandCassir.Text = "Клиент и Кассир";
            this.btnClientandCassir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientandCassir.UseVisualStyleBackColor = true;
            this.btnClientandCassir.Click += new System.EventHandler(this.button15_Click_1);
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
            this.btnFAQ.Location = new System.Drawing.Point(0, 387);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFAQ.Rotation = 0D;
            this.btnFAQ.Size = new System.Drawing.Size(189, 51);
            this.btnFAQ.TabIndex = 11;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasket.FlatAppearance.BorderSize = 0;
            this.btnBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasket.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBasket.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBasket.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnBasket.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBasket.IconSize = 28;
            this.btnBasket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasket.Location = new System.Drawing.Point(0, 333);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBasket.Rotation = 0D;
            this.btnBasket.Size = new System.Drawing.Size(189, 54);
            this.btnBasket.TabIndex = 10;
            this.btnBasket.Text = "Корзина";
            this.btnBasket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.iconButton3_Click);
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
            this.btnPROD.Location = new System.Drawing.Point(0, 279);
            this.btnPROD.Name = "btnPROD";
            this.btnPROD.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPROD.Rotation = 0D;
            this.btnPROD.Size = new System.Drawing.Size(189, 54);
            this.btnPROD.TabIndex = 8;
            this.btnPROD.Text = "Продукты";
            this.btnPROD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPROD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPROD.UseVisualStyleBackColor = true;
            this.btnPROD.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // panelSubLC
            // 
            this.panelSubLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubLC.Controls.Add(this.btnHistory);
            this.panelSubLC.Controls.Add(this.btnProf);
            this.panelSubLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubLC.Location = new System.Drawing.Point(0, 189);
            this.panelSubLC.Name = "panelSubLC";
            this.panelSubLC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSubLC.Size = new System.Drawing.Size(189, 90);
            this.panelSubLC.TabIndex = 7;
            this.panelSubLC.TabStop = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.ForeColor = System.Drawing.Color.LightGray;
            this.btnHistory.Location = new System.Drawing.Point(0, 40);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(189, 40);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "История покупок";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnProf
            // 
            this.btnProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.ForeColor = System.Drawing.Color.LightGray;
            this.btnProf.Location = new System.Drawing.Point(0, 0);
            this.btnProf.Name = "btnProf";
            this.btnProf.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProf.Size = new System.Drawing.Size(189, 40);
            this.btnProf.TabIndex = 1;
            this.btnProf.Text = "Профиль";
            this.btnProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.button2_Click_1);
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
            this.btnLC.Location = new System.Drawing.Point(0, 136);
            this.btnLC.Name = "btnLC";
            this.btnLC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLC.Rotation = 0D;
            this.btnLC.Size = new System.Drawing.Size(189, 53);
            this.btnLC.TabIndex = 0;
            this.btnLC.Text = "Личный кабинет";
            this.btnLC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLC.UseVisualStyleBackColor = true;
            this.btnLC.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(189, 136);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopOfProd.Properties.Resources._257_2572499_close_shopping_cart_light_gray_shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(206, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 66);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(206, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(728, 495);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(133, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы находитесь в главном меню \r\nуправления  у клиента\r\nПолный функционал пользоват" +
    "еля\r\nвы можете наблюдать слева\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерфейс клиента";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubFAQ.ResumeLayout(false);
            this.panelSubLC.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnLC;
        private System.Windows.Forms.Panel panelSubLC;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProf;
        private FontAwesome.Sharp.IconButton btnFAQ;
        private FontAwesome.Sharp.IconButton btnBasket;
        private FontAwesome.Sharp.IconButton btnPROD;
        private System.Windows.Forms.Panel panelSubFAQ;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClientandCassir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
    }
}

