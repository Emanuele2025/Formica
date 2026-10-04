using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmDocumenti : Form
    {
        public FrmDocumenti()
        {
            InitializeComponent();
        }

        private void FrmDocumenti_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Text = Utility.TitoloFinestra;
                CaricaDati();
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CaricaDati()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }



        }

        private void MniElimina_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dtgDatiDocumenti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }

                if (Utility.CancellaRecord())
                {





                }





            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            //if (TxtNomeProgetto.Text.Trim() == "")
            //{
            //    Utility.MessaggioInfo("Campo nome progetto obbligatorio");
            //    return;

            //}
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            CaricaDati();
        }
    }
}
