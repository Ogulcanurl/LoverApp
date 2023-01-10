namespace LoversApp
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.galeri1 = new LoversApp.Galeri();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNotebook = new System.Windows.Forms.Button();
            this.buttonTittle = new System.Windows.Forms.Button();
            this.buttonGallery = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(242, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 156);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1408, 10);
            this.panel2.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.buttonNotebook);
            this.panel6.Controls.Add(this.sidePanel);
            this.panel6.Controls.Add(this.buttonTittle);
            this.panel6.Controls.Add(this.buttonGallery);
            this.panel6.Controls.Add(this.buttonHome);
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 634);
            this.panel6.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 10);
            this.panel1.TabIndex = 13;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sidePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.sidePanel.Location = new System.Drawing.Point(1, 248);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 41);
            this.sidePanel.TabIndex = 0;
            // 
            // galeri1
            // 
            this.galeri1.Location = new System.Drawing.Point(170, 10);
            this.galeri1.Name = "galeri1";
            this.galeri1.Size = new System.Drawing.Size(1236, 624);
            this.galeri1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Fotoğraf Yükle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonNotebook
            // 
            this.buttonNotebook.FlatAppearance.BorderSize = 0;
            this.buttonNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotebook.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNotebook.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonNotebook.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonNotebook.Location = new System.Drawing.Point(9, 401);
            this.buttonNotebook.Name = "buttonNotebook";
            this.buttonNotebook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonNotebook.Size = new System.Drawing.Size(188, 36);
            this.buttonNotebook.TabIndex = 6;
            this.buttonNotebook.Text = "Not Ekle";
            this.buttonNotebook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNotebook.UseVisualStyleBackColor = true;
            // 
            // buttonTittle
            // 
            this.buttonTittle.FlatAppearance.BorderSize = 0;
            this.buttonTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTittle.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTittle.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonTittle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonTittle.Location = new System.Drawing.Point(9, 52);
            this.buttonTittle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.buttonTittle.Name = "buttonTittle";
            this.buttonTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonTittle.Size = new System.Drawing.Size(195, 36);
            this.buttonTittle.TabIndex = 5;
            this.buttonTittle.Text = "Lovers App";
            this.buttonTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTittle.UseVisualStyleBackColor = true;
            // 
            // buttonGallery
            // 
            this.buttonGallery.FlatAppearance.BorderSize = 0;
            this.buttonGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGallery.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGallery.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonGallery.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonGallery.Location = new System.Drawing.Point(16, 302);
            this.buttonGallery.Name = "buttonGallery";
            this.buttonGallery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGallery.Size = new System.Drawing.Size(158, 34);
            this.buttonGallery.TabIndex = 4;
            this.buttonGallery.Text = "Galeri";
            this.buttonGallery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGallery.UseVisualStyleBackColor = true;
            this.buttonGallery.Click += new System.EventHandler(this.buttonGallery_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHome.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonHome.Location = new System.Drawing.Point(16, 248);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHome.Size = new System.Drawing.Size(188, 41);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Anasayfa";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonExit.Location = new System.Drawing.Point(1337, 16);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(40, 35);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 633);
            this.Controls.Add(this.galeri1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonNotebook;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button buttonTittle;
        private System.Windows.Forms.Button buttonGallery;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel1;
        private Galeri galeri1;
        private System.Windows.Forms.Button button1;
    }
}

