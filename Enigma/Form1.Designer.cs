namespace Enigma
{
    partial class Form1
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
            this.Eingabe = new System.Windows.Forms.TextBox();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.Ausgabe = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EingabeLabel = new System.Windows.Forms.Label();
            this.AusgabeLabel = new System.Windows.Forms.Label();
            this.SaveToTextFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eingabe
            // 
            this.Eingabe.Location = new System.Drawing.Point(13, 45);
            this.Eingabe.Multiline = true;
            this.Eingabe.Name = "Eingabe";
            this.Eingabe.Size = new System.Drawing.Size(285, 345);
            this.Eingabe.TabIndex = 0;
            // 
            // DropDown
            // 
            this.DropDown.AccessibleDescription = "";
            this.DropDown.AccessibleName = "";
            this.DropDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Items.AddRange(new object[] {
            "Select encryption...",
            "Caesar",
            "Rot13",
            "Vigenère"});
            this.DropDown.Location = new System.Drawing.Point(13, 396);
            this.DropDown.MaxDropDownItems = 3;
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(285, 24);
            this.DropDown.TabIndex = 1;
            this.DropDown.Tag = "";
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(304, 45);
            this.Ausgabe.Multiline = true;
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.ReadOnly = true;
            this.Ausgabe.Size = new System.Drawing.Size(254, 375);
            this.Ausgabe.TabIndex = 2;
            this.Ausgabe.TextChanged += new System.EventHandler(this.Ausgabe_TextChanged);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(13, 426);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(130, 48);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(168, 426);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 48);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EingabeLabel
            // 
            this.EingabeLabel.AutoSize = true;
            this.EingabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EingabeLabel.Location = new System.Drawing.Point(12, 3);
            this.EingabeLabel.Name = "EingabeLabel";
            this.EingabeLabel.Size = new System.Drawing.Size(136, 38);
            this.EingabeLabel.TabIndex = 5;
            this.EingabeLabel.Text = "Eingabe";
            // 
            // AusgabeLabel
            // 
            this.AusgabeLabel.AutoSize = true;
            this.AusgabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AusgabeLabel.Location = new System.Drawing.Point(406, 3);
            this.AusgabeLabel.Name = "AusgabeLabel";
            this.AusgabeLabel.Size = new System.Drawing.Size(146, 38);
            this.AusgabeLabel.TabIndex = 6;
            this.AusgabeLabel.Text = "Ausgabe";
            // 
            // SaveToTextFile
            // 
            this.SaveToTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToTextFile.Location = new System.Drawing.Point(305, 427);
            this.SaveToTextFile.Name = "SaveToTextFile";
            this.SaveToTextFile.Size = new System.Drawing.Size(253, 47);
            this.SaveToTextFile.TabIndex = 7;
            this.SaveToTextFile.Text = "Save to TextFile";
            this.SaveToTextFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 486);
            this.Controls.Add(this.SaveToTextFile);
            this.Controls.Add(this.AusgabeLabel);
            this.Controls.Add(this.EingabeLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.Eingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Eingabe;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.TextBox Ausgabe;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label EingabeLabel;
        private System.Windows.Forms.Label AusgabeLabel;
        private System.Windows.Forms.Button SaveToTextFile;
    }
}

