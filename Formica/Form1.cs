namespace Formica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloFinestra;
                //TODO : task chiusi in percentuali
                //TODO: come consigliato da AI, visualizzare una Dashboard con i task chiusi, aperti etc
                //TODO: Visualizzare i task in un dataGrid
                //TODO: fare form, che inserisce il progetto (progetto e non task) come nome progetto, descrizione, data inserito e data conclusione
                //TODO: fare form per inserire le opzioni, come priorità (Urgente, immediata, normale, bassa) stato (da fare, in corso, completato, sospesa)
                //TODO task, descrizione, percentuale di completamente, nome, descrizione, progetto, documento, informazioni
                //TODO: FAre anche se è un bug, implementazione, attività normale come nota, etc
                //Comando per aggiornare tutto                      dotnet ef dbcontext scaffold "Data Source=Database/formica.db" Microsoft.EntityFrameworkCore.Sqlite--context AppDbContext --output - dir Models--force
                //Comando per aggiornare solo nuove tabelle         dotnet ef dbcontext scaffold "Data Source=Database/formica.db" Microsoft.EntityFrameworkCore.Sqlite --table Progetti --table Clienti --context AppDbContext --output-dir Models --force
                //TODO : FAre anche Agenda
                //Ultimo comando funziona dopo il cd nel progetto - dotnet ef dbcontext scaffold "Data Source=Database/formica.db" Microsoft.EntityFrameworkCore.Sqlite --context AppDbContext --output-dir Models --force
                //TODO: Valutare in schermata di mettere una griglia con lo stato degli ultimi task


                VerificaATtivita();







            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore durante il caricamento dell'applicativo." + ex.Message);
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfoFormica info = new FrmInfoFormica();
            info.ShowDialog();
        }

        private void gestioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmGestioneProgetti gestione = new FrmGestioneProgetti();
            gestione.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void mniAgenda_Click(object sender, EventArgs e)
        {
            //TODO: Apre finestra dell'agenda
            Cursor.Current = Cursors.WaitCursor;
            FrmAgenda agenda = new FrmAgenda();
            agenda.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void mniGestioneDocumenti_Click(object sender, EventArgs e)
        {
            //TODO: Apre finestra gestione dei documenti
        }

        private void MniOpzioni_Click(object sender, EventArgs e)
        {
            FrmOpzioni opzioni = new FrmOpzioni();
            opzioni.ShowDialog();
        }

        private void LnkAttivitaTerminate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Apro task chiuse
        }

        private void lnkAttivitaAperte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //apro task attività aperte

        }


        #region funzioni

        private void VerificaATtivita()
        {

            //Imposto la percentuale per le attività rosso sotto il 50, tra il 50 e 85 giallo e sopra 85 verde

            try
            {
                int percentualeTaskAperti = 0;
                int percentualeTaskChiusi = 0;

                lnkAttivitaAperte.Text = percentualeTaskAperti.ToString() + "%";
                LnkAttivitaTerminate.Text = percentualeTaskChiusi.ToString() + "%";  
                //TODO: Farlo con lo switch nuovo

                if (percentualeTaskAperti < 50)
                {
                    lnkAttivitaAperte.LinkColor = Color.Red;
                }
                if (percentualeTaskChiusi < 50)
                {
                    LnkAttivitaTerminate.LinkColor = Color.Red;
                }


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore durante il caricamento dell'applicativo." + ex.Message);
            }




        
        }




        #endregion





    }
}
