namespace SCC.Relatorios
{
    partial class frmRelatorioUsuariosCadastrados
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
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsccDataSet = new SCC.dbsccDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosTableAdapter = new SCC.dbsccDataSetTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsccDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dbsccDataSetBindingSource;
            // 
            // dbsccDataSetBindingSource
            // 
            this.dbsccDataSetBindingSource.DataSource = this.dbsccDataSet;
            this.dbsccDataSetBindingSource.Position = 0;
            // 
            // dbsccDataSet
            // 
            this.dbsccDataSet.DataSetName = "dbsccDataSet";
            this.dbsccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Usuarios";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCC.Relatorios.Relatorio_UsuariosCadastrados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(734, 606);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 80;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioUsuariosCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioUsuariosCadastrados";
            this.Text = "Relatório de Usuarios Cadastrados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorioUsuariosCadastrados_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorioUsuariosCadastrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsccDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsccDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dbsccDataSetBindingSource;
        private dbsccDataSet dbsccDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private dbsccDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}