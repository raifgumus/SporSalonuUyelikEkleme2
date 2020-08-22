namespace Spor_Salonu
{
    partial class frmUyeEkle
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
            this.components = new System.ComponentModel.Container();
            this.dtwUyelikTablo = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salon_uyelikDataSet = new Spor_Salonu.Salon_uyelikDataSet();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.uyelikTableAdapter = new Spor_Salonu.Salon_uyelikDataSetTableAdapters.UyelikTableAdapter();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtwUyelikTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salon_uyelikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtwUyelikTablo
            // 
            this.dtwUyelikTablo.AllowUserToAddRows = false;
            this.dtwUyelikTablo.AllowUserToDeleteRows = false;
            this.dtwUyelikTablo.AutoGenerateColumns = false;
            this.dtwUyelikTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwUyelikTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwUyelikTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.tCNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dtwUyelikTablo.DataSource = this.uyelikBindingSource;
            this.dtwUyelikTablo.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtwUyelikTablo.Location = new System.Drawing.Point(471, 0);
            this.dtwUyelikTablo.Name = "dtwUyelikTablo";
            this.dtwUyelikTablo.ReadOnly = true;
            this.dtwUyelikTablo.RowHeadersWidth = 51;
            this.dtwUyelikTablo.RowTemplate.Height = 24;
            this.dtwUyelikTablo.Size = new System.Drawing.Size(812, 383);
            this.dtwUyelikTablo.TabIndex = 35;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCNoDataGridViewTextBoxColumn
            // 
            this.tCNoDataGridViewTextBoxColumn.DataPropertyName = "TC_No";
            this.tCNoDataGridViewTextBoxColumn.HeaderText = "TC_No";
            this.tCNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNoDataGridViewTextBoxColumn.Name = "tCNoDataGridViewTextBoxColumn";
            this.tCNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyelikBindingSource
            // 
            this.uyelikBindingSource.DataMember = "Uyelik";
            this.uyelikBindingSource.DataSource = this.salon_uyelikDataSet;
            this.uyelikBindingSource.CurrentChanged += new System.EventHandler(this.uyelikBindingSource_CurrentChanged);
            // 
            // salon_uyelikDataSet
            // 
            this.salon_uyelikDataSet.DataSetName = "Salon_uyelikDataSet";
            this.salon_uyelikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(257, 289);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 34;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(150, 289);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(211, 222);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(199, 22);
            this.txtMail.TabIndex = 29;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(211, 188);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(199, 22);
            this.txtTelefon.TabIndex = 28;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(211, 151);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(199, 22);
            this.txtSoyad.TabIndex = 31;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(211, 123);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(199, 22);
            this.txtAd.TabIndex = 27;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(211, 95);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(199, 22);
            this.txtTC.TabIndex = 26;
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Location = new System.Drawing.Point(15, 289);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(109, 23);
            this.btn_Kayit.TabIndex = 25;
            this.btn_Kayit.Text = "Kayıt";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(27, 227);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(51, 17);
            this.lblMail.TabIndex = 23;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(22, 193);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(124, 17);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "Telefon Numarası:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(22, 156);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 17);
            this.lblSoyad.TabIndex = 20;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(27, 128);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 17);
            this.lblAd.TabIndex = 19;
            this.lblAd.Text = "Ad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(22, 98);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(138, 17);
            this.lblTC.TabIndex = 18;
            this.lblTC.Text = "TC Kimlik Numarası: ";
            // 
            // uyelikTableAdapter
            // 
            this.uyelikTableAdapter.ClearBeforeFill = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(367, 289);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 36;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(30, 31);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(151, 41);
            this.btnCalisanEkle.TabIndex = 37;
            this.btnCalisanEkle.Text = "Calısan Bilgisi";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // frmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1283, 383);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dtwUyelikTablo);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTC);
            this.Name = "frmUyeEkle";
            this.Text = "Spor Salonu Uyelik Bilgisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwUyelikTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salon_uyelikDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtwUyelikTablo;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private Salon_uyelikDataSet salon_uyelikDataSet;
        private System.Windows.Forms.BindingSource uyelikBindingSource;
        private Salon_uyelikDataSetTableAdapters.UyelikTableAdapter uyelikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCalisanEkle;
    }
}

