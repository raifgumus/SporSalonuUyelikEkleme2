namespace Spor_Salonu
{
    partial class Calisan
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.btnCalisanGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.BtnFormDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyadi = new System.Windows.Forms.TextBox();
            this.txtCalisanMevki = new System.Windows.Forms.TextBox();
            this.txtCalisanTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtwCalisan = new System.Windows.Forms.DataGridView();
            this.uyelikBilgiDataSet = new Spor_Salonu.UyelikBilgiDataSet();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter = new Spor_Salonu.UyelikBilgiDataSetTableAdapters.calisanTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtwCalisan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelikBilgiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.Location = new System.Drawing.Point(170, 326);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanSil.TabIndex = 1;
            this.btnCalisanSil.Text = "Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = true;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // btnCalisanGuncelle
            // 
            this.btnCalisanGuncelle.Location = new System.Drawing.Point(34, 375);
            this.btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            this.btnCalisanGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanGuncelle.TabIndex = 2;
            this.btnCalisanGuncelle.Text = "Güncelle";
            this.btnCalisanGuncelle.UseVisualStyleBackColor = true;
            this.btnCalisanGuncelle.Click += new System.EventHandler(this.btnCalisanGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(170, 375);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // BtnFormDegistir
            // 
            this.BtnFormDegistir.Location = new System.Drawing.Point(34, 427);
            this.BtnFormDegistir.Name = "BtnFormDegistir";
            this.BtnFormDegistir.Size = new System.Drawing.Size(75, 53);
            this.BtnFormDegistir.TabIndex = 4;
            this.BtnFormDegistir.Text = "Üye Ekle";
            this.BtnFormDegistir.UseVisualStyleBackColor = true;
            this.BtnFormDegistir.Click += new System.EventHandler(this.BtnFormDegistir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(170, 427);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 53);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(144, 104);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(100, 22);
            this.txtCalisanAdi.TabIndex = 6;
            // 
            // txtCalisanSoyadi
            // 
            this.txtCalisanSoyadi.Location = new System.Drawing.Point(144, 152);
            this.txtCalisanSoyadi.Name = "txtCalisanSoyadi";
            this.txtCalisanSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txtCalisanSoyadi.TabIndex = 7;
            // 
            // txtCalisanMevki
            // 
            this.txtCalisanMevki.Location = new System.Drawing.Point(144, 199);
            this.txtCalisanMevki.Name = "txtCalisanMevki";
            this.txtCalisanMevki.Size = new System.Drawing.Size(100, 22);
            this.txtCalisanMevki.TabIndex = 8;
            // 
            // txtCalisanTelefon
            // 
            this.txtCalisanTelefon.Location = new System.Drawing.Point(144, 245);
            this.txtCalisanTelefon.Name = "txtCalisanTelefon";
            this.txtCalisanTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtCalisanTelefon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mevki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon";
            // 
            // dtwCalisan
            // 
            this.dtwCalisan.AutoGenerateColumns = false;
            this.dtwCalisan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwCalisan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.mevkiDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dtwCalisan.DataSource = this.calisanBindingSource;
            this.dtwCalisan.Location = new System.Drawing.Point(336, 104);
            this.dtwCalisan.Name = "dtwCalisan";
            this.dtwCalisan.RowHeadersWidth = 51;
            this.dtwCalisan.RowTemplate.Height = 24;
            this.dtwCalisan.Size = new System.Drawing.Size(509, 294);
            this.dtwCalisan.TabIndex = 14;
            // 
            // uyelikBilgiDataSet
            // 
            this.uyelikBilgiDataSet.DataSetName = "UyelikBilgiDataSet";
            this.uyelikBilgiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "calisan";
            this.calisanBindingSource.DataSource = this.uyelikBilgiDataSet;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // mevkiDataGridViewTextBoxColumn
            // 
            this.mevkiDataGridViewTextBoxColumn.DataPropertyName = "Mevki";
            this.mevkiDataGridViewTextBoxColumn.HeaderText = "Mevki";
            this.mevkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mevkiDataGridViewTextBoxColumn.Name = "mevkiDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.dtwCalisan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalisanTelefon);
            this.Controls.Add(this.txtCalisanMevki);
            this.Controls.Add(this.txtCalisanSoyadi);
            this.Controls.Add(this.txtCalisanAdi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnFormDegistir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCalisanGuncelle);
            this.Controls.Add(this.btnCalisanSil);
            this.Controls.Add(this.button1);
            this.Name = "Calisan";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Calisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwCalisan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelikBilgiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Button btnCalisanGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button BtnFormDegistir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.TextBox txtCalisanSoyadi;
        private System.Windows.Forms.TextBox txtCalisanMevki;
        private System.Windows.Forms.TextBox txtCalisanTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtwCalisan;
        private UyelikBilgiDataSet uyelikBilgiDataSet;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private calisanTableAdapter calisanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}