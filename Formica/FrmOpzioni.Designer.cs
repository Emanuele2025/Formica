namespace Formica
{
    partial class FrmOpzioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            BtnChiudi = new Button();
            tabControl1 = new TabControl();
            tbpStato = new TabPage();
            TxtDescrizione = new TextBox();
            label3 = new Label();
            dtgDatiStato = new DataGridView();
            BtnAnnulla = new Button();
            BtnSalva = new Button();
            BtnInserisci = new Button();
            TxtStato = new TextBox();
            lblTitolod = new Label();
            tabPage2 = new TabPage();
            CmsMenu = new ContextMenuStrip(components);
            MniModifica = new ToolStripMenuItem();
            MniElimina = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tbpStato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatiStato).BeginInit();
            CmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1037, 22);
            label1.TabIndex = 7;
            label1.Text = "Formica - Opzioni";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(950, 520);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 8;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.TextAlign = ContentAlignment.MiddleRight;
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpStato);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1037, 468);
            tabControl1.TabIndex = 9;
            // 
            // tbpStato
            // 
            tbpStato.Controls.Add(TxtDescrizione);
            tbpStato.Controls.Add(label3);
            tbpStato.Controls.Add(dtgDatiStato);
            tbpStato.Controls.Add(BtnAnnulla);
            tbpStato.Controls.Add(BtnSalva);
            tbpStato.Controls.Add(BtnInserisci);
            tbpStato.Controls.Add(TxtStato);
            tbpStato.Controls.Add(lblTitolod);
            tbpStato.Location = new Point(4, 24);
            tbpStato.Name = "tbpStato";
            tbpStato.Padding = new Padding(3);
            tbpStato.Size = new Size(1029, 440);
            tbpStato.TabIndex = 0;
            tbpStato.Text = "Stato";
            tbpStato.UseVisualStyleBackColor = true;
            // 
            // TxtDescrizione
            // 
            TxtDescrizione.Location = new Point(212, 340);
            TxtDescrizione.MaxLength = 2000;
            TxtDescrizione.Multiline = true;
            TxtDescrizione.Name = "TxtDescrizione";
            TxtDescrizione.Size = new Size(641, 23);
            TxtDescrizione.TabIndex = 8;
            TxtDescrizione.Enter += txt_Enter;
            TxtDescrizione.Leave += txt_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 322);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Descrizione:";
            // 
            // dtgDatiStato
            // 
            dtgDatiStato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiStato.Dock = DockStyle.Top;
            dtgDatiStato.Location = new Point(3, 3);
            dtgDatiStato.Name = "dtgDatiStato";
            dtgDatiStato.Size = new Size(1023, 289);
            dtgDatiStato.TabIndex = 6;
            dtgDatiStato.CellMouseDown += dtgDatiStato_CellMouseDown;
            // 
            // BtnAnnulla
            // 
            BtnAnnulla.Location = new Point(174, 411);
            BtnAnnulla.Name = "BtnAnnulla";
            BtnAnnulla.Size = new Size(75, 23);
            BtnAnnulla.TabIndex = 4;
            BtnAnnulla.Text = "Annulla";
            BtnAnnulla.UseVisualStyleBackColor = true;
            BtnAnnulla.Click += BtnAnnulla_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(93, 411);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 3;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Location = new Point(12, 411);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 2;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            BtnInserisci.Click += BtnInserisci_Click;
            // 
            // TxtStato
            // 
            TxtStato.Location = new Point(12, 340);
            TxtStato.MaxLength = 20;
            TxtStato.Name = "TxtStato";
            TxtStato.Size = new Size(156, 23);
            TxtStato.TabIndex = 1;
            TxtStato.Enter += txt_Enter;
            TxtStato.Leave += txt_Leave;
            // 
            // lblTitolod
            // 
            lblTitolod.AutoSize = true;
            lblTitolod.Location = new Point(12, 322);
            lblTitolod.Name = "lblTitolod";
            lblTitolod.Size = new Size(37, 15);
            lblTitolod.TabIndex = 0;
            lblTitolod.Text = "Stato:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1029, 440);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CmsMenu
            // 
            CmsMenu.Items.AddRange(new ToolStripItem[] { MniModifica, MniElimina });
            CmsMenu.Name = "CmsMenu";
            CmsMenu.Size = new Size(122, 48);
            // 
            // MniModifica
            // 
            MniModifica.Name = "MniModifica";
            MniModifica.Size = new Size(121, 22);
            MniModifica.Text = "Modifica";
            MniModifica.Click += MniModifica_Click;
            // 
            // MniElimina
            // 
            MniElimina.Name = "MniElimina";
            MniElimina.Size = new Size(121, 22);
            MniElimina.Text = "Elimina";
            MniElimina.Click += MniElimina_Click;
            // 
            // FrmOpzioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 544);
            Controls.Add(tabControl1);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmOpzioni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falco - Finestra Opzioni";
            Load += FrmOpzioni_Load;
            tabControl1.ResumeLayout(false);
            tbpStato.ResumeLayout(false);
            tbpStato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatiStato).EndInit();
            CmsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private TabControl tabControl1;
        private TabPage tbpStato;
        private Button BtnAnnulla;
        private Button BtnSalva;
        private Button BtnInserisci;
        private TextBox TxtStato;
        private Label lblTitolod;
        private TabPage tabPage2;
        private DataGridView dtgDatiStato;
        private TextBox TxtDescrizione;
        private Label label3;
        private ContextMenuStrip CmsMenu;
        private ToolStripMenuItem MniModifica;
        private ToolStripMenuItem MniElimina;
    }
}