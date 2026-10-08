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
    public partial class FrmDocumenti : Form
    {

        AppDbContext contesto = new AppDbContext();


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


                BtnAnnulla.Visible = false;
                BtnSalva.Visible = false;
                BtnInserisci.Visible = true;



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
                    int idDocumento = Convert.ToInt32(dtgDatiDocumenti.SelectedRows[0].Cells["IdDocumento"].Value);

                    //var documentoTrovato = contesto.Documenti.Where(d => d.IdDocumento == idDocumento).FirstOrDefault();
                    //if (documentoTrovato != null)
                    //{





                    //}

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

                if (TxtTitolo.Text.Trim() == "" || TxtPercorsoFile.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("I Campi titolo e percorso file sono obbligatori.");
                    return;
                }









            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            CaricaDati();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {





                CaricaDati();
            }
            catch (Exception ex)
            {

                Utility.MessaggioErrore(Utility.Errore + ex.Message);
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

        private void MniModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatiDocumenti.SelectedRows.Count < 1)
                {
                    Utility.MessaggioInfo("Selezionare una riga da modificare.");
                    return;
                }






            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }
    }
}
