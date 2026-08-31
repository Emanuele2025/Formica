using Formica.Models;
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

        AppDbContext contesto = new AppDbContext();


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
                //Creare tabella Stati (IDStato, Stato, Descrizione)







            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore caricamento dati: " + ex.Message);
            }





        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }



        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtStato.Text.Trim() == "")
                {
                    MessageBox.Show("Campo stato vuoto, inserire del testo.");
                    return;
                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore caricamento dati: " + ex.Message);
            }
        }
    }
}
