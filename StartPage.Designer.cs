namespace ShopOfProd
{
    partial class StartPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEXIT = new FontAwesome.Sharp.IconButton();
            this.btnSignUser = new FontAwesome.Sharp.IconButton();
            this.btnSingKassir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnSingKassir);
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 315);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btnSignUser);
            this.panel2.Location = new System.Drawing.Point(442, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 315);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnEXIT);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 249);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(523, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в приложение \r\n\"Магазин продуктов\"\r\n Войдите в приложение \r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopOfProd.Properties.Resources.shop_icon_png_2;
            this.pictureBox1.Location = new System.Drawing.Point(201, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.FlatAppearance.BorderSize = 0;
            this.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXIT.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEXIT.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEXIT.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnEXIT.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEXIT.IconSize = 80;
            this.btnEXIT.Location = new System.Drawing.Point(26, 12);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Rotation = 0D;
            this.btnEXIT.Size = new System.Drawing.Size(75, 82);
            this.btnEXIT.TabIndex = 1;
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnSignUser
            // 
            this.btnSignUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSignUser.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSignUser.IconSize = 150;
            this.btnSignUser.Location = new System.Drawing.Point(0, 0);
            this.btnSignUser.Name = "btnSignUser";
            this.btnSignUser.Rotation = 0D;
            this.btnSignUser.Size = new System.Drawing.Size(492, 315);
            this.btnSignUser.TabIndex = 1;
            this.btnSignUser.Text = "Войти";
            this.btnSignUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSignUser.UseVisualStyleBackColor = true;
            this.btnSignUser.Click += new System.EventHandler(this.btnSignUser_Click);
            // 
            // btnSingKassir
            // 
            this.btnSingKassir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSingKassir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingKassir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSingKassir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSingKassir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSingKassir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSingKassir.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSingKassir.IconSize = 150;
            this.btnSingKassir.Location = new System.Drawing.Point(0, 0);
            this.btnSingKassir.Name = "btnSingKassir";
            this.btnSingKassir.Rotation = 0D;
            this.btnSingKassir.Size = new System.Drawing.Size(445, 315);
            this.btnSingKassir.TabIndex = 0;
            this.btnSingKassir.Text = "Регистрация";
            this.btnSingKassir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSingKassir.UseVisualStyleBackColor = true;
            this.btnSingKassir.Click += new System.EventHandler(this.btnSingKassir_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветственное окно";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSingKassir;
        private FontAwesome.Sharp.IconButton btnSignUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEXIT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}