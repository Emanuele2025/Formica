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
    public partial class FrmAttivita : Form
    {
        public FrmAttivita()
        {
            InitializeComponent();
        }
        AppDbContext contesto = new AppDbContext();
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

                var progetti = contesto.Progettis.Select(p => new { p.Nome, p.IdProgetto }).ToList();
                CmbProgetto.DisplayMember = "Nome";
                CmbProgetto.ValueMember = "IdProgetto";

                CmbProgetto.DataSource = progetti;
                if (CmbProgetto.Items.Count > 0)
                {
                    CmbProgetto.SelectedIndex = 0;
                }
                var stati = contesto.StatoLavoraziones.Select(p => new { p.IdStato, p.Stato }).ToList();
                CmbStato.DisplayMember = "Stato";
                CmbStato.ValueMember = "IdStato";
                CmbStato.DataSource = stati;
                if (CmbStato.Items.Count > 0)
                {
                    CmbStato.SelectedIndex = 0;
                }



                BtnInserisci.Visible = true;
                BtnAnnulla.Visible = false;
                BtnSalva.Visible = false;



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
                if (TxtNomeAttivita.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Il campo Nome attività è obbligatorio.");
                    return;
                }

                Attivitum attivita = new Attivitum
                {
                    Aperto = dtpApertura.Value,
                    Descrizione = TxtDescrizione.Text.Trim(),
                    IdProgetto = (int)CmbProgetto.SelectedValue,
                    IdStato = (int)CmbStato.SelectedValue,
                    Nome = TxtNomeAttivita.Text.Trim(),
                    Nota = TxtNote.Text.Trim(),
                    Urgente = ChkUrgente.Checked ? 1 : 0




                };





            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + " " + ex.Message);
            }
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtNomeAttivita.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Il campo Nome attività è obbligatorio.");
                    return;
                }


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

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            CaricaDati();
        }

        private void MniElimina_Click(object sender, EventArgs e)
        {
            try
            {

                if (DtgDatiAttivita.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }

                if (!Utility.CancellaRecord())
                {
                    return;
                }

                int idRecord = 0;
                idRecord = Convert.ToInt32(DtgDatiAttivita.SelectedRows[0].Cells["IdAttivita"].Value);






                CaricaDati();

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

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }
    }
}
