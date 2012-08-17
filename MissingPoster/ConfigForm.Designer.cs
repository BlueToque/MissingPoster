namespace MissingPoster
{
    partial class ConfigForm
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label emailAddressLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.headerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contactGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.contactTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            emailAddressLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            this.contactGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // emailAddressLabel
            // 
            resources.ApplyResources(emailAddressLabel, "emailAddressLabel");
            emailAddressLabel.Name = "emailAddressLabel";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(phoneNumberLabel, "phoneNumberLabel");
            phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // nameLabel1
            // 
            resources.ApplyResources(nameLabel1, "nameLabel1");
            nameLabel1.Name = "nameLabel1";
            // 
            // emailAddressLabel1
            // 
            resources.ApplyResources(emailAddressLabel1, "emailAddressLabel1");
            emailAddressLabel1.Name = "emailAddressLabel1";
            // 
            // phoneNumberLabel1
            // 
            resources.ApplyResources(phoneNumberLabel1, "phoneNumberLabel1");
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(emailAddressLabel);
            this.groupBox1.Controls.Add(this.emailAddressTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // phoneNumberTextBox
            // 
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerTypeBindingSource, "PhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            // 
            // headerTypeBindingSource
            // 
            this.headerTypeBindingSource.DataMember = "Header";
            this.headerTypeBindingSource.DataSource = this.configurationBindingSource;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataSource = typeof(MissingPoster.Configuration);
            // 
            // emailAddressTextBox
            // 
            resources.ApplyResources(this.emailAddressTextBox, "emailAddressTextBox");
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerTypeBindingSource, "EmailAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerTypeBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Name = "nameTextBox";
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.DefaultExt = "*.jpg";
            resources.ApplyResources(this.openImageFileDialog, "openImageFileDialog");
            // 
            // contactGroupBox
            // 
            resources.ApplyResources(this.contactGroupBox, "contactGroupBox");
            this.contactGroupBox.Controls.Add(phoneNumberLabel1);
            this.contactGroupBox.Controls.Add(this.phoneNumberTextBox1);
            this.contactGroupBox.Controls.Add(emailAddressLabel1);
            this.contactGroupBox.Controls.Add(this.emailAddressTextBox1);
            this.contactGroupBox.Controls.Add(nameLabel1);
            this.contactGroupBox.Controls.Add(this.nameTextBox1);
            this.contactGroupBox.Name = "contactGroupBox";
            this.contactGroupBox.TabStop = false;
            // 
            // phoneNumberTextBox1
            // 
            resources.ApplyResources(this.phoneNumberTextBox1, "phoneNumberTextBox1");
            this.phoneNumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTypeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox1.Name = "phoneNumberTextBox1";
            // 
            // contactTypeBindingSource
            // 
            this.contactTypeBindingSource.DataMember = "Contact";
            this.contactTypeBindingSource.DataSource = this.configurationBindingSource;
            // 
            // emailAddressTextBox1
            // 
            resources.ApplyResources(this.emailAddressTextBox1, "emailAddressTextBox1");
            this.emailAddressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTypeBindingSource, "EmailAddress", true));
            this.emailAddressTextBox1.Name = "emailAddressTextBox1";
            // 
            // nameTextBox1
            // 
            resources.ApplyResources(this.nameTextBox1, "nameTextBox1");
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTypeBindingSource, "Name", true));
            this.nameTextBox1.Name = "nameTextBox1";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.contactGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            this.contactGroupBox.ResumeLayout(false);
            this.contactGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.BindingSource headerTypeBindingSource;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.GroupBox contactGroupBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox1;
        private System.Windows.Forms.BindingSource contactTypeBindingSource;
        private System.Windows.Forms.TextBox emailAddressTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource configurationBindingSource;
    }
}