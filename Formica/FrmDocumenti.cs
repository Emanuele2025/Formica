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

                //var dati = contesto.Documenti.ToList();

                var dati = contesto.Documentis.ToList().Select(p => new
                {

                    p.IdDocumento,
                    p.Titolo,
                    p.NomeFile,
                    p.Descrizione,
                    FileAllegato = (p.File != null) ? "Scarica" : "",
                    FileProgetto = p.File

                });

                dtgDatiDocumenti.DataSource = dati.ToList();
                BtnAnnulla.Visible = false;
                BtnSalva.Visible = false;
                BtnInserisci.Visible = true;
                TxtPercorsoFile.Text = "";
                TxtTitolo.Text = "";
                TxtDescrizione.Text = "";
                dtgDatiDocumenti.Enabled = true;

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
                    Utility.MessaggioInfo("Selezionare una riga");
                    return;
                }

                if (Utility.CancellaRecord())
                {
                    int idDocumento = Convert.ToInt32(dtgDatiDocumenti.SelectedRows[0].Cells["IdDocumento"].Value);

                    var documentoTrovato = contesto.Documentis.Where(d => d.IdDocumento == idDocumento).FirstOrDefault();
                    if (documentoTrovato != null)
                    {

                        contesto.Documentis.Remove(documentoTrovato);
                        if (contesto.SaveChanges() > 0)
                        {
                            Utility.MessaggioInfo("Cancellazione avvvenuta con successo.");

                            CaricaDati();

                        }


                    }




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

                Documenti documento = new Documenti
                {
                    Descrizione = TxtDescrizione.Text,
                    Titolo = TxtTitolo.Text,


                    NomeFile = new FileInfo(TxtPercorsoFile.Text.Trim()).Name,
                    File = File.ReadAllBytes(TxtPercorsoFile.Text.Trim())
                };

                contesto.Documentis.Add(documento);

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

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            CaricaDati();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtTitolo.Text.Trim() == "" || TxtPercorsoFile.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("I Campi titolo e percorso file sono obbligatori.");
                    return;
                }
                int idDocumento = Convert.ToInt32(dtgDatiDocumenti.SelectedRows[0].Cells["IdDocumento"].Value);

                var documentoTrovato = contesto.Documentis.Where(d => d.IdDocumento == idDocumento).FirstOrDefault();
                if (TxtPercorsoFile.Text == "[File]")
                {

                    documentoTrovato.Descrizione = TxtDescrizione.Text;
                    documentoTrovato.Titolo = TxtTitolo.Text;


                }
                else
                {

                    documentoTrovato.Descrizione = TxtDescrizione.Text;
                    documentoTrovato.Titolo = TxtTitolo.Text;

                    documentoTrovato.NomeFile = new FileInfo(TxtPercorsoFile.Text.Trim()).Name;
                    documentoTrovato.File = File.ReadAllBytes(TxtPercorsoFile.Text.Trim());

                }


                if (contesto.SaveChanges() > 0)
                {
                    Utility.MessaggioInfo(Utility.Modifica);
                    CaricaDati();
                }

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

                int idDocumento = Convert.ToInt32(dtgDatiDocumenti.SelectedRows[0].Cells["IdDocumento"].Value);

                var documentoTrovato = contesto.Documentis.Where(d => d.IdDocumento == idDocumento).FirstOrDefault();
                if (documentoTrovato != null)
                {

                    TxtDescrizione.Text = documentoTrovato.Descrizione;
                    TxtTitolo.Text = documentoTrovato.Titolo;
                    TxtPercorsoFile.Text = "[File]";


                }
                dtgDatiDocumenti.Enabled = false;
                BtnInserisci.Visible = false;
                BtnAnnulla.Visible = true;
                BtnSalva.Visible = true;


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void BtnCercaFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {

                openDlg.Multiselect = false;

                openDlg.Filter = "Tutti Files (*.*) | *.*";

                if (openDlg.ShowDialog(this) == DialogResult.OK)
                {
                    TxtPercorsoFile.Text = openDlg.FileName;
                }

            }
        }

        private void dtgDatiDocumenti_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Click destro su una cella valida
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Controllo che il DGV abbia almeno una riga
                if (dtgDatiDocumenti.Rows.Count == 0)
                    return;

                // Recupero la riga cliccata
                var riga = dtgDatiDocumenti.Rows[e.RowIndex];

                // Verifico che la riga abbia almeno un dato non vuoto
                bool rigaValida = riga.Cells
                    .Cast<DataGridViewCell>()
                    .Any(c => c.Value != null && c?.Value?.ToString()?.Trim() != "");

                if (!rigaValida)
                    return;

                // Se arrivo qui: la riga è valida → la seleziono
                dtgDatiDocumenti.ClearSelection();
                riga.Selected = true;

                // Mostro il menu contestuale
                CmsMenu.Show(Cursor.Position);
            }
        }

        private void dtgDatiDocumenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dtgDatiDocumenti.Columns[e.ColumnIndex].Name == "FileAllegato")
                {
                    if (dtgDatiDocumenti.Rows[e.RowIndex]?.Cells["FileAllegato"]?.Value == "Scarica")
                    {
                        SaveFileDialog salvaFile = new SaveFileDialog();
                        string estensione = dtgDatiDocumenti.Rows[e.RowIndex].Cells["NomeFile"].Value.ToString();
                        if (!string.IsNullOrWhiteSpace(estensione))
                        {
                            estensione = Path.GetExtension(estensione);
                            salvaFile.Filter = "File  " + estensione + "  |*" + estensione + "";
                        }
                        salvaFile.Title = "Salva file sul pc";
                        salvaFile.CheckPathExists = true;
                        if (salvaFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            byte[] fileBytes = (byte[])dtgDatiDocumenti.Rows[e.RowIndex].Cells["FileProgetto"].Value;
                            if (fileBytes != null)
                                File.WriteAllBytes(salvaFile.FileName, fileBytes);

                        }
                    }
                }
            }
            catch (IOException exio)
            {
                Utility.MessaggioErrore(Utility.Errore + exio.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }
    }
}
