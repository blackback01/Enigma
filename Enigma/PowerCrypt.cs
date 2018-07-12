using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Enigma
{
    public partial class PowerCrypt : Form
    {

        Substitution Sub = new Substitution();
        Substitution activeSub = new Caesar();
        Viginere v = new Viginere();
        Transposition t;

        public PowerCrypt()
        {
            InitializeComponent();
            DropDown.SelectedIndex = 0;
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
            DropDown.SelectedIndex = 0;
        }

        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (Encrypt.Checked == true)
            {
                Output.Text = "";
                Decrypt.Checked = false;
            }
        }

        private void Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (Decrypt.Checked == true)
            {
                Output.Text = "";
                Encrypt.Checked = false;
            }

        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDown.SelectedIndex == 2 || DropDown.SelectedIndex == 4 || DropDown.SelectedIndex == 5)
            {
                CustomParameter.ReadOnly = false;
            }
            else if (DropDown.SelectedIndex != 2 || DropDown.SelectedIndex != 4)
            {
                CustomParameter.ReadOnly = true;
                CustomParameter.Text = "";
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            #region  Caesar Encrypt & Decrypt
            if (DropDown.SelectedIndex == 1 && Encrypt.Checked == true)
            {
                Output.Text = activeSub.Encrypt(Input.Text);
            }
            if (DropDown.SelectedIndex == 1 && Decrypt.Checked == true)
            {
                Output.Text = activeSub.Decrypt(Input.Text);
            }
            #endregion
            #region Rot Encrypt & Decrypt
            if (DropDown.SelectedIndex == 2 && Encrypt.Checked == true)
            {
                activeSub = new Rot(Convert.ToInt32(CustomParameter.Text));
                Output.Text = activeSub.Encrypt(Input.Text);
            }
            if (DropDown.SelectedIndex == 2 && Decrypt.Checked == true)
            {
                activeSub = new Rot(Convert.ToInt32(CustomParameter.Text));
                Output.Text = activeSub.Decrypt(Input.Text);
            }
            #endregion
            #region Rot13 Encrypt & Decrypt
            if (DropDown.SelectedIndex == 3 && Encrypt.Checked == true)
            {
                Output.Text = activeSub.Encrypt(Input.Text);
            }
            if (DropDown.SelectedIndex == 3 && Decrypt.Checked == true)
            {
                Output.Text = activeSub.Decrypt(Input.Text);
            }
            #endregion
            #region Vigenere Encrypt & Decrypt
            if (DropDown.SelectedIndex == 4 && Encrypt.Checked == true)
            {
                Output.Text = v.Encrypt(Input.Text, CustomParameter.Text);
            }
            if (DropDown.SelectedIndex == 4 && Decrypt.Checked == true)
            {
                Output.Text = v.Decrypt(Input.Text, CustomParameter.Text);
            }
            #endregion
            #region Transposition Encrypt & Decrypt
            if (DropDown.SelectedIndex == 5 && Encrypt.Checked == true)
            {
                t = new Transposition(Convert.ToInt32(CustomParameter.Text));
                Output.Text = activeSub.Encrypt(Input.Text);
            }
            if (DropDown.SelectedIndex == 5 && Decrypt.Checked == true)
            {
                t = new Transposition(Convert.ToInt32(CustomParameter.Text));
                Output.Text = activeSub.Decrypt(Input.Text);
            }
            #endregion
        }
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
            else
            {

            }
        }

        private void SaveToTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save your encrypted or decrypted Message";
            saveFileDialog1.ShowDialog();
            if (!File.Exists(saveFileDialog1.FileName))
            {
                string Text = Output.Text + Environment.NewLine;
                File.WriteAllText(saveFileDialog1.FileName, Text);
            }
            else if (File.Exists(saveFileDialog1.FileName))
            {
                File.Delete(saveFileDialog1.FileName);
                string Text = Output.Text + Environment.NewLine;
                File.AppendAllText(saveFileDialog1.FileName, Text);
            }
        }
    }
}
