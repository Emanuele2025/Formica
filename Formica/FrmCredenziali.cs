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
    public partial class FrmCredenziali : Form
    {

        AppDbContext contesto = new AppDbContext();




        public FrmCredenziali()
        {
            InitializeComponent();
        }

        private void FrmCredenziali_Load(object sender, EventArgs e)
        {
            try
            {
                Text = Utility.TitoloFinestra;

                CaricaDati();
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }


        private void CaricaDati()
        {

            try
            {
                //var dati = conteto.Credenziali.FirstOrDefault();



                BtnAnnulla.Visible = false;
                BtnInserisci.Visible = true;
                BtnSalva.Visible = false;
                DtgDati.Enabled = true;
                TxtEmail.Text = "";
                TxtNote.Text = "";
                TxtPassword.Text = "";
                TxtTitolo.Text = "";
                TxtUserName.Text = "";

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

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtTitolo.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Il campo Titolo e Password sono obbligatori.");
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
            try
            {
                CaricaDati();
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtTitolo.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Il campo Titolo e Password sono obbligatori.");
                    return;
                }

                Utility.MesssaggioInserimento();



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void MniModifica_Click(object sender, EventArgs e)
        {
            try
            {
                DtgDati.Enabled = false;

                //Riporto i dati della riga
                TxtTitolo.Text = DtgDati.SelectedRows[0].Cells["Titolo"]?.Value?.ToString();
                TxtEmail.Text = DtgDati.SelectedRows[0].Cells["Email"]?.Value?.ToString();
                TxtNote.Text = DtgDati.SelectedRows[0].Cells["Note"]?.Value?.ToString();
                TxtPassword.Text = DtgDati.SelectedRows[0].Cells["Password"]?.Value?.ToString();
                 
                TxtUserName.Text = DtgDati.SelectedRows[0].Cells["UserName"]?.Value?.ToString();


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void MniElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utility.CancellaRecord())
                {
                    //Cancello
                    int idCredenziale = Convert.ToInt32(DtgDati.SelectedRows[0].Cells["IdCredenziale"].Value);
                    var credenzialeTrovato = contesto.Credenzialis.Where(riga => riga.IdCredenziale == idCredenziale).FirstOrDefault();
                    if (credenzialeTrovato != null)
                    {
                        contesto.Credenzialis.Remove(credenzialeTrovato);
                        if(contesto.SaveChanges()>0)
                        {
                            Utility.MesssaggioCancellazione();
                            CaricaDati();
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }
    }
}
