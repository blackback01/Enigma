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
        public Form1()
        {
            InitializeComponent();
            DropDown.SelectedIndex = 0;
        }

        private void Ausgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DropDown.Items.Remove("Select encryption...");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Eingabe.Text = "";
            Ausgabe.Text = "";
            DropDown.SelectedIndex = 0;
        }
    }
}
