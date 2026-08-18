namespace Formica
{
    partial class FrmGestioneProgetti
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
            dtgDatiProgetti = new DataGridView();
            CmsMenu = new ContextMenuStrip(components);
            mniModifica = new ToolStripMenuItem();
            mniElimina = new ToolStripMenuItem();
            BtnInserisci = new Button();
            label2 = new Label();
            TxtNomeProgetto = new TextBox();
            BtnChiudi = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dtpTermine = new DateTimePicker();
            label6 = new Label();
            BtnAnnulla = new Button();
            BtnSalva = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatiProgetti).BeginInit();
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
            label1.Size = new Size(1114, 22);
            label1.TabIndex = 4;
            label1.Text = "Formica - Gestione dei progetti";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgDatiProgetti
            // 
            dtgDatiProgetti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiProgetti.Dock = DockStyle.Top;
            dtgDatiProgetti.Location = new Point(0, 22);
            dtgDatiProgetti.Name = "dtgDatiProgetti";
            dtgDatiProgetti.Size = new Size(1114, 435);
            dtgDatiProgetti.TabIndex = 1;
            dtgDatiProgetti.CellMouseDown += dtgDatiProgetti_CellMouseDown;
            // 
            // CmsMenu
            // 
            CmsMenu.Items.AddRange(new ToolStripItem[] { mniModifica, mniElimina });
            CmsMenu.Name = "contextMenuStrip1";
            CmsMenu.Size = new Size(122, 48);
            // 
            // mniModifica
            // 
            mniModifica.Name = "mniModifica";
            mniModifica.Size = new Size(121, 22);
            mniModifica.Text = "Modifica";
            mniModifica.Click += mniModifica_Click;
            // 
            // mniElimina
            // 
            mniElimina.Name = "mniElimina";
            mniElimina.Size = new Size(121, 22);
            mniElimina.Text = "Elimina";
            mniElimina.Click += mniElimina_Click;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnInserisci.Location = new Point(12, 591);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 7;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            BtnInserisci.Click += BtnInserisci_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 482);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome Progetto:";
            // 
            // TxtNomeProgetto
            // 
            TxtNomeProgetto.Location = new Point(12, 500);
            TxtNomeProgetto.MaxLength = 200;
            TxtNomeProgetto.Name = "TxtNomeProgetto";
            TxtNomeProgetto.Size = new Size(424, 23);
            TxtNomeProgetto.TabIndex = 2;
            TxtNomeProgetto.Enter += txt_Enter;
            TxtNomeProgetto.Leave += txt_Leave;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1029, 591);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(73, 23);
            BtnChiudi.TabIndex = 10;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.TextAlign = ContentAlignment.MiddleRight;
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(676, 481);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Note:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(676, 499);
            textBox1.MaxLength = 2000;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 69);
            textBox1.TabIndex = 6;
            textBox1.Enter += txt_Enter;
            textBox1.Leave += txt_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 545);
            textBox2.MaxLength = 200;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 23);
            textBox2.TabIndex = 3;
            textBox2.Enter += txt_Enter;
            textBox2.Leave += txt_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 527);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 12;
            label4.Text = "Descrizione:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 480);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 14;
            label5.Text = "Apertura:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(453, 500);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dtpTermine
            // 
            dtpTermine.Format = DateTimePickerFormat.Short;
            dtpTermine.Location = new Point(453, 545);
            dtpTermine.Name = "dtpTermine";
            dtpTermine.Size = new Size(200, 23);
            dtpTermine.TabIndex = 5;
            dtpTermine.Value = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 525);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 16;
            label6.Text = "Termine:";
            // 
            // BtnAnnulla
            // 
            BtnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAnnulla.Enabled = false;
            BtnAnnulla.Location = new Point(107, 591);
            BtnAnnulla.Name = "BtnAnnulla";
            BtnAnnulla.Size = new Size(75, 23);
            BtnAnnulla.TabIndex = 8;
            BtnAnnulla.Text = "Annulla";
            BtnAnnulla.UseVisualStyleBackColor = true;
            BtnAnnulla.Visible = false;
            // 
            // BtnSalva
            // 
            BtnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalva.Location = new Point(197, 591);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 9;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Visible = false;
            // 
            // FrmGestioneProgetti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 626);
            Controls.Add(BtnSalva);
            Controls.Add(BtnAnnulla);
            Controls.Add(dtpTermine);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(BtnChiudi);
            Controls.Add(TxtNomeProgetto);
            Controls.Add(label2);
            Controls.Add(BtnInserisci);
            Controls.Add(dtgDatiProgetti);
            Controls.Add(label1);
            Name = "FrmGestioneProgetti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione Progetti";
            Load += FrmGestioneProgetti_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatiProgetti).EndInit();
            CmsMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgDatiProgetti;
        private Button BtnInserisci;
        private Label label2;
        private TextBox TxtNomeProgetto;
        private Button BtnChiudi;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpTermine;
        private Label label6;
        private Button BtnAnnulla;
        private Button BtnSalva;
        private ContextMenuStrip CmsMenu;
        private ToolStripMenuItem mniModifica;
        private ToolStripMenuItem mniElimina;
    }
}