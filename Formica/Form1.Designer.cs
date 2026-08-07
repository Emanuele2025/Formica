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
            toolStripMenuItem1 = new ToolStripMenuItem();
            informazioniToolStripMenuItem = new ToolStripMenuItem();
            mnsMenuPrincipale.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuPrincipale
            // 
            mnsMenuPrincipale.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, attivitàToolStripMenuItem, toolStripMenuItem1 });
            mnsMenuPrincipale.Location = new Point(0, 0);
            mnsMenuPrincipale.Name = "mnsMenuPrincipale";
            mnsMenuPrincipale.Size = new Size(800, 24);
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
            esciToolStripMenuItem.Size = new Size(180, 22);
            esciToolStripMenuItem.Text = "Esci";
            esciToolStripMenuItem.Click += esciToolStripMenuItem_Click;
            // 
            // attivitàToolStripMenuItem
            // 
            attivitàToolStripMenuItem.Name = "attivitàToolStripMenuItem";
            attivitàToolStripMenuItem.Size = new Size(57, 20);
            attivitàToolStripMenuItem.Text = "Attività";
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
            informazioniToolStripMenuItem.Size = new Size(180, 22);
            informazioniToolStripMenuItem.Text = "Informazioni...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnsMenuPrincipale);
            MainMenuStrip = mnsMenuPrincipale;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formatica  - Programma gratuito per la gestione dei task";
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
    }
}
