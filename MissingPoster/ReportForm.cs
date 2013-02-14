using System;
using System.Drawing;
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

            WantedDataType l_wantedData = wantedData.Clone();

            // figure out the new size of the image
            Size size = Renderer.GetSize(reportPath, 300).ToSize();
            if (l_wantedData.Image != null &&
                l_wantedData.Image.Image != null &&
                l_wantedData.Image.Image.Size != size)
            {

                Image image = Renderer.resizeImage(l_wantedData.Image.Image, size);
                l_wantedData.Image.Image = image;
            }

            wantedDataTypeBindingSource.DataSource = l_wantedData;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer.RefreshReport();            
        }

        public ReportViewer ReportViewer { get { return reportViewer; } }

        private void ReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

    }
}
