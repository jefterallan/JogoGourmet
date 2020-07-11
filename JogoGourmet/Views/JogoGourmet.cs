using JogoGourmet.Business;
using System;
using System.Windows.Forms;

namespace JogoGourmet.Views
{
    public partial class frmJogoGourmet : Form
    {
        private JogoGourmetBusiness _jogoGourmetBusiness;

        public frmJogoGourmet()
        {
            InitializeComponent();
            _jogoGourmetBusiness = new JogoGourmetBusiness();
        }

        private void btnOkInit_Click(object sender, EventArgs e)
        {
            _jogoGourmetBusiness.ExibePopUp();
        }
    }
}
