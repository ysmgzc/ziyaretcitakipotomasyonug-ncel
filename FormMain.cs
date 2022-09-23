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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ziyaretcitakipotomasyonu
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonZiyaretci_Click(object sender, EventArgs e)
		{
			Gelenziyaretcigirisi gelenZiyaretciForm = new Gelenziyaretcigirisi();
			gelenZiyaretciForm.ShowDialog();
			Doldur();


		}

		private void buttonPersonel_Click(object sender, EventArgs e)
		{
			PersonelKayit personelKayitForm = new PersonelKayit();
			personelKayitForm.ShowDialog();
		}

		private void buttonFirma_Click(object sender, EventArgs e)
		{
			FirmaKayit firmaKayitForm = new FirmaKayit();
			firmaKayitForm.ShowDialog();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			Doldur();
			
		}

		
		private void Doldur()
		{
			listViewCikisYapmayanlar.Items.Clear();
			string sorgu = "SELECT gz.ID,(zy.Adi + ' '+ zy.Soyadi) as ZiyaretEden, (p.Adi + ' '+ p.Soyadi) as ZiyaretEdilen,gz.GelisTarihi,gz.GelisSaati,gz.GelisNedeni FROM [dbo].[GelenZiyaretci]gz LEFT JOIN [dbo].[Ziyaretci]zy on zy.ID =gz.GelenZiyaretciID LEFT JOIN [dbo].[Personel]p on p.ID =gz.ZiyaretEdilenPersonelID WHERE gz.CikisSaati is null";

			DataTable CikisYapmayanlar = VSHelper.TabloGetir(sorgu);

			//int Kolonlar = CikisYapmayanlar.Columns.Count;
			//Kolonların sqldeki baslıklarını ekler
			//for(int i =0; i < Kolonlar; i++)
			//{
			//	listViewCikisYapmayanlar.Columns.Add(CikisYapmayanlar.Columns[i].ToString());
			//}

			for (int i = 0; i < CikisYapmayanlar.Rows.Count; i++)
			{
				DataRow dr = CikisYapmayanlar.Rows[i];
				ListViewItem listItem = new ListViewItem(dr["ID"].ToString());
				listItem.SubItems.Add(dr["ZiyaretEden"].ToString());
				listItem.SubItems.Add(dr["ZiyaretEdilen"].ToString());
				listItem.SubItems.Add(Convert.ToDateTime(dr["GelisTarihi"].ToString()).ToShortDateString());
				listItem.SubItems.Add(dr["GelisSaati"].ToString());
				listItem.SubItems.Add(dr["GelisNedeni"].ToString());
				listViewCikisYapmayanlar.Items.Add(listItem);

			}
			listViewCikisYapmayanlar.Columns[0].Width = 0;
		}

		private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			


		}

		private DataGridView dataGridView1 = new DataGridView();
		private void buttonRapor_Click(object sender, EventArgs e)
		{

			Rapor rapor = new Rapor();
			rapor.ShowDialog();
			this.Hide();

			SqlConnection Sunucu = new SqlConnection(@"Data Source=DESKTOP-U1UALV9\SQLEXPRESS;Initial Catalog=ZiyaretciTakip;Integrated Security=True");
			Sunucu.Open();
			SqlCommand komut = new SqlCommand("Select * from GelenZiyaretci", Sunucu);
			komut.ExecuteNonQuery();
			SqlDataAdapter adapter = new SqlDataAdapter(komut);
			DataTable tablo = new DataTable();
			
			adapter.Fill(tablo);
			dataGridView1.DataSource = adapter;
			Sunucu.Close();



		}

		private void listViewCikisYapmayanlar_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void buttonCikisYap_Click(object sender, EventArgs e)
		{

		}

		private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
		{

			int id = 0;
			foreach (ListViewItem item in listViewCikisYapmayanlar.SelectedItems)
			{
				id = Convert.ToInt32(item.Text);
				break;
			}

			DialogResult kontrol = new DialogResult();
			kontrol = MessageBox.Show("Çıkışını yapmak istediğiniz ziyaretçiyi doğru seçtiğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (kontrol == DialogResult.Yes)
			{


				//string sorgu = "UPDATE[ZiyaretciTakip].[dbo].[GelenZiyaretci] SET CikisSaati = '" + DateTime.Now.ToShortTimeString() + "',CikisTarihi=CONVERT(datetime, '" + DateTime.Now.Date + "',103)";  
				string sorgu = "UPDATE [ZiyaretciTakip].[dbo].[GelenZiyaretci] SET CikisSaati = '" + DateTime.Now.ToShortTimeString() + "',CikisTarihi=CONVERT(datetime, '" + DateTime.Now.Date + "',103) WHERE ID = '" + id + "'";





				VSHelper.Kaydet(sorgu);
				MessageBox.Show("İlgili ziyaretçi için çıkış yapılmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Doldur();

				return;

			}
			else
			{
				MessageBox.Show("Seçili ziyaretçi için çıkış bilgileri iptal edilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
		}

		private void listViewCikisYapmayanlar_MouseDown(object sender, MouseEventArgs e)
		{
			contextMenuStrip1.Visible = false;
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				contextMenuStrip1.Visible = true;
				this.contextMenuStrip1.Show(listViewCikisYapmayanlar, new Point(e.X, e.Y));
			}

		}

	}
}
