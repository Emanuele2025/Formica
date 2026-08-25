using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            BtnSalva.Visible = false;
            BtnAnnulla.Visible = false;
            TxtNote.Text = "";
            dtpData.Value = DateTime.Now;

        }





        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Impossibile aprire il sito: " + ex.Message);
            }
        }
    }
}
