using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ziyaretcitakipotomasyonu
{
	public partial class FirmaKayit : Form
	{
		public FirmaKayit()
		{
			InitializeComponent();
		}
		private void buttonKaydet_Click(object sender, EventArgs e)
		{
			DialogResult kontrol = new DialogResult();
			kontrol = MessageBox.Show("Kayıt etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (kontrol==DialogResult.Yes)
			{

			

			if (textBoxFirmaAdi.Text=="" || textBoxEpostaAdresi.Text == "" || textBoxAdresBilgisi.Text == "")
			{
				MessageBox.Show("Firmaya ait ad, e-posta veya adres bilgisi boş geçilemez.\n Lütfen ilgili kısımları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				try
				{
					String sorgu = "insert into Firma(FirmaAdi,EPostaAdresi,AdresBilgisi) values ('" + textBoxFirmaAdi.Text + "','" + textBoxEpostaAdresi.Text + "','" + textBoxAdresBilgisi.Text + "')";
					VSHelper.Kaydet(sorgu);
						Clear();
					MessageBox.Show("Firma Kaydı Başarıyla Gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception)
				{

					MessageBox.Show("Firma kayıt işlemi tamamlanamadı.Gönderilen bilgi ile veritabanı verileri eşleşmemektedir.", "Sorun Var!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}


			}
			else
			{
				MessageBox.Show("Kayıt işlemi iptal edilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Clear();
			}

		}

		private void Clear()
		{
			textBoxFirmaAdi.Text = "";
			textBoxEpostaAdresi.Text = "";
			textBoxAdresBilgisi.Text = "";
		}
		private void FirmaKayit_Load(object sender, EventArgs e)
		{

		}

		private void buttonTemizle_Click(object sender, EventArgs e)
		{
			Clear();
		}
	}
}
