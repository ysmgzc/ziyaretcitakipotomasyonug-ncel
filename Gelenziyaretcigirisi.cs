using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ziyaretcitakipotomasyonu
{
	public partial class Gelenziyaretcigirisi : Form
	{
		public Gelenziyaretcigirisi()
		{
			InitializeComponent();
		}

		private void buttonYeniziyaretci_Click(object sender, EventArgs e)
		{
			Ziyaretci ZiyaretciForm = new Ziyaretci();
			ZiyaretciForm.ShowDialog();
			Doldur();

		}

		private void Gelenziyaretcigirisi_Load(object sender, EventArgs e)
		{


			Doldur();

		}

		private void buttonKaydet_Click(object sender, EventArgs e)
		{
			DialogResult kontrol = new DialogResult();
			kontrol = MessageBox.Show("Kayıt etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (kontrol==DialogResult.Yes)
			{

			string sorgu = "insert into GelenZiyaretci (GelenZiyaretciID, GelisTarihi, GelisSaati, ZiyaretEdilenPersonelID,GelisNedeni) values('" + comboBoxGelenZiyaretci.SelectedValue + "','" + dateTimePickerGelisTarihi.Value.Date.ToString("yyyyMMdd") + "','" + dateTimePickerGelisSaati.Text + "','" + comboBoxZiyaretEdilen.SelectedValue + "','" + textBoxGelisNedeni.Text + "')";
			
			try
			{
				VSHelper.Kaydet(sorgu);
				MessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception)
			{

				MessageBox.Show("İşlem tamamlanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			}
			else
			{
				MessageBox.Show("Kayıt işlemi iptal edilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


			}

		}
		private void Doldur()
		{
			string sorgu = "select ID, (Adi + ' ' + Soyadi) as Adi from Personel";
			comboBoxZiyaretEdilen.DataSource = VSHelper.TabloGetir(sorgu); ;
			comboBoxZiyaretEdilen.ValueMember = "ID";
			comboBoxZiyaretEdilen.DisplayMember = "Adi";

			sorgu = "select ID, (Adi + ' ' + Soyadi) as Adi from Ziyaretci";
			comboBoxGelenZiyaretci.DataSource = VSHelper.TabloGetir(sorgu);
			comboBoxGelenZiyaretci.ValueMember = "ID";
			comboBoxGelenZiyaretci.DisplayMember = "Adi";
		}
		private void Gelenziyaretcigirisi_Activated(object sender, EventArgs e)
		{
			
		}
	}
}
