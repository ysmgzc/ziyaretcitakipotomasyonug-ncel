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
	public partial class Ziyaretci : Form
	{
		public Ziyaretci()
		{
			InitializeComponent();
		}

		private void Ziyaretci_Load(object sender, EventArgs e)
		{
			string sorgu = "select *from Firma";
			comboBoxilgiliFirma.DataSource = VSHelper.TabloGetir(sorgu); ;
			comboBoxilgiliFirma.ValueMember = "ID";
			comboBoxilgiliFirma.DisplayMember = "FirmaAdi";
		}

		private void buttonKaydet_Click(object sender, EventArgs e)
		{
			DialogResult kontrol = new DialogResult();
			kontrol = MessageBox.Show("Yeni ziyaretçi kayıt etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (kontrol == DialogResult.Yes)
			{
				try
				{
					string sorgu = "insert into Ziyaretci (Adi,Soyadi,TCNo,ilgiliFirmaID) values('" + textBoxAdi.Text + "','" + textBoxSoyadi.Text + "','" + textBoxTC.Text + "','" + comboBoxilgiliFirma.SelectedValue + "')";
					VSHelper.Kaydet(sorgu);
					MessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBoxAdi.Text = "";
					textBoxSoyadi.Text = "";
					textBoxTC.Text = "";


				}
				catch (Exception)
				{

					MessageBox.Show("İşlem tamamlanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
			else
			{
				textBoxAdi.Text = "";
				textBoxSoyadi.Text = "";
				textBoxTC.Text = "";
				MessageBox.Show("Kayıt işlemi iptal edilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


			}
		}
	}
}