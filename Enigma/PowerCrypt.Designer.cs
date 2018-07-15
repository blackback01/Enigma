namespace PowerCrypt
{
    partial class PowerCrypt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerCrypt));
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EingabeLabel = new System.Windows.Forms.Label();
            this.AusgabeLabel = new System.Windows.Forms.Label();
            this.SaveToTextFile = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.CheckBox();
            this.Decrypt = new System.Windows.Forms.CheckBox();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.CustomParameter = new System.Windows.Forms.TextBox();
            this.TTCP = new System.Windows.Forms.ToolTip(this.components);
            this.CustomParameterTwo = new System.Windows.Forms.TextBox();
            this.Theme = new System.Windows.Forms.Button();
            this.FileInput = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.InputPic = new System.Windows.Forms.PictureBox();
            this.OutputPic = new System.Windows.Forms.PictureBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnGenerateIV = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblIV = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DropDown
            // 
            this.DropDown.AccessibleDescription = "";
            this.DropDown.AccessibleName = "";
            this.DropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DropDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDown.ForeColor = System.Drawing.Color.White;
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Items.AddRange(new object[] {
            "Select encryption...",
            "Caesar",
            "Rot",
            "Rot13",
            "Vigenère",
            "Transposition",
            "AES_CBC",
            "PaulCryption"});
            this.DropDown.Location = new System.Drawing.Point(19, 395);
            this.DropDown.MaxDropDownItems = 3;
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(283, 24);
            this.DropDown.TabIndex = 1;
            this.DropDown.Tag = "";
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(19, 546);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(136, 48);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(161, 546);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(141, 48);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EingabeLabel
            // 
            this.EingabeLabel.AutoSize = true;
            this.EingabeLabel.BackColor = System.Drawing.Color.Transparent;
            this.EingabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EingabeLabel.ForeColor = System.Drawing.Color.White;
            this.EingabeLabel.Location = new System.Drawing.Point(12, 0);
            this.EingabeLabel.Name = "EingabeLabel";
            this.EingabeLabel.Size = new System.Drawing.Size(88, 38);
            this.EingabeLabel.TabIndex = 5;
            this.EingabeLabel.Text = "Input";
            // 
            // AusgabeLabel
            // 
            this.AusgabeLabel.AutoSize = true;
            this.AusgabeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AusgabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AusgabeLabel.ForeColor = System.Drawing.Color.White;
            this.AusgabeLabel.Location = new System.Drawing.Point(307, 0);
            this.AusgabeLabel.Name = "AusgabeLabel";
            this.AusgabeLabel.Size = new System.Drawing.Size(115, 38);
            this.AusgabeLabel.TabIndex = 6;
            this.AusgabeLabel.Text = "Output";
            // 
            // SaveToTextFile
            // 
            this.SaveToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveToTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToTextFile.ForeColor = System.Drawing.Color.White;
            this.SaveToTextFile.Location = new System.Drawing.Point(306, 507);
            this.SaveToTextFile.Name = "SaveToTextFile";
            this.SaveToTextFile.Size = new System.Drawing.Size(267, 34);
            this.SaveToTextFile.TabIndex = 7;
            this.SaveToTextFile.Text = "Save to TextFile";
            this.SaveToTextFile.UseVisualStyleBackColor = false;
            this.SaveToTextFile.Click += new System.EventHandler(this.SaveToTextFile_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.BackColor = System.Drawing.Color.Transparent;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.ForeColor = System.Drawing.Color.White;
            this.Encrypt.Location = new System.Drawing.Point(306, 396);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(100, 29);
            this.Encrypt.TabIndex = 8;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.CheckedChanged += new System.EventHandler(this.Encrypt_CheckedChanged);
            // 
            // Decrypt
            // 
            this.Decrypt.AutoSize = true;
            this.Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.White;
            this.Decrypt.Location = new System.Drawing.Point(472, 396);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(101, 29);
            this.Decrypt.TabIndex = 9;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.CheckedChanged += new System.EventHandler(this.Decrypt_CheckedChanged);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.CopyToClipboard.Location = new System.Drawing.Point(306, 547);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(267, 48);
            this.CopyToClipboard.TabIndex = 10;
            this.CopyToClipboard.Text = "Copy to Clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = false;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // CustomParameter
            // 
            this.CustomParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomParameter.ForeColor = System.Drawing.Color.White;
            this.CustomParameter.Location = new System.Drawing.Point(19, 465);
            this.CustomParameter.Name = "CustomParameter";
            this.CustomParameter.ReadOnly = true;
            this.CustomParameter.Size = new System.Drawing.Size(283, 34);
            this.CustomParameter.TabIndex = 12;
            this.TTCP.SetToolTip(this.CustomParameter, " ");
            // 
            // TTCP
            // 
            this.TTCP.ToolTipTitle = "Custom parameter";
            // 
            // CustomParameterTwo
            // 
            this.CustomParameterTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomParameterTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomParameterTwo.ForeColor = System.Drawing.Color.White;
            this.CustomParameterTwo.Location = new System.Drawing.Point(306, 465);
            this.CustomParameterTwo.Name = "CustomParameterTwo";
            this.CustomParameterTwo.ReadOnly = true;
            this.CustomParameterTwo.Size = new System.Drawing.Size(267, 34);
            this.CustomParameterTwo.TabIndex = 19;
            this.TTCP.SetToolTip(this.CustomParameterTwo, " ");
            // 
            // Theme
            // 
            this.Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Theme.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Theme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Theme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Theme.ForeColor = System.Drawing.Color.White;
            this.Theme.Location = new System.Drawing.Point(609, 88);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(215, 38);
            this.Theme.TabIndex = 13;
            this.Theme.Text = "Dark/Light Theme";
            this.Theme.UseVisualStyleBackColor = false;
            this.Theme.Click += new System.EventHandler(this.Theme_Click);
            // 
            // FileInput
            // 
            this.FileInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileInput.ForeColor = System.Drawing.Color.White;
            this.FileInput.Location = new System.Drawing.Point(19, 505);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(283, 36);
            this.FileInput.TabIndex = 14;
            this.FileInput.Text = "Load Files";
            this.FileInput.UseVisualStyleBackColor = false;
            this.FileInput.Click += new System.EventHandler(this.FileInput_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Input.ForeColor = System.Drawing.Color.Magenta;
            this.Input.Location = new System.Drawing.Point(19, 44);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(283, 345);
            this.Input.TabIndex = 15;
            this.Input.Text = "";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Output.ForeColor = System.Drawing.Color.Magenta;
            this.Output.Location = new System.Drawing.Point(308, 44);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(283, 345);
            this.Output.TabIndex = 16;
            this.Output.Text = "";
            // 
            // InputPic
            // 
            this.InputPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InputPic.Location = new System.Drawing.Point(5, 44);
            this.InputPic.Name = "InputPic";
            this.InputPic.Size = new System.Drawing.Size(297, 345);
            this.InputPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputPic.TabIndex = 17;
            this.InputPic.TabStop = false;
            this.InputPic.Visible = false;
            // 
            // OutputPic
            // 
            this.OutputPic.Location = new System.Drawing.Point(308, 44);
            this.OutputPic.Name = "OutputPic";
            this.OutputPic.Size = new System.Drawing.Size(283, 345);
            this.OutputPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputPic.TabIndex = 18;
            this.OutputPic.TabStop = false;
            this.OutputPic.Visible = false;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateKey.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGenerateKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGenerateKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.ForeColor = System.Drawing.Color.White;
            this.btnGenerateKey.Location = new System.Drawing.Point(609, 132);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(215, 38);
            this.btnGenerateKey.TabIndex = 20;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnGenerateIV
            // 
            this.btnGenerateIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateIV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGenerateIV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGenerateIV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateIV.ForeColor = System.Drawing.Color.White;
            this.btnGenerateIV.Location = new System.Drawing.Point(609, 176);
            this.btnGenerateIV.Name = "btnGenerateIV";
            this.btnGenerateIV.Size = new System.Drawing.Size(215, 38);
            this.btnGenerateIV.TabIndex = 21;
            this.btnGenerateIV.Text = "Generate IV";
            this.btnGenerateIV.UseVisualStyleBackColor = false;
            this.btnGenerateIV.Click += new System.EventHandler(this.btnGenerateIV_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(609, 44);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(215, 38);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.BackColor = System.Drawing.Color.Transparent;
            this.lblIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIV.ForeColor = System.Drawing.Color.White;
            this.lblIV.Location = new System.Drawing.Point(308, 430);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(191, 32);
            this.lblIV.TabIndex = 23;
            this.lblIV.Text = "IV (AES-CBC)";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.White;
            this.lblKey.Location = new System.Drawing.Point(13, 430);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(64, 32);
            this.lblKey.TabIndex = 24;
            this.lblKey.Text = "Key";
            // 
            // PowerCrypt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(836, 611);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGenerateIV);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.CustomParameterTwo);
            this.Controls.Add(this.OutputPic);
            this.Controls.Add(this.InputPic);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.FileInput);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.CustomParameter);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.SaveToTextFile);
            this.Controls.Add(this.AusgabeLabel);
            this.Controls.Add(this.EingabeLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.DropDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerCrypt";
            this.Text = "PowerCrypt";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.PowerCrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label EingabeLabel;
        private System.Windows.Forms.Label AusgabeLabel;
        private System.Windows.Forms.Button SaveToTextFile;
        private System.Windows.Forms.CheckBox Encrypt;
        private System.Windows.Forms.CheckBox Decrypt;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.TextBox CustomParameter;
        private System.Windows.Forms.ToolTip TTCP;
        private System.Windows.Forms.Button Theme;
        private System.Windows.Forms.Button FileInput;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.PictureBox InputPic;
        private System.Windows.Forms.PictureBox OutputPic;
        private System.Windows.Forms.TextBox CustomParameterTwo;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnGenerateIV;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label lblKey;
    }
}

