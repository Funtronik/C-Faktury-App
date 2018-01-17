namespace Fakturki
{
    partial class Historia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrFaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminPlatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daneKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaZaplatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razemNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razemBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razemVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naglowekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakturyDBDataSet = new Fakturki.FakturyDBDataSet();
            this.naglowekTableAdapter = new Fakturki.FakturyDBDataSetTableAdapters.NaglowekTableAdapter();
            this.dane1 = new Fakturki.Report.Dane();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naglowekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dane1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nrFaDataGridViewTextBoxColumn,
            this.dataFaDataGridViewTextBoxColumn,
            this.terminPlatnosciDataGridViewTextBoxColumn,
            this.daneKlientaDataGridViewTextBoxColumn,
            this.formaZaplatyDataGridViewTextBoxColumn,
            this.razemNettoDataGridViewTextBoxColumn,
            this.razemBruttoDataGridViewTextBoxColumn,
            this.razemVatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.naglowekBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrFaDataGridViewTextBoxColumn
            // 
            this.nrFaDataGridViewTextBoxColumn.DataPropertyName = "Nr_Fa";
            this.nrFaDataGridViewTextBoxColumn.HeaderText = "Nr_Fa";
            this.nrFaDataGridViewTextBoxColumn.Name = "nrFaDataGridViewTextBoxColumn";
            // 
            // dataFaDataGridViewTextBoxColumn
            // 
            this.dataFaDataGridViewTextBoxColumn.DataPropertyName = "Data_Fa";
            this.dataFaDataGridViewTextBoxColumn.HeaderText = "Data_Fa";
            this.dataFaDataGridViewTextBoxColumn.Name = "dataFaDataGridViewTextBoxColumn";
            // 
            // terminPlatnosciDataGridViewTextBoxColumn
            // 
            this.terminPlatnosciDataGridViewTextBoxColumn.DataPropertyName = "Termin_Platnosci";
            this.terminPlatnosciDataGridViewTextBoxColumn.HeaderText = "Termin_Platnosci";
            this.terminPlatnosciDataGridViewTextBoxColumn.Name = "terminPlatnosciDataGridViewTextBoxColumn";
            // 
            // daneKlientaDataGridViewTextBoxColumn
            // 
            this.daneKlientaDataGridViewTextBoxColumn.DataPropertyName = "Dane_Klienta";
            this.daneKlientaDataGridViewTextBoxColumn.HeaderText = "Dane_Klienta";
            this.daneKlientaDataGridViewTextBoxColumn.Name = "daneKlientaDataGridViewTextBoxColumn";
            // 
            // formaZaplatyDataGridViewTextBoxColumn
            // 
            this.formaZaplatyDataGridViewTextBoxColumn.DataPropertyName = "Forma_Zaplaty";
            this.formaZaplatyDataGridViewTextBoxColumn.HeaderText = "Forma_Zaplaty";
            this.formaZaplatyDataGridViewTextBoxColumn.Name = "formaZaplatyDataGridViewTextBoxColumn";
            // 
            // razemNettoDataGridViewTextBoxColumn
            // 
            this.razemNettoDataGridViewTextBoxColumn.DataPropertyName = "Razem_Netto";
            this.razemNettoDataGridViewTextBoxColumn.HeaderText = "Razem_Netto";
            this.razemNettoDataGridViewTextBoxColumn.Name = "razemNettoDataGridViewTextBoxColumn";
            // 
            // razemBruttoDataGridViewTextBoxColumn
            // 
            this.razemBruttoDataGridViewTextBoxColumn.DataPropertyName = "Razem_Brutto";
            this.razemBruttoDataGridViewTextBoxColumn.HeaderText = "Razem_Brutto";
            this.razemBruttoDataGridViewTextBoxColumn.Name = "razemBruttoDataGridViewTextBoxColumn";
            // 
            // razemVatDataGridViewTextBoxColumn
            // 
            this.razemVatDataGridViewTextBoxColumn.DataPropertyName = "Razem_Vat";
            this.razemVatDataGridViewTextBoxColumn.HeaderText = "Razem_Vat";
            this.razemVatDataGridViewTextBoxColumn.Name = "razemVatDataGridViewTextBoxColumn";
            // 
            // naglowekBindingSource
            // 
            this.naglowekBindingSource.DataMember = "Naglowek";
            this.naglowekBindingSource.DataSource = this.fakturyDBDataSet;
            // 
            // fakturyDBDataSet
            // 
            this.fakturyDBDataSet.DataSetName = "FakturyDBDataSet";
            this.fakturyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naglowekTableAdapter
            // 
            this.naglowekTableAdapter.ClearBeforeFill = true;
            // 
            // dane1
            // 
            this.dane1.DataSetName = "Dane";
            this.dane1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 380);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Historia";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Historia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naglowekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dane1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FakturyDBDataSet fakturyDBDataSet;
        private System.Windows.Forms.BindingSource naglowekBindingSource;
        private FakturyDBDataSetTableAdapters.NaglowekTableAdapter naglowekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminPlatnosciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daneKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaZaplatyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razemNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razemBruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razemVatDataGridViewTextBoxColumn;
        private Report.Dane dane1;
    }
}