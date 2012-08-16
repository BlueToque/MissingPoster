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
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label emailAddressLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
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
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(53, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(15, 48);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            emailAddressLabel.TabIndex = 2;
            emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(10, 74);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(53, 22);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 0;
            nameLabel1.Text = "Name:";
            // 
            // emailAddressLabel1
            // 
            emailAddressLabel1.AutoSize = true;
            emailAddressLabel1.Location = new System.Drawing.Point(15, 48);
            emailAddressLabel1.Name = "emailAddressLabel1";
            emailAddressLabel1.Size = new System.Drawing.Size(76, 13);
            emailAddressLabel1.TabIndex = 2;
            emailAddressLabel1.Text = "Email Address:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(10, 74);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel1.TabIndex = 4;
            phoneNumberLabel1.Text = "Phone Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(emailAddressLabel);
            this.groupBox1.Controls.Add(this.emailAddressTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agency";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(261, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(85, 85);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerTypeBindingSource, "PhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(97, 71);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(157, 20);
            this.phoneNumberTextBox.TabIndex = 5;
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
            this.emailAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerTypeBindingSource, "EmailAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emailAddressTextBox.Location = new System.Drawing.Point(97, 45);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(157, 20);
            this.emailAddressTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerTypeBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(97, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(157, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.DefaultExt = "*.jpg";
            this.openImageFileDialog.Filter = "Image Files |*.png;*.jpg;*.bmp;*.gif";
            this.openImageFileDialog.Title = "Open Image";
            // 
            // contactGroupBox
            // 
            this.contactGroupBox.Controls.Add(phoneNumberLabel1);
            this.contactGroupBox.Controls.Add(this.phoneNumberTextBox1);
            this.contactGroupBox.Controls.Add(emailAddressLabel1);
            this.contactGroupBox.Controls.Add(this.emailAddressTextBox1);
            this.contactGroupBox.Controls.Add(nameLabel1);
            this.contactGroupBox.Controls.Add(this.nameTextBox1);
            this.contactGroupBox.Location = new System.Drawing.Point(12, 12);
            this.contactGroupBox.Name = "contactGroupBox";
            this.contactGroupBox.Size = new System.Drawing.Size(354, 100);
            this.contactGroupBox.TabIndex = 1;
            this.contactGroupBox.TabStop = false;
            this.contactGroupBox.Text = "Contact";
            // 
            // phoneNumberTextBox1
            // 
            this.phoneNumberTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTypeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox1.Location = new System.Drawing.Point(97, 71);
            this.phoneNumberTextBox1.Name = "phoneNumberTextBox1";
            this.phoneNumberTextBox1.Size = new System.Drawing.Size(250, 20);
            this.phoneNumberTextBox1.TabIndex = 5;
            // 
            // contactTypeBindingSource
            // 
            this.contactTypeBindingSource.DataMember = "Contact";
            this.contactTypeBindingSource.DataSource = this.configurationBindingSource;
            // 
            // emailAddressTextBox1
            // 
            this.emailAddressTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailAddressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTypeBindingSource, "EmailAddress", true));
            this.emailAddressTextBox1.Location = new System.Drawing.Point(97, 45);
            this.emailAddressTextBox1.Name = "emailAddressTextBox1";
            this.emailAddressTextBox1.Size = new System.Drawing.Size(250, 20);
            this.emailAddressTextBox1.TabIndex = 3;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTypeBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(97, 19);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(250, 20);
            this.nameTextBox1.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(110, 253);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(191, 253);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(377, 288);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.contactGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "Configuration";
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