namespace Cine.Capa_de_Ticked
{
    partial class Boleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boleto));
            this.BoletosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBoleto = new Cine.Capa_de_Ticked.dbBoleto();
            this.rvBoleto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BoletosTableAdapter = new Cine.Capa_de_Ticked.dbBoletoTableAdapters.BoletosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BoletosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBoleto)).BeginInit();
            this.SuspendLayout();
            // 
            // BoletosBindingSource
            // 
            this.BoletosBindingSource.DataMember = "Boletos";
            this.BoletosBindingSource.DataSource = this.dbBoleto;
            // 
            // dbBoleto
            // 
            this.dbBoleto.DataSetName = "dbBoleto";
            this.dbBoleto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvBoleto
            // 
            this.rvBoleto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BoletosBindingSource;
            this.rvBoleto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvBoleto.LocalReport.ReportEmbeddedResource = "Cine.Reporte.BoletosCompra.rdlc";
            this.rvBoleto.Location = new System.Drawing.Point(0, 0);
            this.rvBoleto.Name = "rvBoleto";
            this.rvBoleto.Size = new System.Drawing.Size(479, 432);
            this.rvBoleto.TabIndex = 0;
            // 
            // BoletosTableAdapter
            // 
            this.BoletosTableAdapter.ClearBeforeFill = true;
            // 
            // Boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(479, 432);
            this.Controls.Add(this.rvBoleto);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Boleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleto";
            this.Load += new System.EventHandler(this.Boleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoletosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBoleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBoleto;
        private System.Windows.Forms.BindingSource BoletosBindingSource;
        private dbBoleto dbBoleto;
        private dbBoletoTableAdapters.BoletosTableAdapter BoletosTableAdapter;
    }
}