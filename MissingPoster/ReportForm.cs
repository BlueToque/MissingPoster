using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MissingPoster
{
    public partial class ReportForm : Form
    {
        public ReportForm(WantedDataType wantedData, string reportPath)
        {
            InitializeComponent();
            this.reportViewer.LocalReport.ReportEmbeddedResource = null;
            this.reportViewer.LocalReport.ReportPath = reportPath;
            wantedDataTypeBindingSource.DataSource = wantedData;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer.RefreshReport();            
        }

        public ReportViewer ReportViewer { get { return reportViewer; } }
    }
}
