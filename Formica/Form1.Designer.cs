namespace Formica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsMenuPrincipale = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            esciToolStripMenuItem = new ToolStripMenuItem();
            attivitàToolStripMenuItem = new ToolStripMenuItem();
            mniGestione = new ToolStripMenuItem();
            documentiToolStripMenuItem = new ToolStripMenuItem();
            mniGestioneDocumenti = new ToolStripMenuItem();
            strumentiToolStripMenuItem = new ToolStripMenuItem();
            MniAgenda = new ToolStripMenuItem();
            MniRubrica = new ToolStripMenuItem();
            MniOpzioni = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            informazioniToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            mnsMenuPrincipale.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuPrincipale
            // 
            mnsMenuPrincipale.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, attivitàToolStripMenuItem, documentiToolStripMenuItem, strumentiToolStripMenuItem, toolStripMenuItem1 });
            mnsMenuPrincipale.Location = new Point(0, 0);
            mnsMenuPrincipale.Name = "mnsMenuPrincipale";
            mnsMenuPrincipale.Size = new Size(1014, 24);
            mnsMenuPrincipale.TabIndex = 0;
            mnsMenuPrincipale.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { esciToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // esciToolStripMenuItem
            // 
            esciToolStripMenuItem.Image = Properties.Resources.Esci;
            esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            esciToolStripMenuItem.Size = new Size(94, 22);
            esciToolStripMenuItem.Text = "Esci";
            esciToolStripMenuItem.Click += esciToolStripMenuItem_Click;
            // 
            // attivitàToolStripMenuItem
            // 
            attivitàToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniGestione });
            attivitàToolStripMenuItem.Name = "attivitàToolStripMenuItem";
            attivitàToolStripMenuItem.Size = new Size(57, 20);
            attivitàToolStripMenuItem.Text = "Attività";
            // 
            // mniGestione
            // 
            mniGestione.Name = "mniGestione";
            mniGestione.Size = new Size(180, 22);
            mniGestione.Text = "Progetti...";
            mniGestione.ToolTipText = "Apre la finestra per la gestione dei progetti";
            mniGestione.Click += gestioneToolStripMenuItem_Click;
            // 
            // documentiToolStripMenuItem
            // 
            documentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniGestioneDocumenti });
            documentiToolStripMenuItem.Name = "documentiToolStripMenuItem";
            documentiToolStripMenuItem.Size = new Size(78, 20);
            documentiToolStripMenuItem.Text = "Documenti";
            // 
            // mniGestioneDocumenti
            // 
            mniGestioneDocumenti.Name = "mniGestioneDocumenti";
            mniGestioneDocumenti.Size = new Size(129, 22);
            mniGestioneDocumenti.Text = "Gestione...";
            mniGestioneDocumenti.Click += mniGestioneDocumenti_Click;
            // 
            // strumentiToolStripMenuItem
            // 
            strumentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MniAgenda, MniRubrica, MniOpzioni });
            strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            strumentiToolStripMenuItem.Size = new Size(71, 20);
            strumentiToolStripMenuItem.Text = "Strumenti";
            // 
            // MniAgenda
            // 
            MniAgenda.Image = Properties.Resources.calendar_16x16_freeicon;
            MniAgenda.Name = "MniAgenda";
            MniAgenda.Size = new Size(124, 22);
            MniAgenda.Text = "Agenda...";
            MniAgenda.ToolTipText = "Visualizza l'agenda per gestire gli appuntamento o calenderio attività";
            MniAgenda.Click += mniAgenda_Click;
            // 
            // MniRubrica
            // 
            MniRubrica.Name = "MniRubrica";
            MniRubrica.Size = new Size(124, 22);
            MniRubrica.Text = "Rubrica...";
            // 
            // MniOpzioni
            // 
            MniOpzioni.Name = "MniOpzioni";
            MniOpzioni.Size = new Size(124, 22);
            MniOpzioni.Text = "Opzioni...";
            MniOpzioni.ToolTipText = "Apre la finestra delle opzioni";
            MniOpzioni.Click += MniOpzioni_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { informazioniToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // informazioniToolStripMenuItem
            // 
            informazioniToolStripMenuItem.Image = Properties.Resources.Informazioni;
            informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            informazioniToolStripMenuItem.Size = new Size(150, 22);
            informazioniToolStripMenuItem.Text = "Informazioni...";
            informazioniToolStripMenuItem.Click += informazioniToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(1014, 22);
            label1.TabIndex = 2;
            label1.Text = "Formica - Principale";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1014, 635);
            Controls.Add(label1);
            Controls.Add(mnsMenuPrincipale);
            MainMenuStrip = mnsMenuPrincipale;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formica  - Programma gratuito per la gestione dei task";
            Load += Form1_Load;
            mnsMenuPrincipale.ResumeLayout(false);
            mnsMenuPrincipale.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenuPrincipale;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem esciToolStripMenuItem;
        private ToolStripMenuItem attivitàToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem informazioniToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem mniGestione;
        private ToolStripMenuItem documentiToolStripMenuItem;
        private ToolStripMenuItem mniGestioneDocumenti;
        private ToolStripMenuItem strumentiToolStripMenuItem;
        private ToolStripMenuItem MniAgenda;
        private ToolStripMenuItem MniRubrica;
        private ToolStripMenuItem MniOpzioni;
    }
}
