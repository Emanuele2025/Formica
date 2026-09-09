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
            Cursor.Current = Cursors.WaitCursor;
            this.Text = Utility.TitoloFinestra;
            CaricaDati();
            Cursor.Current = Cursors.Default;
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Funzioni


        private void CaricaDati()
        {

            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }





        }

        #endregion

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + " " +  ex.Message);
            }
        }
    }
}
