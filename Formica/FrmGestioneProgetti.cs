using Formica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mime;
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
        int? idSelezionato;

        private void FrmGestioneProgetti_Load(object sender, EventArgs e)
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

        #region Funzioni


         


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
                idSelezionato = null;
                TxtNote.Text = "";
                TxtDescrizione.Text = "";
                TxtNomeProgetto.Text = "";
                TxtPercorsoFile.Text = "";


                var dati = contesto.Progettis.ToList().Select(p=> new { 
                
                    p.IdProgetto,
                    p.Nome,
                    p.Descrizione,
                    p.DataApertura,
                    p.DataChiusura,
                    p.Note,
                    p.NomeFile,
                    FileAllegato = (p.File != null) ? "Scarica" : "",
                    FileProgetto = p.File
                
                } );



                dtgDatiProgetti.AutoGenerateColumns = false;
                dtgDatiProgetti.DataSource = dati.ToList();
                BtnInserisci.Visible = true;
                BtnAnnulla.Visible = false;
                BtnSalva.Visible = false;
                dtgDatiProgetti.Enabled = true;
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
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
                    Descrizione = TxtDescrizione.Text.Trim(),
                    Note = TxtNote.Text.Trim(),
                    DataApertura = dtpApertura.Value,
                    // DataChiusura = (dtpTermine.Value == dtpTermine.MaxDate) ? null : dtpTermine.Value,
                    File = (TxtPercorsoFile.Text.Trim() != "") ? File.ReadAllBytes(TxtPercorsoFile.Text.Trim()) : null,
                    NomeFile = (TxtPercorsoFile.Text.Trim() != "") ? new FileInfo(TxtPercorsoFile.Text.Trim()).Name : ""



                };
                contesto.Progettis.Add(progetto);
                if (contesto.SaveChanges() > 0)
                    Utility.MessaggioInfo("Record inserito correttamente.");

                CaricaDati();



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
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
            idSelezionato = Convert.ToInt32(dtgDatiProgetti.SelectedRows[0].Cells["IdProgetto"].Value);
            var progettoTrovato = contesto.Progettis.Where(p => p.IdProgetto == idSelezionato).FirstOrDefault();
            if (progettoTrovato != null)
            {
                TxtDescrizione.Text = progettoTrovato?.Descrizione?.Trim();
                TxtNomeProgetto.Text = progettoTrovato?.Nome.Trim();
                TxtNote.Text = progettoTrovato?.Note?.Trim();
                dtpApertura.Value = progettoTrovato.DataApertura.HasValue ? progettoTrovato.DataApertura.Value : DateTime.Now;
                if (progettoTrovato.DataChiusura != null)
                {
                    dtpTermine.Value = progettoTrovato.DataChiusura.HasValue ? progettoTrovato.DataChiusura.Value : DateTime.Now;
                }
                if (progettoTrovato.File != null)
                {
                    TxtPercorsoFile.Text = "[File]";
                }
            }


            BtnAnnulla.Visible = true;
            BtnSalva.Visible = true;
            dtgDatiProgetti.Enabled = false;
            BtnInserisci.Visible = false;

        }

        private void mniElimina_Click(object sender, EventArgs e)
        {
            try
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
                idRecord = Convert.ToInt32(dtgDatiProgetti.SelectedRows[0].Cells["Idprogetto"]);
                var progettoTrovato = contesto.Progettis.Where(p => p.IdProgetto == idRecord).FirstOrDefault();
                if (progettoTrovato != null)
                {
                    contesto.Progettis.Remove(progettoTrovato);
                    if (contesto.SaveChanges() > 0)
                        Utility.MessaggioInfo("Record cancellato con successo. ");


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
            TxtDescrizione.Text = "";
            TxtNomeProgetto.Text = "";
            TxtNote.Text = "";
            dtpApertura.Value = DateTime.Now;
            dtpTermine.Value = dtpTermine.MaxDate;
            BtnSalva.Visible = false;
            BtnAnnulla.Visible = false;
            dtgDatiProgetti.Enabled = true;
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

        private void dtgDatiProgetti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                if (dtgDatiProgetti.Columns[e.ColumnIndex].Name == "FileAllegato")
                {
                    if (dtgDatiProgetti.Rows[e.RowIndex]?.Cells["FileAllegato"]?.Value == "Scarica")
                    {
                        SaveFileDialog salvaFile = new SaveFileDialog();
                        string estensione = dtgDatiProgetti.Rows[e.RowIndex].Cells["NomeFile"].Value.ToString();
                        if (!string.IsNullOrWhiteSpace(estensione))
                        {
                            estensione = Path.GetExtension(estensione);
                            salvaFile.Filter = "File  " + estensione + "  |*" + estensione + "";
                        }
                        salvaFile.Title = "Salva file sul pc";
                        salvaFile.CheckPathExists = true;
                        if (salvaFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            byte[] fileBytes = (byte[])dtgDatiProgetti.Rows[e.RowIndex].Cells["FileProgetto"].Value;
                            if(fileBytes != null)
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

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                //if (txtFoto.Text != "[File]" & txtFoto.Text.Trim() != "")
                //    nuovoSocio.Foto = File.ReadAllBytes(txtFoto.Text);
                if (TxtNomeProgetto.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Campo nome progetto obbligatorio");
                    return;

                }
                if (idSelezionato == null)
                {
                    idSelezionato = Convert.ToInt32(dtgDatiProgetti.SelectedRows[0].Cells["IdProgetto"].Value);
                }

                var progettoTrovato = contesto.Progettis.Where(p => p.IdProgetto == idSelezionato).FirstOrDefault();
                if (progettoTrovato != null)
                {
                    progettoTrovato.Nome = TxtNomeProgetto.Text.Trim();
                    progettoTrovato.Descrizione = TxtDescrizione.Text.Trim();
                    progettoTrovato.Note = TxtNote.Text.Trim();
                    progettoTrovato.DataApertura = dtpApertura.Value;
                    if (dtpTermine.Checked)
                    {
                        progettoTrovato.DataChiusura = dtpTermine.Value;
                    }


                    
                    if (TxtPercorsoFile.Text != "[File]" & TxtPercorsoFile.Text.Trim() != "")
                    {
                        progettoTrovato.NomeFile = new FileInfo(TxtPercorsoFile.Text.Trim()).Name;
                        progettoTrovato.File =  File.ReadAllBytes(TxtPercorsoFile.Text.Trim());

                    }

                    if (contesto.SaveChanges() > 0)
                        Utility.MessaggioInfo("Modifica effettuata con successo.");

                }
                CaricaDati();



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }
    }
}
