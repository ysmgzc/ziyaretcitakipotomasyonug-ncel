namespace ziyaretcitakipotomasyonu
{
	partial class LoginPage
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
			this.labelKullaniciAdi = new System.Windows.Forms.Label();
			this.labelParola = new System.Windows.Forms.Label();
			this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
			this.textBoxParola = new System.Windows.Forms.TextBox();
			this.labelBaslik1 = new System.Windows.Forms.Label();
			this.labelCizgi1 = new System.Windows.Forms.Label();
			this.buttonTemizle = new System.Windows.Forms.Button();
			this.buttonGirisYap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelKullaniciAdi
			// 
			this.labelKullaniciAdi.AutoSize = true;
			this.labelKullaniciAdi.Location = new System.Drawing.Point(12, 91);
			this.labelKullaniciAdi.Name = "labelKullaniciAdi";
			this.labelKullaniciAdi.Size = new System.Drawing.Size(70, 13);
			this.labelKullaniciAdi.TabIndex = 0;
			this.labelKullaniciAdi.Text = "Kullanıcı Adı :";
			// 
			// labelParola
			// 
			this.labelParola.AutoSize = true;
			this.labelParola.Location = new System.Drawing.Point(12, 126);
			this.labelParola.Name = "labelParola";
			this.labelParola.Size = new System.Drawing.Size(43, 13);
			this.labelParola.TabIndex = 1;
			this.labelParola.Text = "Parola :";
			// 
			// textBoxKullaniciAdi
			// 
			this.textBoxKullaniciAdi.Location = new System.Drawing.Point(122, 88);
			this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
			this.textBoxKullaniciAdi.Size = new System.Drawing.Size(154, 20);
			this.textBoxKullaniciAdi.TabIndex = 2;
			// 
			// textBoxParola
			// 
			this.textBoxParola.Location = new System.Drawing.Point(122, 119);
			this.textBoxParola.Name = "textBoxParola";
			this.textBoxParola.Size = new System.Drawing.Size(154, 20);
			this.textBoxParola.TabIndex = 3;
			// 
			// labelBaslik1
			// 
			this.labelBaslik1.AutoSize = true;
			this.labelBaslik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelBaslik1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelBaslik1.Location = new System.Drawing.Point(11, 28);
			this.labelBaslik1.Name = "labelBaslik1";
			this.labelBaslik1.Size = new System.Drawing.Size(121, 20);
			this.labelBaslik1.TabIndex = 7;
			this.labelBaslik1.Text = "Kullanıcı Girişi";
			// 
			// labelCizgi1
			// 
			this.labelCizgi1.AutoSize = true;
			this.labelCizgi1.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelCizgi1.Location = new System.Drawing.Point(11, 48);
			this.labelCizgi1.Name = "labelCizgi1";
			this.labelCizgi1.Size = new System.Drawing.Size(265, 13);
			this.labelCizgi1.TabIndex = 6;
			this.labelCizgi1.Text = "___________________________________________";
			// 
			// buttonTemizle
			// 
			this.buttonTemizle.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.temzile;
			this.buttonTemizle.Location = new System.Drawing.Point(12, 163);
			this.buttonTemizle.Name = "buttonTemizle";
			this.buttonTemizle.Size = new System.Drawing.Size(102, 62);
			this.buttonTemizle.TabIndex = 8;
			this.buttonTemizle.Text = "Temizle";
			this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonTemizle.UseVisualStyleBackColor = true;
			// 
			// buttonGirisYap
			// 
			this.buttonGirisYap.Image = global::ziyaretcitakipotomasyonu.Properties.Resources.login;
			this.buttonGirisYap.Location = new System.Drawing.Point(122, 163);
			this.buttonGirisYap.Name = "buttonGirisYap";
			this.buttonGirisYap.Size = new System.Drawing.Size(154, 62);
			this.buttonGirisYap.TabIndex = 4;
			this.buttonGirisYap.Text = "Giriş Yap";
			this.buttonGirisYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonGirisYap.UseVisualStyleBackColor = true;
			this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 258);
			this.Controls.Add(this.buttonTemizle);
			this.Controls.Add(this.labelBaslik1);
			this.Controls.Add(this.labelCizgi1);
			this.Controls.Add(this.buttonGirisYap);
			this.Controls.Add(this.textBoxParola);
			this.Controls.Add(this.textBoxKullaniciAdi);
			this.Controls.Add(this.labelParola);
			this.Controls.Add(this.labelKullaniciAdi);
			this.Name = "LoginPage";
			this.Text = "LoginPage";
			this.Load += new System.EventHandler(this.LoginPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelKullaniciAdi;
		private System.Windows.Forms.Label labelParola;
		private System.Windows.Forms.TextBox textBoxKullaniciAdi;
		private System.Windows.Forms.TextBox textBoxParola;
		private System.Windows.Forms.Button buttonGirisYap;
		private System.Windows.Forms.Label labelBaslik1;
		private System.Windows.Forms.Label labelCizgi1;
		private System.Windows.Forms.Button buttonTemizle;
	}
}