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

        //TODO: Gestire il copia in memora della password e della riga


        public FrmCredenziali()
        {
            InitializeComponent();
        }

        private void FrmCredenziali_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Text = Utility.TitoloFinestra;
                DtgDati.AutoGenerateColumns = false;
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


        private void CaricaDati()
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //var dati = conteto.Credenziali.FirstOrDefault();
                var dati = contesto.Credenzialis.ToList();
                DtgDati.DataSource = dati;

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
            finally
            {
                Cursor.Current = Cursors.Default;

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
                Int32 idCredeziale = Convert.ToInt32(DtgDati.SelectedRows[0].Cells["IdCredenziale"].Value);

                var credenzialeTrovato = contesto.Credenzialis.Where(riga => riga.IdCredenziale == idCredeziale).FirstOrDefault();

                if (credenzialeTrovato != null)
                {
                    credenzialeTrovato.Email = TxtEmail.Text.Trim();
                    credenzialeTrovato.Nota = TxtNote.Text.Trim();
                    credenzialeTrovato.Titolo = TxtTitolo.Text.Trim();
                    credenzialeTrovato.Password = TxtPassword.Text.Trim();
                    credenzialeTrovato.UserName = TxtUserName.Text.Trim();
                    if (contesto.SaveChanges() > 0)
                    {
                        Utility.MessaggioInfo("Dati salvati correttamente.");
                        CaricaDati();
                    }
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

                Credenziali credenziali = new Credenziali
                {

                    Email = TxtEmail.Text.Trim(),
                    Nota = TxtNote.Text.Trim(),
                    Titolo = TxtTitolo.Text.Trim(),
                    Password = TxtPassword.Text.Trim(),
                    UserName = TxtUserName.Text.Trim()



                };
                contesto.Credenzialis.Add(credenziali);
                if (contesto.SaveChanges() > 0)
                {
                    Utility.MesssaggioInserimento();
                    CaricaDati();
                }





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
                TxtNote.Text = DtgDati.SelectedRows[0].Cells["Nota"]?.Value?.ToString();
                TxtPassword.Text = DtgDati.SelectedRows[0].Cells["Password"]?.Value?.ToString();

                TxtUserName.Text = DtgDati.SelectedRows[0].Cells["UserName"]?.Value?.ToString();
                BtnSalva.Visible = true;
                BtnAnnulla.Visible = true;
                BtnInserisci.Visible = false;

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
                        if (contesto.SaveChanges() > 0)
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

        private void DtgDati_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Click destro su una cella valida
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Controllo che il DGV abbia almeno una riga
                if (DtgDati.Rows.Count == 0)
                    return;

                // Recupero la riga cliccata
                var riga = DtgDati.Rows[e.RowIndex];

                // Verifico che la riga abbia almeno un dato non vuoto
                bool rigaValida = riga.Cells
                    .Cast<DataGridViewCell>()
                    .Any(c => c.Value != null && c?.Value?.ToString()?.Trim() != "");

                if (!rigaValida)
                    return;

                // Se arrivo qui: la riga è valida → la seleziono
                DtgDati.ClearSelection();
                riga.Selected = true;

                // Mostro il menu contestuale
                CmsMenu.Show(Cursor.Position);
            }
        }
    }
}
