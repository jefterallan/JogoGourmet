using System;
using System.Windows.Forms;

namespace JogoGourmet.Views
{
    public partial class frmQualPrato : Form
    {
        public string PratoPensado { get; set; } = string.Empty;

        public frmQualPrato()
        {
            InitializeComponent();
        }

        private void btnOkQualPrato_Click(object sender, EventArgs e)
        {
            PratoPensado = txtQualPrato.Text;
            Dispose();
        }

        private void btnCancelQualPrato_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
