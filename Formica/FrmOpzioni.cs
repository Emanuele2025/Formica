using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmOpzioni : Form
    {
        public FrmOpzioni()
        {
            InitializeComponent();
        }

        private void FrmOpzioni_Load(object sender, EventArgs e)
        {
            //TODO: mettere gestione dello stato (Da iniziare, in lavorazione, Sospeso, Terminato) con campo testo, ID ed una Descrizione, in caso si avvicina il mouse, con il tooltiptext
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Text = Utility.TitoloFinestra;
                CaricaDati();

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore caricamento dati: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }




        }


        private void CaricaDati()
        {

            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore caricamento dati: " + ex.Message);
            }





        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
