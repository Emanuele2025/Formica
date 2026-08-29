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
            label1 = new Label();
            BtnChiudi = new Button();
            tabControl1 = new TabControl();
            tbpStato = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            BtnInserisci = new Button();
            textBox1 = new TextBox();
            lblTitolod = new Label();
            tabPage2 = new TabPage();
            dtgDatiStato = new DataGridView();
            TxtDescrizione = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tbpStato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatiStato).BeginInit();
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
            tbpStato.Controls.Add(button4);
            tbpStato.Controls.Add(button3);
            tbpStato.Controls.Add(button2);
            tbpStato.Controls.Add(BtnInserisci);
            tbpStato.Controls.Add(textBox1);
            tbpStato.Controls.Add(lblTitolod);
            tbpStato.Location = new Point(4, 24);
            tbpStato.Name = "tbpStato";
            tbpStato.Padding = new Padding(3);
            tbpStato.Size = new Size(1029, 440);
            tbpStato.TabIndex = 0;
            tbpStato.Text = "Stato";
            tbpStato.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(255, 411);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(174, 411);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(93, 411);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Location = new Point(12, 411);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 2;
            BtnInserisci.Text = "Inserisci";
            BtnInserisci.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 1;
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
            tabPage2.Size = new Size(1017, 440);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgDatiStato
            // 
            dtgDatiStato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiStato.Dock = DockStyle.Top;
            dtgDatiStato.Location = new Point(3, 3);
            dtgDatiStato.Name = "dtgDatiStato";
            dtgDatiStato.Size = new Size(1023, 289);
            dtgDatiStato.TabIndex = 6;
            // 
            // TxtDescrizione
            // 
            TxtDescrizione.Location = new Point(212, 340);
            TxtDescrizione.Multiline = true;
            TxtDescrizione.Name = "TxtDescrizione";
            TxtDescrizione.Size = new Size(641, 23);
            TxtDescrizione.TabIndex = 8;
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
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private TabControl tabControl1;
        private TabPage tbpStato;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button BtnInserisci;
        private TextBox textBox1;
        private Label lblTitolod;
        private TabPage tabPage2;
        private DataGridView dtgDatiStato;
        private TextBox TxtDescrizione;
        private Label label3;
    }
}