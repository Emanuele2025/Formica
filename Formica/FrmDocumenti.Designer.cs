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
            ((System.ComponentModel.ISupportInitialize)dtgDatiDocumenti).BeginInit();
            CmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1206, 625);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 5;
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
            dtgDatiDocumenti.Size = new Size(1293, 289);
            dtgDatiDocumenti.TabIndex = 7;
            // 
            // BtnSalva
            // 
            BtnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalva.Location = new Point(208, 607);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 12;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Visible = false;
            // 
            // BtnAnnulla
            // 
            BtnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAnnulla.Location = new Point(118, 607);
            BtnAnnulla.Name = "BtnAnnulla";
            BtnAnnulla.Size = new Size(75, 23);
            BtnAnnulla.TabIndex = 11;
            BtnAnnulla.Text = "Annulla";
            BtnAnnulla.UseVisualStyleBackColor = true;
            BtnAnnulla.Visible = false;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnInserisci.Location = new Point(23, 607);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 10;
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
            // FrmDocumenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 660);
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
    }
}