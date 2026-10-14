using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formica
{
    public partial class FrmCredenziali : Form
    {
        public FrmCredenziali()
        {
            InitializeComponent();
        }

        private void FrmCredenziali_Load(object sender, EventArgs e)
        {
            try
            {
                CaricaDati();
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }


        private void CaricaDati()
        {

            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }






        }


        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
