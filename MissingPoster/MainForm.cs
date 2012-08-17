using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BlueToque.Utility;
using Microsoft.Reporting.WinForms;

namespace MissingPoster
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        WantedDataType m_wantedData = new WantedDataType();
        string m_fileName = string.Empty;

        // supported image file formats
        List<string> imageFileFormats = new List<string>() { ".png", ".jpg", ".gif", ".bmp", ".wmf" };

        #region private methods

        void DataBind()
        {
            wantedDataTypeBindingSource.DataSource = m_wantedData;
            pictureBox.Image = m_wantedData.Image.Image;

            dOBDateTimePicker.Checked = m_wantedData.DOBSpecified;
            if (m_wantedData.DOBSpecified)
                dOBDateTimePicker.Value = m_wantedData.DOB;

            dateLastSeenDateTimePicker.Checked = m_wantedData.DateLastSeenSpecified;
            if (m_wantedData.DateLastSeenSpecified)
                dateLastSeenDateTimePicker.Value = m_wantedData.DateLastSeen;

            timeLastSeenDateTimePicker.Checked = m_wantedData.TimeLastSeenSpecified;
            if (m_wantedData.TimeLastSeenSpecified)
            {
                if (m_wantedData.TimeLastSeen.Year < timeLastSeenDateTimePicker.MinDate.Year)
                    m_wantedData.TimeLastSeen = new DateTime(
                        timeLastSeenDateTimePicker.MinDate.Year,
                        timeLastSeenDateTimePicker.MinDate.Month,
                        timeLastSeenDateTimePicker.MinDate.Day,
                        m_wantedData.TimeLastSeen.Hour,
                        m_wantedData.TimeLastSeen.Minute,
                        m_wantedData.TimeLastSeen.Second);
                timeLastSeenDateTimePicker.Value = m_wantedData.TimeLastSeen;
            }

            FormatTitle();
        }

        public void FormatTitle()
        {
            if(m_fileName.IsNullOrEmpty())
                this.Text = string.Format("Missing Poster: New Poster");
            else
                this.Text = string.Format("Missing Poster: {0}", Path.GetFileNameWithoutExtension(m_fileName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reportViewer"></param>
        /// <param name="fileName"></param>
        /// <param name="format">"Excel", "PDF", "Word", "Image"</param>
        private void RenderReport(ReportViewer reportViewer, string fileName, string format)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer.LocalReport.Render(
                format,
                null,
                out mimeType,
                out encoding,
                out filenameExtension,
                out streamids,
                out warnings);

            string ext = Path.GetExtension(fileName).ToLower();
            if (imageFileFormats.Contains(ext))
                ExportImage(fileName, bytes);
            else
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    fs.Write(bytes, 0, bytes.Length);

        }

        private void ExportImage(string fileName, byte[] bytes)
        {
            string ext = Path.GetExtension(fileName).ToLower();

            Image image = Image.FromStream(new MemoryStream(bytes));
            switch (ext)
            {
                case ".bmp": image.Save(fileName, ImageFormat.Bmp); break;
                case ".jpg": image.Save(fileName, ImageFormat.Jpeg); break;
                case ".png": image.Save(fileName, ImageFormat.Png); break;
                case ".wmf": image.Save(fileName, ImageFormat.Wmf); break;
                case ".gif": image.Save(fileName, ImageFormat.Gif); break;
                default: MessageBox.Show(this, "Unable to export to selected format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }

        }

        #endregion

        private string SelectedReport
        {
            get
            {
                ReportDef def = (chooseReportToolStripComboBox.SelectedItem as ReportDef);
                if (def == null)
                    return string.Empty;
                return def.Path;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBind();
            List<ReportDef> reports = Directory
                .GetFiles(Path.Combine(Application.StartupPath, "Reports"), "*.rdlc")
                .Select<string, ReportDef>(x => new ReportDef(x))
                .ToList();
            chooseReportToolStripComboBox.Items.AddRange(reports.ToArray());
            chooseReportToolStripComboBox.SelectedIndex = 0;
            string[] items = Enum.GetNames(typeof(SexType));
            for (int i = 0; i < items.Length; i++)
                if (items[i] == "Blank") items[i] = "";
            sexComboBox.Items.AddRange(items);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openImageFileDialog.ShowDialog(this) != DialogResult.OK)
                    return;

                Cursor = Cursors.WaitCursor;

                Image image = Image.FromFile(openImageFileDialog.FileName);
                ImageType imageType = new ImageType()
                {
                    Image = image,
                    Path = openImageFileDialog.FileName
                };

                m_wantedData.Image = imageType;
                pictureBox.Image = image;
                wantedDataTypeBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            m_fileName = openFileDialog.FileName;

            try
            {
                Cursor = Cursors.WaitCursor;

                m_wantedData = WantedDataType.FromFile(openFileDialog.FileName);

                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (!m_fileName.IsNullOrEmpty())
            {
                saveFileDialog.FileName = m_fileName;
            }
            else if (!m_wantedData.FirstName.IsNullOrEmpty() &&
                !m_wantedData.LastName.IsNullOrEmpty())
            {
                saveFileDialog.FileName = string.Format("{0}-{1}-Missing.xml", m_wantedData.LastName.Trim(), m_wantedData.FirstName.Trim());
            }

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                
                m_wantedData.ToFile(saveFileDialog.FileName);
                m_fileName = saveFileDialog.FileName;
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            m_wantedData = new WantedDataType();
            m_fileName = string.Empty;
            DataBind();
        }

        private void dOBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_wantedData.DOBSpecified = dOBDateTimePicker.Checked;
                if (!m_wantedData.DOBSpecified)
                {
                    m_wantedData.DOB = DateTime.MinValue;
                    return;
                }
                m_wantedData.DOB = dOBDateTimePicker.Value;
                m_wantedData.Age = Convert.ToUInt32((DateTime.Now - dOBDateTimePicker.Value).TotalDays / 365.2524);
            }
            catch (Exception ex)
            {
                Trace.TraceError("Error:\r\n{0}", ex);
            }
        }

        private void dateLastSeenDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            m_wantedData.DateLastSeenSpecified = dateLastSeenDateTimePicker.Checked;
            if (!m_wantedData.DateLastSeenSpecified)
            {
                m_wantedData.DateLastSeen = DateTime.MinValue;
                return;
            }
            m_wantedData.DateLastSeen = dateLastSeenDateTimePicker.Value;

        }

        private void timeLastSeenDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            m_wantedData.TimeLastSeenSpecified = timeLastSeenDateTimePicker.Checked;
            if (!m_wantedData.TimeLastSeenSpecified)
            {
                m_wantedData.TimeLastSeen = DateTime.MinValue;
                return;
            }
            m_wantedData.TimeLastSeen = timeLastSeenDateTimePicker.Value;

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ReportViewer reportViewer = new ReportForm(m_wantedData, SelectedReport).ReportViewer;
                ReportPrintDocument document = new ReportPrintDocument(reportViewer.LocalReport);
                document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox.Image);
            m_wantedData.Image = new ImageType();
            DataBind();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox.Image);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_wantedData.Image = new ImageType()
            {
                Image = Clipboard.GetImage()
            };
            DataBind();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_wantedData.Image = new ImageType();
            DataBind();
        }

        private void imageContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // look into the clipboard and see if there's an image there
            pasteToolStripButton.Enabled = Clipboard.ContainsImage();

            cutToolStripButton.Enabled = pictureBox.Image != null;
            copyToolStripButton.Enabled = pictureBox.Image != null;
        }

        private void configToolStripButton_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog(this);
        }

        private void pdfToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "PDF File|*.pdf",
                    Title = "Save as PDF",
                    FileName = Path.ChangeExtension(m_fileName, "pdf")
                };

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;

                Cursor = Cursors.WaitCursor;

                ReportViewer reportViewer = new ReportForm(m_wantedData, SelectedReport).ReportViewer;
                RenderReport(reportViewer, sfd.FileName, "PDF");

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void previewToolStripButton_Click(object sender, EventArgs e)
        {
            new ReportForm(m_wantedData, SelectedReport).ShowDialog(this);
        }

        private void wordToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Microsoft Word Document|*.doc",
                    Title = "Save as Word Document",
                    FileName = Path.ChangeExtension(m_fileName, "doc")
                };

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;

                Cursor = Cursors.WaitCursor;

                ReportViewer reportViewer = new ReportForm(m_wantedData, SelectedReport).ReportViewer;
                RenderReport(reportViewer, sfd.FileName, "Word");

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void imageToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    DefaultExt = "*.png",
                    Filter = "PNG File|*.png|JPG File|*.jpg|Windows Bitmap|*.bmp|Windows MetaFile|*.wmf|GIF File|*.gif",
                    Title = "Save as Image",
                    FileName = Path.ChangeExtension(m_fileName, "png")
                };

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;

                Cursor = Cursors.WaitCursor;

                ReportViewer reportViewer = new ReportForm(m_wantedData, SelectedReport).ReportViewer;
                RenderReport(reportViewer, sfd.FileName, "Image");

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.Bitmap))
            //{
            //    e.Effect = DragDropEffects.Move;
            //    return;
            //}
            //if (e.Data.GetDataPresent(typeof(Bitmap)))
            //{
            //    e.Effect = DragDropEffects.Move;
            //    return;
            //}

            // DragImageBits
            //string[] formats = e.Data.GetFormats();
            //if (formats.Contains("DragImageBits"))
            //{
            //    e.Effect = DragDropEffects.Move;
            //    return;
            //}

            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || files.Length == 0)
                return;
            if (files.Length > 1)
                return;

            string ext = Path.GetExtension(files[0]).ToLower();
            if (!imageFileFormats.Contains(ext))
                return;
            e.Effect = DragDropEffects.Move;
            
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            //string[] formats = e.Data.GetFormats();
            //if (formats.Contains("DragImageBits"))
            //{
            //    return;
            //}

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || files.Length == 0 || files.Length > 1)
                return;

            string ext = Path.GetExtension(files[0]).ToLower();
            if (!imageFileFormats.Contains(ext))
                return;

            m_wantedData.Image = new ImageType()
            {
                Image = Image.FromFile(files[0]),
                Path = files[0]
            };
            DataBind();

        }

        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sexComboBox.SelectedItem as string).IsNullOrEmpty())
            {
                m_wantedData.SexSpecified=false;
                return;
            }
            m_wantedData.SexSpecified=true;
            m_wantedData.Sex=(SexType) Enum.Parse(typeof(SexType), sexComboBox.SelectedItem as string);
        }

    }
}
