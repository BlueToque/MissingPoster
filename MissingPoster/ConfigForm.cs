using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MissingPoster
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog(this) != DialogResult.OK)
                return;
            try
            {
                Configuration.Instance.Header.Image = Image.FromFile(openImageFileDialog.FileName);
                pictureBox.Image = Configuration.Instance.Header.Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.TraceError("Error:\r\n{0}", ex);
            }
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            configurationBindingSource.DataSource = Configuration.Instance;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Configuration.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Configuration.Load();
        }
    }
}
