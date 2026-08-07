namespace Formica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloFinestra;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
