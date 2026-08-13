using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmGestioneProgetti : Form
    {
        public FrmGestioneProgetti()
        {
            InitializeComponent();
        }

        private void FrmGestioneProgetti_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloFinestra;
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
        }

        #region Funzioni








        #endregion




        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
