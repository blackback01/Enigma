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
        public Form1()
        {
            InitializeComponent();
            DropDown.SelectedIndex = 0;
        }

        private void Ausgabe_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Eingabe.Text = "";
            Ausgabe.Text = "";
            DropDown.SelectedIndex = 0;
        }

        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (Encrypt.Checked == true)
            {
                Ausgabe.Text = "";
                Decrypt.Checked = false;
            }
        }

        private void Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (Decrypt.Checked == true)
            {
                Ausgabe.Text = "";
                Encrypt.Checked = false;
            }

        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (DropDown.SelectedIndex == 1 && Encrypt.Checked == true)
            {
                Ausgabe.Text = activeSub.Encrypt(Eingabe.Text);
            }
            if (DropDown.SelectedIndex == 1 && Decrypt.Checked == true)
            {
                Ausgabe.Text = activeSub.Decrypt(Eingabe.Text);
            }
        }
    }
}
