namespace Formica
{
    partial class FrmAgenda
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
            BtnChiudi = new Button();
            label1 = new Label();
            dtgDatiAgenda = new DataGridView();
            Giorno = new Label();
            label3 = new Label();
            dtpData = new DateTimePicker();
            TxtNote = new TextBox();
            BtnInserisci = new Button();
            BtnSalva = new Button();
            BtnAnnulla = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatiAgenda).BeginInit();
            SuspendLayout();
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(739, 594);
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
            label1.Size = new Size(826, 22);
            label1.TabIndex = 6;
            label1.Text = "Formica - Gestione Agenda";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgDatiAgenda
            // 
            dtgDatiAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiAgenda.Dock = DockStyle.Top;
            dtgDatiAgenda.Location = new Point(0, 22);
            dtgDatiAgenda.Name = "dtgDatiAgenda";
            dtgDatiAgenda.Size = new Size(826, 341);
            dtgDatiAgenda.TabIndex = 7;
            // 
            // Giorno
            // 
            Giorno.AutoSize = true;
            Giorno.Location = new Point(14, 380);
            Giorno.Name = "Giorno";
            Giorno.Size = new Size(34, 15);
            Giorno.TabIndex = 8;
            Giorno.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 382);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Note:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(18, 400);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(362, 23);
            dtpData.TabIndex = 10;
            // 
            // TxtNote
            // 
            TxtNote.Location = new Point(401, 400);
            TxtNote.MaxLength = 2000;
            TxtNote.Multiline = true;
            TxtNote.Name = "TxtNote";
            TxtNote.Size = new Size(413, 108);
            TxtNote.TabIndex = 11;
            TxtNote.Enter += txt_Enter;
            TxtNote.Leave += txt_Leave;
            // 
            // BtnInserisci
            // 
            BtnInserisci.Location = new Point(38, 591);
            BtnInserisci.Name = "BtnInserisci";
            BtnInserisci.Size = new Size(75, 23);
            BtnInserisci.TabIndex = 12;
            BtnInserisci.Text = "Nuovo";
            BtnInserisci.UseVisualStyleBackColor = true;
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(129, 593);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 13;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Visible = false;
            // 
            // BtnAnnulla
            // 
            BtnAnnulla.Location = new Point(228, 591);
            BtnAnnulla.Name = "BtnAnnulla";
            BtnAnnulla.Size = new Size(75, 23);
            BtnAnnulla.TabIndex = 14;
            BtnAnnulla.Text = "Annulla";
            BtnAnnulla.UseVisualStyleBackColor = true;
            BtnAnnulla.Visible = false;
            BtnAnnulla.Click += BtnAnnulla_Click;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 629);
            Controls.Add(BtnAnnulla);
            Controls.Add(BtnSalva);
            Controls.Add(BtnInserisci);
            Controls.Add(TxtNote);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(Giorno);
            Controls.Add(dtgDatiAgenda);
            Controls.Add(label1);
            Controls.Add(BtnChiudi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione Agenda";
            ((System.ComponentModel.ISupportInitialize)dtgDatiAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnChiudi;
        private Label label1;
        private DataGridView dtgDatiAgenda;
        private Label Giorno;
        private Label label3;
        private DateTimePicker dtpData;
        private TextBox TxtNote;
        private Button BtnInserisci;
        private Button BtnSalva;
        private Button BtnAnnulla;
    }
}