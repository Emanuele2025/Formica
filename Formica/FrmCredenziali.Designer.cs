namespace Formica
{
    partial class FrmCredenziali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCredenziali));
            BtnChiudi = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtTitolo = new TextBox();
            TxtNote = new TextBox();
            label3 = new Label();
            TxtUserName = new TextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            label5 = new Label();
            TxtPassword = new TextBox();
            label6 = new Label();
            DtgDati = new DataGridView();
            BtnInserisci = new Button();
            BtnAnnulla = new Button();
            BtnSalva = new Button();
            CmsMenu = new ContextMenuStrip(components);
            MniModifica = new ToolStripMenuItem();
            MniElimina = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DtgDati).BeginInit();
            CmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1220, 677);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 9;
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
            label1.Size = new Size(1334, 22);
            label1.TabIndex = 10;
            label1.Text = "Formica - Gestione delle credenziali";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(19, 476);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 11;
            label2.Text = "Titolo:";
            // 
            // TxtTitolo
            // 
            TxtTitolo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtTitolo.Location = new Point(21, 491);
            TxtTitolo.Name = "TxtTitolo";
            TxtTitolo.Size = new Size(371, 23);
            TxtTitolo.TabIndex = 12;
            TxtTitolo.Enter += txt_Enter;
            TxtTitolo.Leave += txt_Leave;
            // 
            // TxtNote
            // 
            TxtNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtNote.Location = new Point(424, 491);
            TxtNote.Multiline = true;
            TxtNote.Name = "TxtNote";
            TxtNote.Size = new Size(516, 128);
            TxtNote.TabIndex = 14;
            TxtNote.Enter += txt_Enter;
            TxtNote.Leave += txt_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(422, 476);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Note:";
            // 
            // TxtUserName
            // 
            TxtUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtUserName.Location = new Point(21, 536);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(371, 23);
            TxtUserName.TabIndex = 16;
            TxtUserName.Enter += txt_Enter;
            TxtUserName.Leave += txt_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(19, 521);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 15;
            label4.Text = "Username:";
            // 
            // TxtEmail
            // 
            TxtEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtEmail.Location = new Point(21, 582);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(371, 23);
            TxtEmail.TabIndex = 18;
            TxtEmail.Enter += txt_Enter;
            TxtEmail.Leave += txt_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(19, 567);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 17;
            label5.Text = "Email:";
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtPassword.Location = new Point(21, 624);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(371, 23);
            TxtPassword.TabIndex = 20;
            TxtPassword.Enter += txt_Enter;
            TxtPassword.Leave += txt_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(19, 609);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 19;
            label6.Text = "Password:";
            // 
            // DtgDati
            // 
            DtgDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgDati.Dock = DockStyle.Top;
            DtgDati.Location = new Point(0, 22);
            DtgDati.Name = "DtgDati";
            DtgDati.Size = new Size(1334, 432);
            DtgDati.TabIndex = 21;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnInserisci.Location = new Point(33, 681);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 22;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            BtnInserisci.Click += BtnInserisci_Click;
            // 
            // BtnAnnulla
            // 
            BtnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAnnulla.Location = new Point(126, 681);
            BtnAnnulla.Name = "BtnAnnulla";
            BtnAnnulla.Size = new Size(75, 23);
            BtnAnnulla.TabIndex = 23;
            BtnAnnulla.Text = "Annulla";
            BtnAnnulla.UseVisualStyleBackColor = true;
            BtnAnnulla.Click += BtnAnnulla_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalva.Location = new Point(207, 681);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 24;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
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
            // 
            // FrmCredenziali
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 712);
            Controls.Add(BtnSalva);
            Controls.Add(BtnAnnulla);
            Controls.Add(BtnInserisci);
            Controls.Add(DtgDati);
            Controls.Add(TxtPassword);
            Controls.Add(label6);
            Controls.Add(TxtEmail);
            Controls.Add(label5);
            Controls.Add(TxtUserName);
            Controls.Add(label4);
            Controls.Add(TxtNote);
            Controls.Add(label3);
            Controls.Add(TxtTitolo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnChiudi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCredenziali";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione Credenziali";
            Load += FrmCredenziali_Load;
            ((System.ComponentModel.ISupportInitialize)DtgDati).EndInit();
            CmsMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnChiudi;
        private Label label1;
        private Label label2;
        private TextBox TxtTitolo;
        private TextBox TxtNote;
        private Label label3;
        private TextBox TxtUserName;
        private Label label4;
        private TextBox TxtEmail;
        private Label label5;
        private TextBox TxtPassword;
        private Label label6;
        private DataGridView DtgDati;
        private Button BtnInserisci;
        private Button BtnAnnulla;
        private Button BtnSalva;
        private ContextMenuStrip CmsMenu;
        private ToolStripMenuItem MniModifica;
        private ToolStripMenuItem MniElimina;
    }
}