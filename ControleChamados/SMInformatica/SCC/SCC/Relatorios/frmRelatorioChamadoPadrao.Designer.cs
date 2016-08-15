namespace SCC.Relatorios
{
    partial class frmRelatorioChamadoPadrao
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
            this.viewchamadopadraoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsccDataSet1 = new SCC.dbsccDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_chamadopadraoTableAdapter = new SCC.dbsccDataSet1TableAdapters.view_chamadopadraoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewchamadopadraoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsccDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewchamadopadraoBindingSource
            // 
            this.viewchamadopadraoBindingSource.DataMember = "view_chamadopadrao";
            this.viewchamadopadraoBindingSource.DataSource = this.dbsccDataSet1;
            // 
            // dbsccDataSet1
            // 
            this.dbsccDataSet1.DataSetName = "dbsccDataSet1";
            this.dbsccDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewchamadopadraoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCC.Relatorios.Relatorio_ChamadoPadrao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(734, 559);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 80;
            // 
            // view_chamadopadraoTableAdapter
            // 
            this.view_chamadopadraoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Carregar chamado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRelatorioChamadoPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioChamadoPadrao";
            this.Text = "Relatório Chamado Padrão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorioChamadoPadrao_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorioChamadoPadrao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewchamadopadraoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsccDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbsccDataSet1 dbsccDataSet1;
        private System.Windows.Forms.BindingSource viewchamadopadraoBindingSource;
        private dbsccDataSet1TableAdapters.view_chamadopadraoTableAdapter view_chamadopadraoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

    }
}