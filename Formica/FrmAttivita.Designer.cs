namespace Formica
{
    partial class FrmAttivita
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
            label2 = new Label();
            TxtNomeAttivita = new TextBox();
            TxtDescrizione = new TextBox();
            label3 = new Label();
            TxtNote = new TextBox();
            label4 = new Label();
            CmsAttivita = new ContextMenuStrip(components);
            DtgDatiAttivita = new DataGridView();
            MniModifica = new ToolStripMenuItem();
            MniElimina = new ToolStripMenuItem();
            dtpTermine = new DateTimePicker();
            label6 = new Label();
            dtpApertura = new DateTimePicker();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            CmbStato = new ComboBox();
            label9 = new Label();
            CmbProgetto = new ComboBox();
            CmsAttivita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgDatiAttivita).BeginInit();
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
            label1.Size = new Size(1236, 22);
            label1.TabIndex = 3;
            label1.Text = "Formica - Gestione delle attività";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1130, 600);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 4;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.TextAlign = ContentAlignment.MiddleRight;
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 366);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome Attività:";
            // 
            // TxtNomeAttivita
            // 
            TxtNomeAttivita.Location = new Point(12, 386);
            TxtNomeAttivita.MaxLength = 200;
            TxtNomeAttivita.Name = "TxtNomeAttivita";
            TxtNomeAttivita.Size = new Size(251, 23);
            TxtNomeAttivita.TabIndex = 1;
            // 
            // TxtDescrizione
            // 
            TxtDescrizione.Location = new Point(12, 433);
            TxtDescrizione.MaxLength = 500;
            TxtDescrizione.Multiline = true;
            TxtDescrizione.Name = "TxtDescrizione";
            TxtDescrizione.Size = new Size(251, 112);
            TxtDescrizione.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 413);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Descrizione:";
            // 
            // TxtNote
            // 
            TxtNote.Location = new Point(973, 395);
            TxtNote.MaxLength = 1000;
            TxtNote.Multiline = true;
            TxtNote.Name = "TxtNote";
            TxtNote.ScrollBars = ScrollBars.Both;
            TxtNote.Size = new Size(251, 150);
            TxtNote.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(970, 375);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 30;
            label4.Text = "Note";
            // 
            // CmsAttivita
            // 
            CmsAttivita.Items.AddRange(new ToolStripItem[] { MniModifica, MniElimina });
            CmsAttivita.Name = "contextMenuStrip1";
            CmsAttivita.Size = new Size(122, 48);
            // 
            // DtgDatiAttivita
            // 
            DtgDatiAttivita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgDatiAttivita.Dock = DockStyle.Top;
            DtgDatiAttivita.Location = new Point(0, 22);
            DtgDatiAttivita.Name = "DtgDatiAttivita";
            DtgDatiAttivita.Size = new Size(1236, 279);
            DtgDatiAttivita.TabIndex = 12;
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
            // dtpTermine
            // 
            dtpTermine.Checked = false;
            dtpTermine.Format = DateTimePickerFormat.Short;
            dtpTermine.Location = new Point(521, 386);
            dtpTermine.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpTermine.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtpTermine.Name = "dtpTermine";
            dtpTermine.ShowCheckBox = true;
            dtpTermine.Size = new Size(200, 23);
            dtpTermine.TabIndex = 4;
            dtpTermine.Value = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 364);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 34;
            label6.Text = "Termine:";
            // 
            // dtpApertura
            // 
            dtpApertura.Format = DateTimePickerFormat.Short;
            dtpApertura.Location = new Point(301, 386);
            dtpApertura.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpApertura.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpApertura.Name = "dtpApertura";
            dtpApertura.Size = new Size(200, 23);
            dtpApertura.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 366);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 33;
            label5.Text = "Apertura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(742, 364);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 35;
            label7.Text = "Stato:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(302, 413);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 36;
            label8.Text = "Progetto:";
            // 
            // CmbStato
            // 
            CmbStato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbStato.FormattingEnabled = true;
            CmbStato.Location = new Point(742, 389);
            CmbStato.Name = "CmbStato";
            CmbStato.Size = new Size(194, 23);
            CmbStato.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(592, 319);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 38;
            label9.Text = "Termine:";
            // 
            // CmbProgetto
            // 
            CmbProgetto.FormattingEnabled = true;
            CmbProgetto.Location = new Point(301, 433);
            CmbProgetto.Name = "CmbProgetto";
            CmbProgetto.Size = new Size(420, 23);
            CmbProgetto.TabIndex = 6;
            // 
            // FrmAttivita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 652);
            Controls.Add(CmbProgetto);
            Controls.Add(label9);
            Controls.Add(CmbStato);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpTermine);
            Controls.Add(label6);
            Controls.Add(dtpApertura);
            Controls.Add(label5);
            Controls.Add(DtgDatiAttivita);
            Controls.Add(TxtNote);
            Controls.Add(label4);
            Controls.Add(TxtDescrizione);
            Controls.Add(label3);
            Controls.Add(TxtNomeAttivita);
            Controls.Add(label2);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAttivita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attività";
            Load += FrmAttivita_Load;
            CmsAttivita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtgDatiAttivita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private Label label2;
        private TextBox TxtNomeAttivita;
        private TextBox TxtDescrizione;
        private Label label3;
        private TextBox TxtNote;
        private Label label4;
        private ContextMenuStrip CmsAttivita;
        private ToolStripMenuItem MniModifica;
        private ToolStripMenuItem MniElimina;
        private DataGridView DtgDatiAttivita;
        private DateTimePicker dtpTermine;
        private Label label6;
        private DateTimePicker dtpApertura;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox CmbStato;
        private Label label9;
        private ComboBox CmbProgetto;
    }
}