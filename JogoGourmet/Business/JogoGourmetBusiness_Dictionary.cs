using JogoGourmet.Business.Commons;
using JogoGourmet.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JogoGourmet.Business
{
    #region Codigo feito com Dictionary, para usá-lo basta descomentar esta classe e comentar a classe feita com Entidade

    /*
    public class JogoGourmetBusiness
    {
        private Dictionary<string, List<string>> _pratosPensados { get; set; }
        private TextMessages _textMessages { get; set; }
        private frmQualPrato _frmQualPrato { get; set; }
        private frmOPratoEh _frmOPratoEh { get; set; }

        public JogoGourmetBusiness()
        {
            _pratosPensados = new Dictionary<string, List<string>>() {
                {"massa", new List<string>(){ "Lasanha" } },
                {"bolo", new List<string>(){ "Bolo de Chocolate" } }
            };
            _textMessages = new TextMessages();
        }

        public void ExibePopUp()
        {
            var quantidadeDePratos = _pratosPensados.Count;
            var numeroPratoAtual = 1;
            var ultimoPrato = string.Empty;

            foreach (var pratos in _pratosPensados)
            {
                if (_textMessages.QuestionMessage(pratos.Key).Equals(DialogResult.Yes))
                {
                    foreach (var prato in pratos.Value)
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
                                          _pratosPensados.FirstOrDefault(p => p.Key == pratos.Key).Value.LastOrDefault());
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
            if (_pratosPensados.ContainsKey(novoTipo))
                _pratosPensados[novoTipo].Add(novoPrato);
            else
                _pratosPensados.Add(novoTipo, new List<string>() { novoPrato });
        }
    }
    */
    #endregion
}
