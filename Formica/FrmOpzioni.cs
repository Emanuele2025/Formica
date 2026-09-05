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
        int? idSelezionato;

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



                TxtStato.Text = "";
                TxtDescrizione.Text = "";
                BtnSalva.Visible = false;
                BtnInserisci.Visible = true;
                BtnAnnulla.Visible = false;
                var dati = contesto.StatoLavoraziones.ToList();
                dtgDatiStato.DataSource = dati;



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
                StatoLavorazione stato = new StatoLavorazione()
                {
                     Descrizione = TxtDescrizione.Text.Trim(),
                     Stato = TxtStato.Text.Trim()



                };

                contesto.Add(stato);
                contesto.SaveChanges();


                CaricaDati();

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore caricamento dati: " + ex.Message);
            }
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtStato.Text.Trim() == "")
                {
                    MessageBox.Show("Campo stato vuoto, inserire del testo.");
                    return;
                }

              
                var record = contesto.StatoLavoraziones.Where(riga => riga.IdStato == idSelezionato).FirstOrDefault();
                if (record != null)
                {
                    record.Descrizione = TxtDescrizione.Text.Trim();
                    record.Stato = TxtStato.Text.Trim();
                    if (contesto.SaveChanges() > 0)
                        Utility.MessaggioInfo("Record salvato con successo. ");


                    CaricaDati();

                }
  




            }
            catch (Exception ex)
            {

                Utility.MessaggioErrore("Errore salvataggio dati: " + ex.Message);
            }
        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            CaricaDati();
        }

        private void MniElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatiStato.SelectedRows.Count==0)
                {
                    Utility.MessaggioInfo("Selezionare una riga");
                    return;
                }

                if (!Utility.CancellaRecord())
                {
                    return;
                }
                int idRecord = 0;
                idRecord = Convert.ToInt32(dtgDatiStato.SelectedRows[0].Cells["IdStato"].Value);

                var record = contesto.StatoLavoraziones.Where(riga => riga.IdStato == idRecord).FirstOrDefault();
                if (record != null)
                {
                    contesto.StatoLavoraziones.Remove(record);
                    if (contesto.SaveChanges() > 0)
                        Utility.MessaggioInfo("Record cancellato con successo. ");


                    CaricaDati();

                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore nella cancellazione dei dati: " + ex.Message);
            }
        }

        private void MniModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatiStato.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selezionare una riga");
                    return;
                }

                idSelezionato = Convert.ToInt32(dtgDatiStato.SelectedRows[0].Cells["IdStato"].Value);
                TxtStato.Text = dtgDatiStato.SelectedRows[0].Cells["Stato"]?.Value?.ToString();
                TxtDescrizione.Text = dtgDatiStato.SelectedRows[0].Cells["Descrizione"]?.Value?.ToString();
                BtnAnnulla.Visible = true;
                BtnSalva.Visible = true;
                BtnInserisci.Visible = false;
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore nella modifica dei dati: " + ex.Message);
            }
        }

        private void dtgDatiStato_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Verifico il tasto detro e se non ha fatto click nell'intestazione delle grafiglia o fuori dalle celle

            if (e.Button != MouseButtons.Right)
                return;



            //Escludo intestazioni e griglia

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;



            CmsMenu.Show(Cursor.Position);



        }
    }
}
