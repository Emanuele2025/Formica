using Formica.Models;

namespace Formica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AppDbContext contesto = new AppDbContext();


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloFinestra;
                 
                //TODO: come consigliato da AI, visualizzare una Dashboard con i task chiusi, aperti etc
                 
                
                //TODO: fare form per inserire le opzioni, come priorità (Urgente, immediata, normale, bassa)  
                 
                //TODO: FAre anche se è un bug, implementazione, attività normale come nota, etc
                //Comando per aggiornare tutto                      dotnet ef dbcontext scaffold "Data Source=Database/formica.db" Microsoft.EntityFrameworkCore.Sqlite--context AppDbContext --output - dir Models--force
                //Comando per aggiornare solo nuove tabelle         dotnet ef dbcontext scaffold "Data Source=Database/formica.db" Microsoft.EntityFrameworkCore.Sqlite --table Progetti --table Clienti --context AppDbContext --output-dir Models --force
                //TODO : FAre anche Agenda
                //Ultimo comando funziona dopo il cd nel progetto - dotnet ef dbcontext scaffold "Data Source=Database/formica.db" Microsoft.EntityFrameworkCore.Sqlite --context AppDbContext --output-dir Models --force
                 


                VerificaAttivita();







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
            Cursor.Current = Cursors.WaitCursor;
            FrmOpzioni opzioni = new FrmOpzioni();
            opzioni.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void LnkAttivitaTerminate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Apro task chiuse
            Cursor.Current = Cursors.WaitCursor;
            FrmAttivita attivita = new FrmAttivita();
            attivita.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void lnkAttivitaAperte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //apro task attività aperte
            Cursor.Current = Cursors.WaitCursor;
            FrmAttivita attivita = new FrmAttivita();
            attivita.ShowDialog();
            Cursor.Current = Cursors.Default;

        }


        #region funzioni

        private void VerificaAttivita()
        {

            //Imposto la percentuale per le attività rosso sotto il 50, tra il 50 e 85 giallo e sopra 85 verde

            try
            {
                int percentualeTaskAperti = 0;
                int percentualeTaskChiusi = 0;

                int TotaleTask = 0;
                int TaskAperti = 0;
                int TaskChiusi = 0;

                TotaleTask = contesto.Attivita.Count();
                TaskAperti = contesto.Attivita.Where(p => p.Chiuso == null).Count();
                TaskChiusi = contesto.Attivita.Where(p => p.Chiuso != null).Count();

                percentualeTaskAperti = CalcolaPercentuale(TaskAperti, TotaleTask);
                percentualeTaskChiusi = CalcolaPercentuale(TaskChiusi, TotaleTask);


                lnkAttivitaAperte.Text = percentualeTaskAperti.ToString() + "%";
                LnkAttivitaTerminate.Text = percentualeTaskChiusi.ToString() + "%";

                if (percentualeTaskAperti > 85)
                {
                    lnkAttivitaAperte.LinkColor = Color.Red;
                }
                else if (percentualeTaskAperti > 3 && percentualeTaskAperti < 85)
                {
                    lnkAttivitaAperte.LinkColor = Color.Orange;
                }
                else if ( percentualeTaskAperti < 3)
                {
                    lnkAttivitaAperte.LinkColor = Color.Green;
                }
                if (percentualeTaskChiusi < 50)
                {
                    LnkAttivitaTerminate.LinkColor = Color.Red;
                }
                else if (percentualeTaskChiusi > 49 && percentualeTaskChiusi < 85)
                {
                    LnkAttivitaTerminate.LinkColor = Color.Orange;
                }

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore durante il caricamento dell'applicativo." + ex.Message);
            }





        }



 
        /// <summary>
        /// Rileva la percentuale su due numeri
        /// </summary>
        /// <param name="parte"></param>
        /// <param name="totale"></param>
        /// <returns></returns>
        private int CalcolaPercentuale(double parte, double totale)
        {
            if (totale == 0)
            {
                 
                return 0;
            }
            return Convert.ToInt32((parte / totale) * 100);
        }


        

        #endregion





        private void MniAttivita_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmAttivita attivita = new FrmAttivita();
            attivita.ShowDialog();
            Cursor.Current = Cursors.Default;

        }
    }
}
