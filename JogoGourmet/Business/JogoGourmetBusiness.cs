using JogoGourmet.Business.Commons;
using JogoGourmet.Models;
using JogoGourmet.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JogoGourmet.Business
{
    #region Codigo feito com Entidade

    public class JogoGourmetBusiness
    {
        private List<Pratos> _pratosPensados { get; set; }
        private TextMessages _textMessages { get; set; }
        private frmQualPrato _frmQualPrato { get; set; }
        private frmOPratoEh _frmOPratoEh { get; set; }

        public JogoGourmetBusiness()
        {
            _pratosPensados = new List<Pratos>();
            _pratosPensados.Add(new Pratos() { Tipo = "massa", Prato = new List<string>() { "Lasanha" } });
            _pratosPensados.Add(new Pratos() { Tipo = "bolo", Prato = new List<string>() { "Bolo de Chocolate" } });
                        
            _textMessages = new TextMessages();
        }

        public void ExibePopUp()
        {
            var quantidadeDePratos = _pratosPensados.Count;
            var numeroPratoAtual = 1;
            var ultimoPrato = string.Empty;

            foreach (var pratos in _pratosPensados)
            {
                if (_textMessages.QuestionMessage(pratos.Tipo).Equals(DialogResult.Yes))
                {
                    foreach (var prato in pratos.Prato)
                    {
                        ultimoPrato = prato;
                        if (_textMessages.QuestionMessage(prato).Equals(DialogResult.Yes))
                        {
                            _textMessages.InformationMessage();
                            return;
                        }
                        else
                            numeroPratoAtual = quantidadeDePratos;
                    }
                }

                if (numeroPratoAtual.Equals(quantidadeDePratos))
                {
                    PerguntarPratoPensado(ultimoPrato != string.Empty ? ultimoPrato :
                                          _pratosPensados.FirstOrDefault(p => p.Tipo == pratos.Tipo).Prato.LastOrDefault());
                    break;
                }

                numeroPratoAtual++;
            }
        }

        private void PerguntarPratoPensado(string ultimoPrato)
        {
            _frmQualPrato = new frmQualPrato();
            _frmQualPrato.ShowDialog();

            if (_frmQualPrato.PratoPensado.Equals(string.Empty))
                return;

            _frmOPratoEh = new frmOPratoEh(_frmQualPrato.PratoPensado, ultimoPrato);
            _frmOPratoEh.ShowDialog();

            if (!_frmOPratoEh.AdjetivoPensado.Equals(string.Empty))
                AdicionarNovoPratoPensado(_frmOPratoEh.AdjetivoPensado, _frmQualPrato.PratoPensado);
        }

        private void AdicionarNovoPratoPensado(string novoTipo, string novoPrato)
        {
            var prato = new Pratos() { Tipo = novoTipo, Prato = new List<string>() { novoPrato } };
            var indice = _pratosPensados.FindIndex(p => p.Tipo.Equals(prato.Tipo));

            if (indice > -1)
                _pratosPensados[indice].Prato.Add(novoPrato);
            else
                _pratosPensados.Add(prato);
        }
    }

    #endregion
}
