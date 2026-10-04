namespace Formica
{
    partial class FrmDocumenti
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
            BtnChiudi = new Button();
            label1 = new Label();
            dtgDatiDocumenti = new DataGridView();
            BtnSalva = new Button();
            BtnAnnulla = new Button();
            BtnInserisci = new Button();
            CmsMenu = new ContextMenuStrip(components);
            MniModifica = new ToolStripMenuItem();
            MniElimina = new ToolStripMenuItem();
            BtnCercaFile = new Button();
            TxtPercorsoFile = new TextBox();
            label7 = new Label();
            TxtTitolo = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatiDocumenti).BeginInit();
            CmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1206, 604);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 8;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.TextAlign = ContentAlignment.MiddleRight;
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1293, 22);
            label1.TabIndex = 6;
            label1.Text = "Formica - Gestione dei documenti";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgDatiDocumenti
            // 
            dtgDatiDocumenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiDocumenti.Dock = DockStyle.Top;
            dtgDatiDocumenti.Location = new Point(0, 22);
            dtgDatiDocumenti.Name = "dtgDatiDocumenti";
            dtgDatiDocumenti.Size = new Size(1293, 453);
            dtgDatiDocumenti.TabIndex = 7;
            // 
            // BtnSalva
            // 
            BtnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalva.Location = new Point(208, 604);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 7;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Visible = false;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // BtnAnnulla
            // 
            BtnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAnnulla.Location = new Point(118, 604);
            BtnAnnulla.Name = "BtnAnnulla";
            BtnAnnulla.Size = new Size(75, 23);
            BtnAnnulla.TabIndex = 6;
            BtnAnnulla.Text = "Annulla";
            BtnAnnulla.UseVisualStyleBackColor = true;
            BtnAnnulla.Visible = false;
            BtnAnnulla.Click += BtnAnnulla_Click;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnInserisci.Location = new Point(12, 604);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 5;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            BtnInserisci.Click += BtnInserisci_Click;
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
            // 
            // MniElimina
            // 
            MniElimina.Name = "MniElimina";
            MniElimina.Size = new Size(121, 22);
            MniElimina.Text = "Elimina";
            MniElimina.Click += MniElimina_Click;
            // 
            // BtnCercaFile
            // 
            BtnCercaFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCercaFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaFile.Location = new Point(573, 575);
            BtnCercaFile.Name = "BtnCercaFile";
            BtnCercaFile.Size = new Size(30, 29);
            BtnCercaFile.TabIndex = 4;
            BtnCercaFile.Text = "...";
            BtnCercaFile.TextAlign = ContentAlignment.TopLeft;
            BtnCercaFile.UseVisualStyleBackColor = true;
            // 
            // TxtPercorsoFile
            // 
            TxtPercorsoFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtPercorsoFile.Location = new Point(12, 575);
            TxtPercorsoFile.Name = "TxtPercorsoFile";
            TxtPercorsoFile.ReadOnly = true;
            TxtPercorsoFile.Size = new Size(555, 23);
            TxtPercorsoFile.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(12, 557);
            label7.Name = "label7";
            label7.Size = new Size(134, 15);
            label7.TabIndex = 20;
            label7.Text = "Percorso e nome del file";
            // 
            // TxtTitolo
            // 
            TxtTitolo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtTitolo.Location = new Point(12, 518);
            TxtTitolo.MaxLength = 200;
            TxtTitolo.Name = "TxtTitolo";
            TxtTitolo.Size = new Size(424, 23);
            TxtTitolo.TabIndex = 1;
            TxtTitolo.Enter += txt_Enter;
            TxtTitolo.Leave += txt_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 500);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 24;
            label2.Text = "Titolo:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(626, 518);
            textBox1.MaxLength = 2000;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 86);
            textBox1.TabIndex = 2;
            textBox1.Enter += txt_Enter;
            textBox1.Leave += txt_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(626, 500);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 26;
            label3.Text = "Descrizione:";
            // 
            // FrmDocumenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 639);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(TxtTitolo);
            Controls.Add(label2);
            Controls.Add(BtnCercaFile);
            Controls.Add(TxtPercorsoFile);
            Controls.Add(label7);
            Controls.Add(BtnSalva);
            Controls.Add(BtnAnnulla);
            Controls.Add(BtnInserisci);
            Controls.Add(dtgDatiDocumenti);
            Controls.Add(label1);
            Controls.Add(BtnChiudi);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDocumenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione dei documenti";
            Load += FrmDocumenti_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatiDocumenti).EndInit();
            CmsMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnChiudi;
        private Label label1;
        private DataGridView dtgDatiDocumenti;
        private Button BtnSalva;
        private Button BtnAnnulla;
        private Button BtnInserisci;
        private ContextMenuStrip CmsMenu;
        private ToolStripMenuItem MniModifica;
        private ToolStripMenuItem MniElimina;
        private Button BtnCercaFile;
        private TextBox TxtPercorsoFile;
        private Label label7;
        private TextBox TxtTitolo;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}