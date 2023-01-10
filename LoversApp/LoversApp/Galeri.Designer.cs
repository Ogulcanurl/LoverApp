namespace LoversApp
{
    partial class Galeri
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonEnterDate = new System.Windows.Forms.Button();
            this.buttonSelectDate = new System.Windows.Forms.Button();
            this.buttonSeeAll = new System.Windows.Forms.Button();
            this.textBoxEnterDate = new System.Windows.Forms.TextBox();
            this.dateTimePickerSelect = new System.Windows.Forms.DateTimePicker();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(181, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1021, 566);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.buttonEnterDate);
            this.panel6.Controls.Add(this.buttonSelectDate);
            this.panel6.Controls.Add(this.buttonSeeAll);
            this.panel6.Controls.Add(this.textBoxEnterDate);
            this.panel6.Controls.Add(this.dateTimePickerSelect);
            this.panel6.Controls.Add(this.buttonFilter);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 618);
            this.panel6.TabIndex = 7;
            // 
            // buttonEnterDate
            // 
            this.buttonEnterDate.FlatAppearance.BorderSize = 0;
            this.buttonEnterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEnterDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnterDate.Location = new System.Drawing.Point(14, 237);
            this.buttonEnterDate.Name = "buttonEnterDate";
            this.buttonEnterDate.Size = new System.Drawing.Size(141, 67);
            this.buttonEnterDate.TabIndex = 7;
            this.buttonEnterDate.Text = "Tarih Gir -----------";
            this.buttonEnterDate.UseVisualStyleBackColor = true;
            this.buttonEnterDate.Click += new System.EventHandler(this.buttonEnterDate_Click);
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.FlatAppearance.BorderSize = 0;
            this.buttonSelectDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSelectDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectDate.Location = new System.Drawing.Point(14, 158);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(141, 67);
            this.buttonSelectDate.TabIndex = 6;
            this.buttonSelectDate.Text = "Tarih Seç -----------";
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // buttonSeeAll
            // 
            this.buttonSeeAll.FlatAppearance.BorderSize = 0;
            this.buttonSeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeAll.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeeAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeeAll.Location = new System.Drawing.Point(14, 81);
            this.buttonSeeAll.Name = "buttonSeeAll";
            this.buttonSeeAll.Size = new System.Drawing.Size(141, 67);
            this.buttonSeeAll.TabIndex = 5;
            this.buttonSeeAll.Text = "Tümünü Gör\r\n----------";
            this.buttonSeeAll.UseVisualStyleBackColor = true;
            // 
            // textBoxEnterDate
            // 
            this.textBoxEnterDate.Location = new System.Drawing.Point(14, 340);
            this.textBoxEnterDate.Name = "textBoxEnterDate";
            this.textBoxEnterDate.Size = new System.Drawing.Size(141, 22);
            this.textBoxEnterDate.TabIndex = 4;
            // 
            // dateTimePickerSelect
            // 
            this.dateTimePickerSelect.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dateTimePickerSelect.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dateTimePickerSelect.Location = new System.Drawing.Point(14, 340);
            this.dateTimePickerSelect.Name = "dateTimePickerSelect";
            this.dateTimePickerSelect.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerSelect.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilter.Location = new System.Drawing.Point(32, 21);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(104, 52);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.Text = "Filtrele\r\n----------";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonExit.Location = new System.Drawing.Point(1182, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(37, 37);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Galeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Galeri";
            this.Size = new System.Drawing.Size(1222, 618);
            this.Load += new System.EventHandler(this.Galeri_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerSelect;
        private System.Windows.Forms.TextBox textBoxEnterDate;
        private System.Windows.Forms.Button buttonSeeAll;
        private System.Windows.Forms.Button buttonEnterDate;
        private System.Windows.Forms.Button buttonSelectDate;
        private System.Windows.Forms.Button buttonExit;
    }
}
