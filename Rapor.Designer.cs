namespace ziyaretcitakipotomasyonu
{
	partial class Rapor
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
			this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ziyaretciTakipDataSet = new ziyaretcitakipotomasyonu.ZiyaretciTakipDataSet();
			this.ziyaretciTakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.totalTableAdapter = new ziyaretcitakipotomasyonu.ZiyaretciTakipDataSetTableAdapters.totalTableAdapter();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tableAdapterManager = new ziyaretcitakipotomasyonu.ZiyaretciTakipDataSetTableAdapters.TableAdapterManager();
			this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
			((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ziyaretciTakipDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ziyaretciTakipDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// totalBindingSource
			// 
			this.totalBindingSource.DataMember = "total";
			this.totalBindingSource.DataSource = this.ziyaretciTakipDataSet;
			// 
			// ziyaretciTakipDataSet
			// 
			this.ziyaretciTakipDataSet.DataSetName = "ZiyaretciTakipDataSet";
			this.ziyaretciTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ziyaretciTakipDataSetBindingSource
			// 
			this.ziyaretciTakipDataSetBindingSource.DataSource = this.ziyaretciTakipDataSet;
			this.ziyaretciTakipDataSetBindingSource.Position = 0;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ziyaretcitakipotomasyonu.Report2.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(811, 450);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.UseWaitCursor = true;
			// 
			// totalTableAdapter
			// 
			this.totalTableAdapter.ClearBeforeFill = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(100, 25);
			this.toolStrip1.TabIndex = 0;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CalismaDurumuTableAdapter = null;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.FirmaTableAdapter = null;
			this.tableAdapterManager.GelenZiyaretciTableAdapter = null;
			this.tableAdapterManager.PersonelTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ziyaretcitakipotomasyonu.ZiyaretciTakipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ZiyaretciTableAdapter = null;
			// 
			// fillByToolStrip
			// 
			this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByToolStrip.Name = "fillByToolStrip";
			this.fillByToolStrip.Size = new System.Drawing.Size(811, 25);
			this.fillByToolStrip.TabIndex = 1;
			this.fillByToolStrip.Text = "fillByToolStrip";
			// 
			// Rapor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 450);
			this.Controls.Add(this.fillByToolStrip);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Rapor";
			this.Text = "Rapor";
			this.Load += new System.EventHandler(this.Rapor_Load);
			((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ziyaretciTakipDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ziyaretciTakipDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private ZiyaretciTakipDataSet ziyaretciTakipDataSet;
		private System.Windows.Forms.BindingSource totalBindingSource;
		private ZiyaretciTakipDataSetTableAdapters.totalTableAdapter totalTableAdapter;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.BindingSource ziyaretciTakipDataSetBindingSource;
		private ZiyaretciTakipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ToolStrip fillByToolStrip;
	}
}