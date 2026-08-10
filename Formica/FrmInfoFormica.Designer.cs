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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnChiudi = new Button();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // pctLogo
            // 
            pctLogo.Image = Properties.Resources.formica;
            pctLogo.Location = new Point(2, 44);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(339, 402);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
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
            // FrmInfoFormica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 608);
            Controls.Add(BtnChiudi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnChiudi;
    }
}