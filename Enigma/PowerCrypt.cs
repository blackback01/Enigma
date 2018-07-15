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

namespace PowerCrypt
{
    public partial class PowerCrypt : Form
    {
        #region Declarations
        private string fextension;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog ofd = new OpenFileDialog();
        private Substitution Sub = new Substitution();
        private Substitution activeSub;
        private Viginere v = new Viginere();
        private Transposition t;
        private PaulCryption pc = new PaulCryption();
        #endregion
        public PowerCrypt()
        {
            InitializeComponent();
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
            if (DropDown.SelectedIndex == 2 || DropDown.SelectedIndex == 4 || DropDown.SelectedIndex == 5 || DropDown.SelectedIndex == 6 || DropDown.SelectedIndex == 7)
               CustomParameter.ReadOnly = false;
            else if (DropDown.SelectedIndex != 2 || DropDown.SelectedIndex != 4 || DropDown.SelectedIndex != 5 || DropDown.SelectedIndex != 6 || DropDown.SelectedIndex != 7)
            {
                CustomParameter.ReadOnly = true;
                CustomParameter.Text = "";
            }

            if (DropDown.SelectedIndex == 6)
                CustomParameterTwo.ReadOnly = false;
            else if (DropDown.SelectedIndex != 6)
            {
                CustomParameterTwo.ReadOnly = true;
                CustomParameterTwo.Text = "";
            }
        } 
       
        

        private void PowerCrypt_Load(object sender, EventArgs e)
        {

        }


        #region Button Click events
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
            if (DropDown.SelectedIndex == 6 && Encrypt.Checked == true)
            {
                //Variables
                string key = CustomParameter.Text;
                string IV = CustomParameterTwo.Text;

                //Vailid Key and IV length ?
                if (key.Length != 32 || IV.Length != 16)
                    MessageBox.Show("Invaild Key or IV. IV Size: 16, Key Size: 32");

                //Encrpt Text
                AES_CBC aes = new AES_CBC(key, IV);

                Output.Text = aes.Encrypt(Input.Text);
            }
            if (DropDown.SelectedIndex == 6 && Decrypt.Checked == true)
            {
                //Variables
                string key = CustomParameter.Text;
                string IV = CustomParameterTwo.Text;

                //Vailid Key and IV length?
                if (key.Length != 32 || IV.Length != 16)
                    MessageBox.Show("Invaild Key or IV. IV Size: 16, Key Size: 32");

                //Decrypt
                AES_CBC aes = new AES_CBC(key, IV);

                try
                {
                    Output.Text = aes.Decrypt(Input.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
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

        //Generate Key 
        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            //Random string
            char[] letters = "qwertzuiopasdfghjklyxcvbnm".ToCharArray();
            Random r = new Random();
            string randomString = "";
            
            //AES Key
            if (DropDown.SelectedIndex == 6)
            {
                for(int i = 0; i <= 31; i++)
                {
                    randomString += letters[r.Next(0, 25)].ToString();
                }
                CustomParameter.Text = randomString;
            }
            else
            {
                MessageBox.Show("Select an encryption Algorithm");
            }
                
        }

        //Generate IV (AES only)
        private void btnGenerateIV_Click(object sender, EventArgs e)
        {
            //Random string
            char[] letters = "qwertzuiopasdfghjklyxcvbnm".ToCharArray();
            Random r = new Random();
            string randomString = "";

            if(DropDown.SelectedIndex == 6)
            {
                for(int i = 0; i <= 15; i++)
                {
                    randomString += letters[r.Next(0, 25)].ToString();
                    CustomParameterTwo.Text = randomString;
                }
            }
            else
            {
                MessageBox.Show("This is only for AES-CBC encryption");
            }

            
        }
           
        //File Input
        private void FileInput_Click(object sender, EventArgs e)
        {
            ofd.Filter = ("TextFiles (*.txt,*.pdf,*.rtf,*.bat)|*.txt;*.pdf;*.rtf,*.bat");
            if (this.ofd.ShowDialog() == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Input.Text = System.IO.File.ReadAllText(fname);
            }
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
        #endregion
    }
}
