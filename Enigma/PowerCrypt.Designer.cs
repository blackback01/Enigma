namespace Enigma
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
            this.Input = new System.Windows.Forms.TextBox();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.Output = new System.Windows.Forms.TextBox();
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
            this.Theme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Location = new System.Drawing.Point(13, 45);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(272, 345);
            this.Input.TabIndex = 0;
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
            "Transposition"});
            this.DropDown.Location = new System.Drawing.Point(13, 396);
            this.DropDown.MaxDropDownItems = 3;
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(272, 24);
            this.DropDown.TabIndex = 1;
            this.DropDown.Tag = "";
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Location = new System.Drawing.Point(291, 45);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(267, 345);
            this.Output.TabIndex = 2;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(12, 466);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(130, 48);
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
            this.Cancel.Location = new System.Drawing.Point(155, 466);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 48);
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
            this.EingabeLabel.Location = new System.Drawing.Point(12, 3);
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
            this.AusgabeLabel.Location = new System.Drawing.Point(443, 4);
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
            this.SaveToTextFile.Location = new System.Drawing.Point(291, 426);
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
            this.Encrypt.Location = new System.Drawing.Point(291, 396);
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
            this.Decrypt.Location = new System.Drawing.Point(457, 396);
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
            this.CopyToClipboard.Location = new System.Drawing.Point(291, 466);
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
            this.CustomParameter.Location = new System.Drawing.Point(12, 426);
            this.CustomParameter.Name = "CustomParameter";
            this.CustomParameter.ReadOnly = true;
            this.CustomParameter.Size = new System.Drawing.Size(273, 34);
            this.CustomParameter.TabIndex = 12;
            this.TTCP.SetToolTip(this.CustomParameter, " ");
            // 
            // TTCP
            // 
            this.TTCP.ToolTipTitle = "Custom parameter";
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
            this.Theme.Location = new System.Drawing.Point(155, 3);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(267, 38);
            this.Theme.TabIndex = 13;
            this.Theme.Text = "Dark/Light Theme";
            this.Theme.UseVisualStyleBackColor = false;
            this.Theme.Click += new System.EventHandler(this.Theme_Click);
            // 
            // PowerCrypt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(567, 520);
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
            this.Controls.Add(this.Output);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerCrypt";
            this.Text = "PowerCrypt";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.TextBox Output;
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
    }
}

