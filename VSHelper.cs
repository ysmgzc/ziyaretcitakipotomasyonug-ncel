using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ziyaretcitakipotomasyonu
{
	public static class VSHelper
	{
		static string Sunucu = "Data Source=DESKTOP-U1UALV9\\SQLEXPRESS;Initial Catalog=ZiyaretciTakip;Integrated Security=True";
		static SqlConnection sunucuBaglantisi = new SqlConnection(Sunucu);

		public static void Kaydet(string sorgu)
		{
			sunucuBaglantisi.Open();
			SqlCommand Gonder = new SqlCommand(sorgu, sunucuBaglantisi);
			Gonder.ExecuteNonQuery();
			sunucuBaglantisi.Close();
		}



		public static DataTable TabloGetir(string sorgu)
		{
			sunucuBaglantisi.Open();
			SqlCommand VeriAl = new SqlCommand(sorgu, sunucuBaglantisi);
			DataTable dt = new DataTable();
			dt.Load(VeriAl.ExecuteReader());
			sunucuBaglantisi.Close();

			return dt;
		}


		//public void GirisYap(string ad, string sifre, Form frm1)
		//{
		//	SqlCommand command = new SqlCommand("Select *from Login where KullaniciAdi= '"+ad+"'and Parola='"+sifre+"'"	,sunucuBaglantisi);
		//	sunucuBaglantisi.Open();
		//	reader = command.ExecuteReader();

		//	//command.ExecuteNonQuery();
		//	//sunucuBaglantisi.Close();
		//}

	}
}
