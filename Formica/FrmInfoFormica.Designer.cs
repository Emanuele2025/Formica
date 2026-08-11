namespace Formica
{
    partial class FrmInfoFormica
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
            pctLogo = new PictureBox();
            label3 = new Label();
            BtnChiudi = new Button();
            label4 = new Label();
            LblDescrizione = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // pctLogo
            // 
            pctLogo.Image = Properties.Resources.formica;
            pctLogo.Location = new Point(2, 22);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(339, 402);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Highlight;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1088, 22);
            label3.TabIndex = 3;
            label3.Text = "Formica - Informazioni sul programma";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Location = new Point(989, 573);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 4;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(347, 22);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 17;
            label4.Text = "Descrizione:";
            // 
            // LblDescrizione
            // 
            LblDescrizione.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescrizione.Location = new Point(347, 39);
            LblDescrizione.Name = "LblDescrizione";
            LblDescrizione.Size = new Size(507, 65);
            LblDescrizione.TabIndex = 18;
            LblDescrizione.Text = "Programma gratuito per la gestione delle attività - Free program for managing tasks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 87);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 19;
            label1.Text = "Ideatore:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 104);
            label2.Name = "label2";
            label2.Size = new Size(519, 44);
            label2.TabIndex = 20;
            label2.Text = "Realizzato da Emanuele Mattei con amore - Made with love by Emanuele Mattei";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(348, 148);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 21;
            label5.Text = "Contatti:";
            // 
            // FrmInfoFormica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 608);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblDescrizione);
            Controls.Add(label4);
            Controls.Add(BtnChiudi);
            Controls.Add(label3);
            Controls.Add(pctLogo);
            Name = "FrmInfoFormica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazioni programma Fattura";
            Load += FrmInfoFormica_Load;
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctLogo;
        private Label label3;
        private Button BtnChiudi;
        private Label label4;
        private Label LblDescrizione;
        private Label label1;
        private Label label2;
        private Label label5;
    }
}