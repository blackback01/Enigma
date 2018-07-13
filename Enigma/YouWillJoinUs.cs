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
    public partial class YouWillJoinUs : Form
    {
        string directory;
        System.Media.SoundPlayer ImperialMarch = new System.Media.SoundPlayer(@"H:\C28E\Programmieren 3.5\Joshua Hertling\Enigma\Enigma\bin\Debug\ImperialMarch.wav");
        public YouWillJoinUs()
        {
            //directory = Directory.GetCurrentDirectory();
            ImperialMarch.Play();
            InitializeComponent();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            this.Close();
            ImperialMarch.Stop(); 
             
        }
    }
}
