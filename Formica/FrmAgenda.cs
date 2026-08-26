using Formica.Models;
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
        AppDbContext contesto = new AppDbContext();
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

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                Agenda  agenda = new Agenda
                { 
                 Note = TxtNote.Text.Trim(),
                 DataEvento = dtpData.Value
                    
                
                
                };

                contesto.Agenda.Add(agenda);
                contesto.SaveChanges();



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
