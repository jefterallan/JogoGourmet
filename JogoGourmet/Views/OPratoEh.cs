using System;
using System.Windows.Forms;

namespace JogoGourmet.Views
{
    public partial class frmOPratoEh : Form
    {
        public string AdjetivoPensado { get; set; } = string.Empty;

        public frmOPratoEh(string pratoPensado = null, string pratoAtual = null)
        {
            InitializeComponent();
            lblOPratoEh.Text = $"{pratoPensado} é ________ , mas {pratoAtual} não.";
        }

        private void btnOkOPratoEh_Click(object sender, EventArgs e)
        {
            AdjetivoPensado = txtAdjetivo.Text;
            Dispose();
        }

        private void btnCancelOPratoEh_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
