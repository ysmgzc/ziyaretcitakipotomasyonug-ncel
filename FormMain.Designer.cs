namespace ziyaretcitakipotomasyonu
{
	partial class FormMain
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
			this.labelCizgi1 = new System.Windows.Forms.Label();
			this.labelBaslik1 = new System.Windows.Forms.Label();
			this.labelBaslik2 = new System.Windows.Forms.Label();
			this.labelCizgi2 = new System.Windows.Forms.Label();
			this.listViewCikisYapmayanlar = new System.Windows.Forms.ListView();
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ZiyaretEden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ZiyaretEdilen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GelisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GelisSaati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GelisNedeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelCikisYapmayanlar = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonRapor = new System.Windows.Forms.Button();
			this.buttonZiyaretci = new System.Windows.Forms.Button();
			this.buttonFirma = new System.Windows.Forms.Button();
			this.buttonPersonel = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCizgi1
			// 
			this.labelCizgi1.AutoSize = true;
			this.labelCizgi1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelCizgi1.Location = new System.Drawing.Point(12, 49);
			this.labelCizgi1.Name = "labelCizgi1";
			this.labelCizgi1.Size = new System.Drawing.Size(265, 13);
			this.labelCizgi1.TabIndex = 0;
			this.labelCizgi1.Text = "___________________________________________";
			// 
			// labelBaslik1
			// 
			this.labelBaslik1.AutoSize = true;
			this.labelBaslik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelBaslik1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelBaslik1.Location = new System.Drawing.Point(12, 29);
			this.labelBaslik1.Name = "labelBaslik1";
			this.labelBaslik1.Size = new System.Drawing.Size(89, 20);
			this.labelBaslik1.TabIndex = 1;
			this.labelBaslik1.Text = "Yeni Kayıt";
			// 
			// labelBaslik2
			// 
			this.labelBaslik2.AutoSize = true;
			this.labelBaslik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelBaslik2.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelBaslik2.Location = new System.Drawing.Point(12, 194);
			this.labelBaslik2.Name = "labelBaslik2";
			this.labelBaslik2.Size = new System.Drawing.Size(123, 20);
			this.labelBaslik2.TabIndex = 2;
			this.labelBaslik2.Text = "Ziyaretçi Girişi";
			// 
			// labelCizgi2
			// 
			this.labelCizgi2.AutoSize = true;
			this.labelCizgi2.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelCizgi2.Location = new System.Drawing.Point(12, 214);
			this.labelCizgi2.Name = "labelCizgi2";
			this.labelCizgi2.Size = new System.Drawing.Size(265, 13);
			this.labelCizgi2.TabIndex = 3;
			this.labelCizgi2.Text = "___________________________________________";
			// 
			// listViewCikisYapmayanlar
			// 
			this.listViewCikisYapmayanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ZiyaretEden,
            this.ZiyaretEdilen,
            this.GelisTarihi,
            this.GelisSaati,
            this.GelisNedeni});
			this.listViewCikisYapmayanlar.FullRowSelect = true;
			this.listViewCikisYapmayanlar.GridLines = true;
			this.listViewCikisYapmayanlar.HideSelection = false;
			this.listViewCikisYapmayanlar.Location = new System.Drawing.Point(300, 65);
			this.listViewCikisYapmayanlar.Name = "listViewCikisYapmayanlar";
			this.listViewCikisYapmayanlar.Size = new System.Drawing.Size(551, 253);
			this.listViewCikisYapmayanlar.TabIndex = 3;
			this.listViewCikisYapmayanlar.UseCompatibleStateImageBehavior = false;
			this.listViewCikisYapmayanlar.View = System.Windows.Forms.View.Details;
			this.listViewCikisYapmayanlar.SelectedIndexChanged += new System.EventHandler(this.listViewCikisYapmayanlar_SelectedIndexChanged);
			this.listViewCikisYapmayanlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewCikisYapmayanlar_MouseDown);
			// 
			// ID
			// 
			this.ID.Text = "ID";
			this.ID.Width = 30;
			// 
			// ZiyaretEden
			// 
			this.ZiyaretEden.Text = "Ziyaretçi";
			this.ZiyaretEden.Width = 100;
			// 
			// ZiyaretEdilen
			// 
			this.ZiyaretEdilen.Text = "İlgili Personel";
			this.ZiyaretEdilen.Width = 100;
			// 
			// GelisTarihi
			// 
			this.GelisTarihi.Text = "Geliş Tarihi";
			this.GelisTarihi.Width = 100;
			// 
			// GelisSaati
			// 
			this.GelisSaati.Text = "Geliş Saati";
			this.GelisSaati.Width = 100;
			// 
			// GelisNedeni
			// 
			this.GelisNedeni.Text = "Geliş Nedeni";
			this.GelisNedeni.Width = 150;
			// 
			// labelCikisYapmayanlar
			// 
			this.labelCikisYapmayanlar.AutoSize = true;
			this.labelCikisYapmayanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelCikisYapmayanlar.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelCikisYapmayanlar.Location = new System.Drawing.Point(296, 29);
			this.labelCikisYapmayanlar.Name = "labelCikisYapmayanlar";
			this.labelCikisYapmayanlar.Size = new System.Drawing.Size(229, 20);
			this.labelCikisYapmayanlar.TabIndex = 9;
			this.labelCikisYapmayanlar.Text = "Çıkış Yapmayan Ziyaretçiler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.DarkGreen;
			this.label2.Location = new System.Drawing.Point(296, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(559, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "_________________________________________________________________________________" +
    "___________";
			// 
			// buttonRapor
			// 
			this.buttonRapor.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.rapor1;
			this.buttonRapor.Location = new System.Drawing.Point(734, 335);
			this.buttonRapor.Name = "buttonRapor";
			this.buttonRapor.Size = new System.Drawing.Size(117, 69);
			this.buttonRapor.TabIndex = 10;
			this.buttonRapor.Text = "Rapor";
			this.buttonRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonRapor.UseVisualStyleBackColor = true;
			this.buttonRapor.Click += new System.EventHandler(this.buttonRapor_Click);
			// 
			// buttonZiyaretci
			// 
			this.buttonZiyaretci.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.gelenziyaretci;
			this.buttonZiyaretci.Location = new System.Drawing.Point(12, 230);
			this.buttonZiyaretci.Name = "buttonZiyaretci";
			this.buttonZiyaretci.Size = new System.Drawing.Size(262, 88);
			this.buttonZiyaretci.TabIndex = 2;
			this.buttonZiyaretci.Text = "Gelen Ziyaretçi Girişi";
			this.buttonZiyaretci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonZiyaretci.UseVisualStyleBackColor = true;
			this.buttonZiyaretci.Click += new System.EventHandler(this.buttonZiyaretci_Click);
			// 
			// buttonFirma
			// 
			this.buttonFirma.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.office;
			this.buttonFirma.Location = new System.Drawing.Point(151, 65);
			this.buttonFirma.Name = "buttonFirma";
			this.buttonFirma.Size = new System.Drawing.Size(123, 88);
			this.buttonFirma.TabIndex = 1;
			this.buttonFirma.Text = "Firma";
			this.buttonFirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonFirma.UseVisualStyleBackColor = true;
			this.buttonFirma.Click += new System.EventHandler(this.buttonFirma_Click);
			// 
			// buttonPersonel
			// 
			this.buttonPersonel.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.personal11;
			this.buttonPersonel.Location = new System.Drawing.Point(12, 65);
			this.buttonPersonel.Name = "buttonPersonel";
			this.buttonPersonel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.buttonPersonel.Size = new System.Drawing.Size(123, 88);
			this.buttonPersonel.TabIndex = 0;
			this.buttonPersonel.Text = "Personel";
			this.buttonPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonPersonel.UseVisualStyleBackColor = true;
			this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
			// 
			// çıkışYapToolStripMenuItem
			// 
			this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
			this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
			this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 441);
			this.Controls.Add(this.buttonRapor);
			this.Controls.Add(this.labelCikisYapmayanlar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listViewCikisYapmayanlar);
			this.Controls.Add(this.buttonZiyaretci);
			this.Controls.Add(this.buttonFirma);
			this.Controls.Add(this.buttonPersonel);
			this.Controls.Add(this.labelCizgi2);
			this.Controls.Add(this.labelBaslik2);
			this.Controls.Add(this.labelBaslik1);
			this.Controls.Add(this.labelCizgi1);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCizgi1;
		private System.Windows.Forms.Label labelBaslik1;
		private System.Windows.Forms.Label labelBaslik2;
		private System.Windows.Forms.Label labelCizgi2;
		private System.Windows.Forms.Button buttonPersonel;
		private System.Windows.Forms.Button buttonFirma;
		private System.Windows.Forms.Button buttonZiyaretci;
		private System.Windows.Forms.ListView listViewCikisYapmayanlar;
		private System.Windows.Forms.Label labelCikisYapmayanlar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader ZiyaretEden;
		private System.Windows.Forms.ColumnHeader ZiyaretEdilen;
		private System.Windows.Forms.ColumnHeader GelisTarihi;
		private System.Windows.Forms.ColumnHeader GelisSaati;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader GelisNedeni;
		private System.Windows.Forms.Button buttonRapor;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
	}
}

