using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmAttivita : Form
    {
        public FrmAttivita()
        {
            InitializeComponent();
        }

        private void FrmAttivita_Load(object sender, EventArgs e)
        {
            this.Text = Utility.TitoloFinestra;
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Funzioni

        #endregion
    }
}
