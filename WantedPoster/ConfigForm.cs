using System;
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

            Configuration.Instance.Header.Image = Image.FromFile(openImageFileDialog.FileName);
            pictureBox.Image = Configuration.Instance.Header.Image;
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
