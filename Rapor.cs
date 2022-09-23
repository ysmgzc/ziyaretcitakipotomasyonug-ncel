using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ziyaretcitakipotomasyonu.Properties;

namespace ziyaretcitakipotomasyonu
{
	public partial class Rapor : Form
	{
		public Rapor()
		{
			InitializeComponent();
		}

		private void Rapor_Load(object sender, EventArgs e)
		{

			this.ziyaretciTakipDataSet.EnforceConstraints = false;
			this.totalTableAdapter.Fill(this.ziyaretciTakipDataSet.total);
			this.reportViewer1.RefreshReport();
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.totalTableAdapter.FillBy(this.ziyaretciTakipDataSet.total);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}
}
