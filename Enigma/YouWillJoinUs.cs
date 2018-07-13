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
    public partial class YouWillJoinUs : Form
    {
        //string directory;
        public YouWillJoinUs()
        {
            InitializeComponent();
        }
        private void Join_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
