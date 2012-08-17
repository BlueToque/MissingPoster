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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.contactTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wantedDataTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.reportViewer, "reportViewer");
            reportDataSource5.Name = "ContactDataSet";
            reportDataSource5.Value = this.contactTypeBindingSource;
            reportDataSource6.Name = "WantedData";
            reportDataSource6.Value = this.wantedDataTypeBindingSource;
            reportDataSource7.Name = "ImageDataSet";
            reportDataSource7.Value = this.imageTypeBindingSource;
            reportDataSource8.Name = "HeaderDataSet";
            reportDataSource8.Value = this.headerTypeBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer.LocalReport.DisplayName = "Wanted Poster";
            this.reportViewer.LocalReport.ReportEmbeddedResource = "MissingPoster.Reports.Default.rdlc";
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowBackButton = false;
            this.reportViewer.ShowPageNavigationControls = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AcceptButton = this.cancelButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.cancelButton);
            this.KeyPreview = true;
            this.Name = "ReportForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = global::MissingPoster.Properties.Settings.Default.ReportForm_WindowState;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportForm_KeyDown);
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource contactTypeBindingSource;
        private System.Windows.Forms.BindingSource headerTypeBindingSource;

    }
}