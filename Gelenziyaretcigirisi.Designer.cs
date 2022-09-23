namespace ziyaretcitakipotomasyonu
{
	partial class Gelenziyaretcigirisi
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
			this.labelBaslik1 = new System.Windows.Forms.Label();
			this.labelCizgi1 = new System.Windows.Forms.Label();
			this.labelGelenZiyaretci = new System.Windows.Forms.Label();
			this.labelGelisTarihi = new System.Windows.Forms.Label();
			this.labelZiyaretEdilen = new System.Windows.Forms.Label();
			this.dateTimePickerGelisTarihi = new System.Windows.Forms.DateTimePicker();
			this.comboBoxGelenZiyaretci = new System.Windows.Forms.ComboBox();
			this.comboBoxZiyaretEdilen = new System.Windows.Forms.ComboBox();
			this.buttonYeniziyaretci = new System.Windows.Forms.Button();
			this.buttonKaydet = new System.Windows.Forms.Button();
			this.labelGelisSaati = new System.Windows.Forms.Label();
			this.dateTimePickerGelisSaati = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxGelisNedeni = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelBaslik1
			// 
			this.labelBaslik1.AutoSize = true;
			this.labelBaslik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelBaslik1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelBaslik1.Location = new System.Drawing.Point(12, 31);
			this.labelBaslik1.Name = "labelBaslik1";
			this.labelBaslik1.Size = new System.Drawing.Size(130, 20);
			this.labelBaslik1.TabIndex = 3;
			this.labelBaslik1.Text = "Gelen Ziyaretçi";
			// 
			// labelCizgi1
			// 
			this.labelCizgi1.AutoSize = true;
			this.labelCizgi1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelCizgi1.Location = new System.Drawing.Point(12, 51);
			this.labelCizgi1.Name = "labelCizgi1";
			this.labelCizgi1.Size = new System.Drawing.Size(265, 13);
			this.labelCizgi1.TabIndex = 2;
			this.labelCizgi1.Text = "___________________________________________";
			// 
			// labelGelenZiyaretci
			// 
			this.labelGelenZiyaretci.AutoSize = true;
			this.labelGelenZiyaretci.Location = new System.Drawing.Point(13, 84);
			this.labelGelenZiyaretci.Name = "labelGelenZiyaretci";
			this.labelGelenZiyaretci.Size = new System.Drawing.Size(84, 13);
			this.labelGelenZiyaretci.TabIndex = 4;
			this.labelGelenZiyaretci.Text = "Gelen Ziyaretçi :";
			// 
			// labelGelisTarihi
			// 
			this.labelGelisTarihi.AutoSize = true;
			this.labelGelisTarihi.Location = new System.Drawing.Point(10, 115);
			this.labelGelisTarihi.Name = "labelGelisTarihi";
			this.labelGelisTarihi.Size = new System.Drawing.Size(65, 13);
			this.labelGelisTarihi.TabIndex = 5;
			this.labelGelisTarihi.Text = "Geliş Tarihi :";
			// 
			// labelZiyaretEdilen
			// 
			this.labelZiyaretEdilen.AutoSize = true;
			this.labelZiyaretEdilen.Location = new System.Drawing.Point(12, 178);
			this.labelZiyaretEdilen.Name = "labelZiyaretEdilen";
			this.labelZiyaretEdilen.Size = new System.Drawing.Size(74, 13);
			this.labelZiyaretEdilen.TabIndex = 6;
			this.labelZiyaretEdilen.Text = "İlgili Personel :";
			// 
			// dateTimePickerGelisTarihi
			// 
			this.dateTimePickerGelisTarihi.Location = new System.Drawing.Point(120, 109);
			this.dateTimePickerGelisTarihi.Name = "dateTimePickerGelisTarihi";
			this.dateTimePickerGelisTarihi.Size = new System.Drawing.Size(157, 20);
			this.dateTimePickerGelisTarihi.TabIndex = 1;
			// 
			// comboBoxGelenZiyaretci
			// 
			this.comboBoxGelenZiyaretci.FormattingEnabled = true;
			this.comboBoxGelenZiyaretci.Location = new System.Drawing.Point(120, 81);
			this.comboBoxGelenZiyaretci.Name = "comboBoxGelenZiyaretci";
			this.comboBoxGelenZiyaretci.Size = new System.Drawing.Size(157, 21);
			this.comboBoxGelenZiyaretci.TabIndex = 0;
			// 
			// comboBoxZiyaretEdilen
			// 
			this.comboBoxZiyaretEdilen.FormattingEnabled = true;
			this.comboBoxZiyaretEdilen.Location = new System.Drawing.Point(120, 175);
			this.comboBoxZiyaretEdilen.Name = "comboBoxZiyaretEdilen";
			this.comboBoxZiyaretEdilen.Size = new System.Drawing.Size(157, 21);
			this.comboBoxZiyaretEdilen.TabIndex = 3;
			// 
			// buttonYeniziyaretci
			// 
			this.buttonYeniziyaretci.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.ekle;
			this.buttonYeniziyaretci.Location = new System.Drawing.Point(2, 283);
			this.buttonYeniziyaretci.Name = "buttonYeniziyaretci";
			this.buttonYeniziyaretci.Size = new System.Drawing.Size(112, 62);
			this.buttonYeniziyaretci.TabIndex = 4;
			this.buttonYeniziyaretci.Text = "Yeni Ziyaretçi";
			this.buttonYeniziyaretci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonYeniziyaretci.UseVisualStyleBackColor = true;
			this.buttonYeniziyaretci.Click += new System.EventHandler(this.buttonYeniziyaretci_Click);
			// 
			// buttonKaydet
			// 
			this.buttonKaydet.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.Kaydet1;
			this.buttonKaydet.Location = new System.Drawing.Point(120, 283);
			this.buttonKaydet.Name = "buttonKaydet";
			this.buttonKaydet.Size = new System.Drawing.Size(157, 62);
			this.buttonKaydet.TabIndex = 5;
			this.buttonKaydet.Text = "Kaydet";
			this.buttonKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonKaydet.UseVisualStyleBackColor = true;
			this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
			// 
			// labelGelisSaati
			// 
			this.labelGelisSaati.AutoSize = true;
			this.labelGelisSaati.Location = new System.Drawing.Point(12, 146);
			this.labelGelisSaati.Name = "labelGelisSaati";
			this.labelGelisSaati.Size = new System.Drawing.Size(63, 13);
			this.labelGelisSaati.TabIndex = 17;
			this.labelGelisSaati.Text = "Geliş Saati :";
			// 
			// dateTimePickerGelisSaati
			// 
			this.dateTimePickerGelisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerGelisSaati.Location = new System.Drawing.Point(120, 140);
			this.dateTimePickerGelisSaati.Name = "dateTimePickerGelisSaati";
			this.dateTimePickerGelisSaati.Size = new System.Drawing.Size(157, 20);
			this.dateTimePickerGelisSaati.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 215);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Geliş Nedeni :";
			// 
			// textBoxGelisNedeni
			// 
			this.textBoxGelisNedeni.Location = new System.Drawing.Point(120, 212);
			this.textBoxGelisNedeni.Multiline = true;
			this.textBoxGelisNedeni.Name = "textBoxGelisNedeni";
			this.textBoxGelisNedeni.Size = new System.Drawing.Size(157, 65);
			this.textBoxGelisNedeni.TabIndex = 19;
			// 
			// Gelenziyaretcigirisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 357);
			this.Controls.Add(this.textBoxGelisNedeni);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerGelisSaati);
			this.Controls.Add(this.labelGelisSaati);
			this.Controls.Add(this.buttonYeniziyaretci);
			this.Controls.Add(this.buttonKaydet);
			this.Controls.Add(this.comboBoxZiyaretEdilen);
			this.Controls.Add(this.comboBoxGelenZiyaretci);
			this.Controls.Add(this.dateTimePickerGelisTarihi);
			this.Controls.Add(this.labelZiyaretEdilen);
			this.Controls.Add(this.labelGelisTarihi);
			this.Controls.Add(this.labelGelenZiyaretci);
			this.Controls.Add(this.labelBaslik1);
			this.Controls.Add(this.labelCizgi1);
			this.Name = "Gelenziyaretcigirisi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gelenziyaretcigirisi";
			this.Activated += new System.EventHandler(this.Gelenziyaretcigirisi_Activated);
			this.Load += new System.EventHandler(this.Gelenziyaretcigirisi_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelBaslik1;
		private System.Windows.Forms.Label labelCizgi1;
		private System.Windows.Forms.Label labelGelenZiyaretci;
		private System.Windows.Forms.Label labelGelisTarihi;
		private System.Windows.Forms.Label labelZiyaretEdilen;
		private System.Windows.Forms.DateTimePicker dateTimePickerGelisTarihi;
		private System.Windows.Forms.ComboBox comboBoxGelenZiyaretci;
		private System.Windows.Forms.ComboBox comboBoxZiyaretEdilen;
		private System.Windows.Forms.Button buttonKaydet;
		private System.Windows.Forms.Button buttonYeniziyaretci;
		private System.Windows.Forms.Label labelGelisSaati;
		private System.Windows.Forms.DateTimePicker dateTimePickerGelisSaati;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxGelisNedeni;
	}
}