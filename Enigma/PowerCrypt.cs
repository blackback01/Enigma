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
        #region Declarations
        string fextension;
        SaveFileDialog saveFileDialog1;
        OpenFileDialog ofd;
        Substitution Sub;
        Substitution activeSub;
        Viginere v;
        Transposition t;
        AES_CBC aes;
        PaulCryption pc;
        #endregion
        public PowerCrypt()
        {
            InitializeComponent();
            DropDown.SelectedIndex = 0;
        }
        //Cancel Button
        private void Cancel_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
            InputPic.Visible = false;
            OutputPic.Visible = false;
            DropDown.SelectedIndex = 0;
        }
        //Encrypt Checkbox
        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (Encrypt.Checked == true)
            {
                Output.Text = "";
                Decrypt.Checked = false;
            }
        }
        //Decrypt Checkbox
        private void Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (Decrypt.Checked == true)
            {
                Output.Text = "";
                Encrypt.Checked = false;
            }

        }
        //Dropdown Menu
        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDown.SelectedIndex == 2 || DropDown.SelectedIndex == 4 || DropDown.SelectedIndex == 5 || DropDown.SelectedIndex == 7)
            {
                CustomParameter.ReadOnly = false;
            }
            else if (DropDown.SelectedIndex != 2 || DropDown.SelectedIndex != 4 || DropDown.SelectedIndex != 5 || DropDown.SelectedIndex != 7)
            {
                CustomParameter.ReadOnly = true;
                CustomParameter.Text = "";
            }
        } 
        //File Input
        private void FileInput_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fname = ofd.FileName;
                fextension = Path.GetExtension(ofd.FileName);
                if(fextension == ".txt" || fextension == ".pdf" || fextension == ".rtf")
                    Input.Text = System.IO.File.ReadAllText(fname);
                else if(fextension == ".png" || fextension == ".jpeg" || fextension == ".jpg")
                {
                    InputPic.Visible = true;
                    InputPic.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        //Start Encrypt & DecryptS
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
                Output.Text =t.Encrypt(Input.Text);
            }
            if (DropDown.SelectedIndex == 5 && Decrypt.Checked == true)
            {
                t = new Transposition(Convert.ToInt32(CustomParameter.Text));
                Output.Text = t.Decrypt(Input.Text);
            }
            #endregion
            #region AES Encrypt & Decrypt
            /*if (DropDown.SelectedIndex == 6 && Encrypt.Checked == true)
            {
                if (fextension == ".txt" || fextension == ".pdf" || fextension == ".rtf")
                    Output.Text = aes.Encrypt(Input.Text); 
                else if (fextension == ".png" || fextension == ".jpeg" || fextension == ".jpg")
                {
                    OutputPic.Visible = true;
                    OutputPic.Image = aes.EncryptImage();
                }
                
            }
            if (DropDown.SelectedIndex == 6 && Decrypt.Checked == true)
            {
                if (fextension == ".txt" || fextension == ".pdf" || fextension == ".rtf")
                    Output.Text = aes.Decrypt(Input.Text);
                else if (fextension == ".png" || fextension == ".jpeg" || fextension == ".jpg")
                {
                    OutputPic.Visible = true;
                    OutputPic.Image = aes.Decrypt(InputPic.Image);
                }
            }*/
            #endregion
            #region PaulCryption Encrypt & Decrypt
            if (DropDown.SelectedIndex == 7 && Encrypt.Checked == true)
            {
                Output.Text = pc.Encrypt(Input.Text, Convert.ToInt32(CustomParameter.Text));
            }
            if (DropDown.SelectedIndex == 7 && Decrypt.Checked == true)
            {
                Output.Text = pc.Decrypt(Input.Text, Convert.ToInt32(CustomParameter.Text));
            }
            #endregion
            #region test
            if (DropDown.SelectedIndex == 8 && Encrypt.Checked == true)
            {
                if (fextension == ".txt" || fextension == ".pdf" || fextension == ".rtf")
                    Output.Text = activeSub.Encrypt(Input.Text);
                else if (fextension == ".png" || fextension == ".jpeg" || fextension == ".jpg")
                {
                    OutputPic.Visible = true;
                    OutputPic.Image = InputPic.Image;
                }
                
            } else if (DropDown.SelectedIndex == 8 && Decrypt.Checked == true)
            {
                if (fextension == ".txt" || fextension == ".pdf" || fextension == ".rtf")
                    Output.Text = activeSub.Decrypt(Input.Text);
                else if (fextension == ".png" || fextension == ".jpeg" || fextension == ".jpg")
                {
                    OutputPic.Visible = true;
                    OutputPic.Image = InputPic.Image;
                }
            }
            #endregion
        }
        //Copy to Clipboard
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (Output.Text != "")
            {
                Clipboard.SetText(Output.Text);
            }
        }
        //Save to TextFile
        private void SaveToTextFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Text File|*.txt",
                Title = "Save your encrypted or decrypted Message"
            };
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
        //Theme Change
        private void Theme_Click(object sender, EventArgs e)
        {
            YouWillJoinUs YWJU = new YouWillJoinUs();
            YWJU.Show();

        }
    }
}
