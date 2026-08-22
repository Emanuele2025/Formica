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
    public partial class FrmGestioneProgetti : Form
    {
        public FrmGestioneProgetti()
        {
            InitializeComponent();
        }

        AppDbContext contesto = new AppDbContext();


        private void FrmGestioneProgetti_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloFinestra;
                CaricaDati();
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
        }

        #region Funzioni


        //TODO: Mettere il cursore di attesa
        //TDOO: mettere le funzioni
        //TODO: cambia il colore giallo e bianco delle textbox



        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }



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




        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtNomeProgetto.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Campo nome progetto obbligatorio");
                    return;

                }
                Progetti progetto = new Progetti
                {
                    Nome = TxtNomeProgetto.Text.Trim(),
                    Descrizione = TxtDescrizione.Text.Trim()



                };




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
        }

        private void dtgDatiProgetti_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Click destro su una cella valida
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Controllo che il DGV abbia almeno una riga
                if (dtgDatiProgetti.Rows.Count == 0)
                    return;

                // Recupero la riga cliccata
                var riga = dtgDatiProgetti.Rows[e.RowIndex];

                // Verifico che la riga abbia almeno un dato non vuoto
                bool rigaValida = riga.Cells
                    .Cast<DataGridViewCell>()
                    .Any(c => c.Value != null && c?.Value?.ToString()?.Trim() != "");

                if (!rigaValida)
                    return;

                // Se arrivo qui: la riga è valida → la seleziono
                dtgDatiProgetti.ClearSelection();
                riga.Selected = true;

                // Mostro il menu contestuale
                CmsMenu.Show(Cursor.Position);
            }
        }

        private void mniModifica_Click(object sender, EventArgs e)
        {
            if (dtgDatiProgetti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selezionare una riga");
                return;
            }
            int rowIndex = dtgDatiProgetti.SelectedRows[0].Index;
            DataGridViewRow row = dtgDatiProgetti.Rows[rowIndex];

        }

        private void mniElimina_Click(object sender, EventArgs e)
        {
            if (dtgDatiProgetti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selezionare una riga");
                return;
            }

            if (!Utility.CancellaRecord())
            {
                return;
            }

            int idRecord = 0;
            idRecord = Convert.ToInt32( dtgDatiProgetti.SelectedRows[0].Cells["Idprogetto"]);
            //int rowIndex = dtgDatiProgetti.SelectedRows[0].Index;
            //DataGridViewRow row = dtgDatiProgetti.Rows[rowIndex];
            //  row.DataBoundItem
            //Cancello dato

            //contesto.Progettis.Remove()
            DataRowView DrwSelezionata = (DataRowView)dtgDatiProgetti.SelectedRows[0].DataBoundItem;
            DataRow rigaSelezionata = DrwSelezionata?.Row;
            if (rigaSelezionata != null)
            {
                idRecord = rigaSelezionata.Field<int>("IdProgetto");
              
            }

        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            TxtDescrizione.Text = "";
            TxtNomeProgetto.Text = "";
            TxtNote.Text = "";
            dtpApertura.Value = DateTime.Now;
            dtpTermine.Value = dtpTermine.MaxDate;
            BtnSalva.Visible = false;
        }
    }
}
