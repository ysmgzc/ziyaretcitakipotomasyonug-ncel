namespace ziyaretcitakipotomasyonu
{
	partial class FirmaKayit
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
			this.labelYeniFirma = new System.Windows.Forms.Label();
			this.labelCizgi1 = new System.Windows.Forms.Label();
			this.labelFirmaAdi = new System.Windows.Forms.Label();
			this.labelEposta = new System.Windows.Forms.Label();
			this.labelAdresBilgisi = new System.Windows.Forms.Label();
			this.textBoxFirmaAdi = new System.Windows.Forms.TextBox();
			this.textBoxEpostaAdresi = new System.Windows.Forms.TextBox();
			this.textBoxAdresBilgisi = new System.Windows.Forms.TextBox();
			this.buttonTemizle = new System.Windows.Forms.Button();
			this.buttonKaydet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelYeniFirma
			// 
			this.labelYeniFirma.AutoSize = true;
			this.labelYeniFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelYeniFirma.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelYeniFirma.Location = new System.Drawing.Point(12, 26);
			this.labelYeniFirma.Name = "labelYeniFirma";
			this.labelYeniFirma.Size = new System.Drawing.Size(95, 20);
			this.labelYeniFirma.TabIndex = 5;
			this.labelYeniFirma.Text = "Yeni Firma";
			// 
			// labelCizgi1
			// 
			this.labelCizgi1.AutoSize = true;
			this.labelCizgi1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelCizgi1.Location = new System.Drawing.Point(12, 46);
			this.labelCizgi1.Name = "labelCizgi1";
			this.labelCizgi1.Size = new System.Drawing.Size(265, 13);
			this.labelCizgi1.TabIndex = 4;
			this.labelCizgi1.Text = "___________________________________________";
			// 
			// labelFirmaAdi
			// 
			this.labelFirmaAdi.AutoSize = true;
			this.labelFirmaAdi.Location = new System.Drawing.Point(13, 80);
			this.labelFirmaAdi.Name = "labelFirmaAdi";
			this.labelFirmaAdi.Size = new System.Drawing.Size(56, 13);
			this.labelFirmaAdi.TabIndex = 6;
			this.labelFirmaAdi.Text = "Firma Adı :";
			// 
			// labelEposta
			// 
			this.labelEposta.AutoSize = true;
			this.labelEposta.Location = new System.Drawing.Point(12, 114);
			this.labelEposta.Name = "labelEposta";
			this.labelEposta.Size = new System.Drawing.Size(79, 13);
			this.labelEposta.TabIndex = 7;
			this.labelEposta.Text = "E-posta Adres :";
			// 
			// labelAdresBilgisi
			// 
			this.labelAdresBilgisi.AutoSize = true;
			this.labelAdresBilgisi.Location = new System.Drawing.Point(13, 147);
			this.labelAdresBilgisi.Name = "labelAdresBilgisi";
			this.labelAdresBilgisi.Size = new System.Drawing.Size(69, 13);
			this.labelAdresBilgisi.TabIndex = 8;
			this.labelAdresBilgisi.Text = "Adres Bilgisi :";
			// 
			// textBoxFirmaAdi
			// 
			this.textBoxFirmaAdi.Location = new System.Drawing.Point(110, 77);
			this.textBoxFirmaAdi.Name = "textBoxFirmaAdi";
			this.textBoxFirmaAdi.Size = new System.Drawing.Size(167, 20);
			this.textBoxFirmaAdi.TabIndex = 0;
			// 
			// textBoxEpostaAdresi
			// 
			this.textBoxEpostaAdresi.Location = new System.Drawing.Point(110, 111);
			this.textBoxEpostaAdresi.Name = "textBoxEpostaAdresi";
			this.textBoxEpostaAdresi.Size = new System.Drawing.Size(167, 20);
			this.textBoxEpostaAdresi.TabIndex = 1;
			// 
			// textBoxAdresBilgisi
			// 
			this.textBoxAdresBilgisi.Location = new System.Drawing.Point(110, 144);
			this.textBoxAdresBilgisi.Multiline = true;
			this.textBoxAdresBilgisi.Name = "textBoxAdresBilgisi";
			this.textBoxAdresBilgisi.Size = new System.Drawing.Size(167, 47);
			this.textBoxAdresBilgisi.TabIndex = 2;
			// 
			// buttonTemizle
			// 
			this.buttonTemizle.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.temzile;
			this.buttonTemizle.Location = new System.Drawing.Point(5, 202);
			this.buttonTemizle.Name = "buttonTemizle";
			this.buttonTemizle.Size = new System.Drawing.Size(102, 62);
			this.buttonTemizle.TabIndex = 3;
			this.buttonTemizle.Text = "Temizle";
			this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonTemizle.UseVisualStyleBackColor = true;
			this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
			// 
			// buttonKaydet
			// 
			this.buttonKaydet.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.Kaydet1;
			this.buttonKaydet.Location = new System.Drawing.Point(110, 202);
			this.buttonKaydet.Name = "buttonKaydet";
			this.buttonKaydet.Size = new System.Drawing.Size(167, 62);
			this.buttonKaydet.TabIndex = 4;
			this.buttonKaydet.Text = "Kaydet";
			this.buttonKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonKaydet.UseVisualStyleBackColor = true;
			this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
			// 
			// FirmaKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 279);
			this.Controls.Add(this.buttonTemizle);
			this.Controls.Add(this.buttonKaydet);
			this.Controls.Add(this.textBoxAdresBilgisi);
			this.Controls.Add(this.textBoxEpostaAdresi);
			this.Controls.Add(this.textBoxFirmaAdi);
			this.Controls.Add(this.labelAdresBilgisi);
			this.Controls.Add(this.labelEposta);
			this.Controls.Add(this.labelFirmaAdi);
			this.Controls.Add(this.labelYeniFirma);
			this.Controls.Add(this.labelCizgi1);
			this.Name = "FirmaKayit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FirmaKayit";
			this.Load += new System.EventHandler(this.FirmaKayit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelYeniFirma;
		private System.Windows.Forms.Label labelCizgi1;
		private System.Windows.Forms.Label labelFirmaAdi;
		private System.Windows.Forms.Label labelEposta;
		private System.Windows.Forms.Label labelAdresBilgisi;
		private System.Windows.Forms.TextBox textBoxFirmaAdi;
		private System.Windows.Forms.TextBox textBoxEpostaAdresi;
		private System.Windows.Forms.TextBox textBoxAdresBilgisi;
		private System.Windows.Forms.Button buttonKaydet;
		private System.Windows.Forms.Button buttonTemizle;
	}
}