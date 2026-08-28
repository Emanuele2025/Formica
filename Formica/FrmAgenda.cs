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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }
        AppDbContext contesto = new AppDbContext();
        Int32 idAgendaSelezionato = 0;
        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            BtnSalva.Visible = false;
            BtnAnnulla.Visible = false;
            TxtNote.Text = "";
            dtpData.Value = DateTime.Now;

            CaricaDati();


        }





        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //var dati = contesto.Agenda.ToList();
                //dtgDatiAgenda.DataSource = dati;
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

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNote.Text.Trim() == "")
                {
                    MessageBox.Show("Campo note vuoto, inserire del testo.");
                    return;
                     
                }
                Agenda agenda = new Agenda
                {
                    Note = TxtNote.Text.Trim(),
                    DataEvento = dtpData.Value



                };
                //using var context = new AppDbContext();
                //context.Agenda.Add(agenda);
                //context.SaveChanges();


                 contesto.Agenda.Add(agenda);
                contesto.SaveChanges();
                CaricaDati();


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore inserimento dati dati: " + ex.Message);
            }
        }


        private void CaricaDati()
        {

            try
            {
                idAgendaSelezionato = 0;
                TxtNote.Text = "";
                dtpData.Value = DateTime.Now;
                var dati = contesto.Agenda.ToList();
                dtgDatiAgenda.DataSource = dati;
                BtnInserisci.Visible = true;
                BtnAnnulla.Visible = false;
                BtnSalva.Visible = false;
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore caricamento dati: " + ex.Message);
            }


        }

        private void dtgDatiAgenda_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Click destro su una cella valida
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Controllo che il DGV abbia almeno una riga
                if (dtgDatiAgenda.Rows.Count == 0)
                    return;

                // Recupero la riga cliccata
                var riga = dtgDatiAgenda.Rows[e.RowIndex];

                // Verifico che la riga abbia almeno un dato non vuoto
                bool rigaValida = riga.Cells
                    .Cast<DataGridViewCell>()
                    .Any(c => c.Value != null && c?.Value?.ToString()?.Trim() != "");

                if (!rigaValida)
                    return;

                // Se arrivo qui: la riga è valida → la seleziono
                dtgDatiAgenda.ClearSelection();
                riga.Selected = true;

                // Mostro il menu contestuale
                CmsMenu.Show(Cursor.Position);
            }
        }

        private void mniElimina_Click(object sender, EventArgs e)
        {
            try
            {


                if (dtgDatiAgenda.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }

                if (!Utility.CancellaRecord())
                {
                    return;
                }

                int idRecord = 0;
                idRecord = Convert.ToInt32(dtgDatiAgenda.SelectedRows[0].Cells["IdAgenda"].Value);

                var record = contesto.Agenda.Where(riga => riga.IdAgenda == idRecord).FirstOrDefault();
                if (record != null)
                {
                    contesto.Agenda.Remove(record);
                    if (contesto.SaveChanges() > 0)
                        Utility.MessaggioInfo("Record cancellato con successo. ");
                    CaricaDati();

                }

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore durante la cancellazione del dato: " + ex.Message);
            }





        }

        private void MniModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatiAgenda.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }

                idAgendaSelezionato = Convert.ToInt32(dtgDatiAgenda.SelectedRows[0].Cells["IdAgenda"].Value);
                TxtNote.Text = dtgDatiAgenda.SelectedRows[0].Cells["Note"]?.Value?.ToString();
                dtpData.Value = Convert.ToDateTime(dtgDatiAgenda.SelectedRows[0].Cells["DataEvento"].Value);
                BtnAnnulla.Visible = true;
                BtnSalva.Visible = true;
                BtnInserisci.Visible = false;


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore durante la modifica dei   dati: " + ex.Message);
            }
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNote.Text.Trim() == "")
                {
                    MessageBox.Show("Campo note vuoto, inserire del testo.");
                    return;

                }
                
                var record = contesto.Agenda.Where(riga => riga.IdAgenda == idAgendaSelezionato).FirstOrDefault();
                if (record != null)
                {
                    record.Note = TxtNote.Text.Trim();
                    record.DataEvento = dtpData.Value;

                    
                    if (contesto.SaveChanges() > 0)
                        Utility.MessaggioInfo("Record salvato con successo. ");
                    CaricaDati();

                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore durante il salvataggio dei   dati: " + ex.Message);
            }
        }
    }
}
