using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ziyaretcitakipotomasyonu
{
	public partial class PersonelKayit : Form
	{
		public PersonelKayit()
		{
			InitializeComponent();
		}
		private void PersonelKayit_Load(object sender, EventArgs e)
		{

			string sorgu = "select *from CalismaDurumu";
			comboBoxCalismaDurumu.DataSource = VSHelper.TabloGetir(sorgu);
			comboBoxCalismaDurumu.ValueMember = "ID";
			comboBoxCalismaDurumu.DisplayMember = "isim";

		}

		private void buttonKaydet_Click(object sender, EventArgs e)
		{
			DialogResult kontrol = new DialogResult();
			kontrol = MessageBox.Show("Yeni personel eklemek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (kontrol == DialogResult.Yes)
			{
				string sorgu = "insert into Personel (Adi,Soyadi, CalismaDurumu,iseGirisTarihi) values('" + textBoxAdi.Text+ "','" + textBoxSoyadi.Text + "','" + comboBoxCalismaDurumu.SelectedValue + "','" + dateTimePickerİseGirisTarihi.Value.Date.ToString("yyyyMMdd") + "')";
				VSHelper.Kaydet(sorgu);
				MessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Temizle();


			}
			else
			{
				MessageBox.Show("Yeni personel kayıt işlemi iptal edilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Temizle();

			}
		}
		private void Temizle()
		{
			textBoxAdi.Text = "";
			textBoxSoyadi.Text = "";
		}

		private void buttonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
	}
}