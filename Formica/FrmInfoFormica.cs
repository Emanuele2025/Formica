using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmInfoFormica : Form
    {
        public FrmInfoFormica()
        {
            InitializeComponent();
        }

        private void FrmInfoFormica_Load(object sender, EventArgs e)
        {
            this.Text = Utility.TitoloFinestra;
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
