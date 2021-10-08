using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Milestone2_PRG282
{
    public partial class ElSplasho : Form
    {
        public ElSplasho()
        {
            InitializeComponent();
        }
        public static bool HasShown = false;
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            this.Hide();
            tmrSplash.Enabled = false;
            Form1.Creator = this;
            Form1 Baby = new Form1();
            Baby.Show();
        }

        private void ElSplasho_Activated(object sender, EventArgs e)
        {
            tmrSplash.Enabled = true;
            if (HasShown)
                Application.Exit();
            HasShown = true;
        }
    }
}
