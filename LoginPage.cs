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
	public partial class LoginPage : Form
	{


		//SqlConnection con;
		///SqlCommand cmd;
		SqlDataReader dr;
		public LoginPage()
		{
			InitializeComponent();
		}

		private void buttonGirisYap_Click(object sender, EventArgs e)
		{



			////string sorgu = "SELECT * FROM login where KullaniciAdi=@textBoxKullaniciAdi AND Parola=@pass";

			//SqlConnection Sunucu = new SqlConnection(@"Data Source=DESKTOP-U1UALV9\SQLEXPRESS;Initial Catalog=ZiyaretciTakip;Integrated Security=True");
			////con = new SqlConnection("server=.; Initial Catalog=dbLogin;Integrated Security=SSPI");
			////cmd = new SqlCommand(Sunucu, con);
			//SqlCommand komut = new SqlCommand("Select * from Login where KullaniciAdi=@textBoxKullaniciAdi AND Parola=@pass", Sunucu);

			//komut.Parameters.AddWithValue("@KullaniciAdi", textBoxKullaniciAdi.Text);
			//komut.Parameters.AddWithValue("@Parola", textBoxParola.Text);
			//Sunucu.Open();

			//dr = komut.ExecuteReader();
			//if (dr.Read())
			//{
			//	MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
			//}
			//else
			//{
			//	MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
			//}
			////komut.Close();
			//FormMain formMain = new FormMain();
			//formMain.ShowDialog();

		}

		private void LoginPage_Load(object sender, EventArgs e)
		{
			textBoxParola.PasswordChar = '*';
		}
	}
}
