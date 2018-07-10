using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Form1 : Form
    {
        Substitution Sub = new Substitution();
        Substitution activeSub = new Caesar();
        Viginere v = new Viginere();

        public Form1()
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
            if(DropDown.SelectedIndex == 2 || DropDown.SelectedIndex == 4)
            {
                CustomParameter.ReadOnly = false;
            }else if(DropDown.SelectedIndex != 2 || DropDown.SelectedIndex != 4)
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
            if (DropDown.SelectedIndex == 4 && Encrypt.Checked == true)
            {
                Output.Text = v.Encrypt(Input.Text, CustomParameter.Text);
            }
            if (DropDown.SelectedIndex == 4 && Decrypt.Checked == true)
            {
                Output.Text = v.Decrypt(Input.Text, CustomParameter.Text);
            }
        }
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Output.Text);
        }

        private void CustomParameter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
