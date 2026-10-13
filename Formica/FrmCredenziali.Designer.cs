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
            BtnChiudi = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.Chiudi_uxwing;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(1220, 601);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 9;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.TextAlign = ContentAlignment.MiddleRight;
            BtnChiudi.UseVisualStyleBackColor = true;
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
            label2.AutoSize = true;
            label2.Location = new Point(19, 400);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 11;
            label2.Text = "Titolo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 415);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(516, 128);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 400);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Note:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 460);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(371, 23);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 445);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 15;
            label4.Text = "Username:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 506);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(371, 23);
            textBox4.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 491);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 17;
            label5.Text = "Email:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(21, 548);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(371, 23);
            textBox5.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 533);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 19;
            label6.Text = "Password:";
            // 
            // FrmCredenziali
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 636);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnChiudi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCredenziali";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione Credenziali";
            Load += FrmCredenziali_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnChiudi;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
    }
}