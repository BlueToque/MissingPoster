namespace MissingPoster
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.contactTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wantedDataTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wantedDataTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactTypeBindingSource
            // 
            this.contactTypeBindingSource.DataMember = "Contact";
            this.contactTypeBindingSource.DataSource = this.wantedDataTypeBindingSource;
            // 
            // wantedDataTypeBindingSource
            // 
            this.wantedDataTypeBindingSource.DataSource = typeof(MissingPoster.WantedDataType);
            // 
            // imageTypeBindingSource
            // 
            this.imageTypeBindingSource.DataMember = "Image";
            this.imageTypeBindingSource.DataSource = this.wantedDataTypeBindingSource;
            // 
            // headerTypeBindingSource
            // 
            this.headerTypeBindingSource.DataMember = "Header";
            this.headerTypeBindingSource.DataSource = this.wantedDataTypeBindingSource;
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "ContactDataSet";
            reportDataSource1.Value = this.contactTypeBindingSource;
            reportDataSource2.Name = "WantedData";
            reportDataSource2.Value = this.wantedDataTypeBindingSource;
            reportDataSource3.Name = "ImageDataSet";
            reportDataSource3.Value = this.imageTypeBindingSource;
            reportDataSource4.Name = "HeaderDataSet";
            reportDataSource4.Value = this.headerTypeBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer.LocalReport.DisplayName = "Wanted Poster";
            this.reportViewer.LocalReport.ReportEmbeddedResource = "MissingPoster.Reports.Default.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowBackButton = false;
            this.reportViewer.ShowPageNavigationControls = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.Size = new System.Drawing.Size(457, 326);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(150, 344);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(231, 344);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(457, 379);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Preview";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wantedDataTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource wantedDataTypeBindingSource;
        private System.Windows.Forms.BindingSource imageTypeBindingSource;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource contactTypeBindingSource;
        private System.Windows.Forms.BindingSource headerTypeBindingSource;

    }
}