namespace Fakturki
{
    partial class Drukowanie
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.itemsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dane = new Fakturki.Report.Dane();
            this.headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsDataTableBindingSource
            // 
            this.itemsDataTableBindingSource.DataSource = this.dane;
            this.itemsDataTableBindingSource.Position = 0;
            this.itemsDataTableBindingSource.Sort = "";
            // 
            // dane
            // 
            this.dane.DataSetName = "Dane";
            this.dane.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // headerBindingSource
            // 
            this.headerBindingSource.AllowNew = false;
            this.headerBindingSource.DataSource = this.dane;
            this.headerBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.itemsDataTableBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.headerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fakturki.Report.Report1.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\mjk\\Documents\\Visual Studio 2017\\Projects\\Fakturki\\Fakturki\\Report\\Repor" +
    "t1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "C:\\Users\\mjk\\Documents\\Visual Studio 2017\\Projects\\Fakturki\\Fakturki\\Report\\Repor" +
    "t1.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(684, 811);
            this.reportViewer1.TabIndex = 0;
            // 
            // Drukowanie
            // 
            this.ClientSize = new System.Drawing.Size(684, 811);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Drukowanie";
            this.Load += new System.EventHandler(this.Drukowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource itemsDataTableBindingSource;
        private Report.Dane dane;
        private System.Windows.Forms.BindingSource headerBindingSource;
    }
}