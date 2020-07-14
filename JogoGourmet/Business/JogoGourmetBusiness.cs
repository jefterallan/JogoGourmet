using JogoGourmet.Business.Commons;
using JogoGourmet.Models;
using JogoGourmet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JogoGourmet.Business
{
    #region Codigo feito com Entidade

    public class JogoGourmetBusiness
    {
        private frmQualPrato _frmQualPrato { get; set; }
        private frmOPratoEh _frmOPratoEh { get; set; }

        private TextMessages _textMessages { get; set; }

        private List<Pratos> _pratosPrincipais { get; set; }
        private List<Pratos> _pratosPensados { get; set; }

        private int _numeroPratoAtual { get; set; }
        private int _quantidadeDePratos { get; set; }
        private int _qtdPratosPenDerivados { get; set; }

        private bool _ehDerivado { get; set; } = false;
        private bool _ehFimDeJogo { get; set; } = false;

        private string _ultimoPrato { get; set; } = string.Empty;

        public JogoGourmetBusiness()
        {
            _textMessages = new TextMessages();
            _pratosPrincipais = new List<Pratos>();
            _pratosPensados = new List<Pratos>();
            _pratosPrincipais.Add(new Pratos() { Tipo = "massa", Prato = new List<string>() { "Lasanha" }, EhDerivado = true });
            _pratosPrincipais.Add(new Pratos() { Tipo = "Bolo de Chocolate", EhDerivado = false });
        }

        public void ExibePopUp()
        {
            _quantidadeDePratos = _pratosPrincipais.Count + _pratosPensados.Count;
            _ehDerivado = false;
            _ehFimDeJogo = false;
            _numeroPratoAtual = _pratosPensados.Count > 0 ? 1 : 0;

            foreach (var pratos in _pratosPrincipais)
            {
                if (!_ehFimDeJogo)
                {
                    TratarPerguntas(pratos);
                    _numeroPratoAtual++;
                }
            }
        }

        private void TratarPerguntas(Pratos pratos)
        {
            if (pratos.Prato == null)
            {
                _numeroPratoAtual++;

                if (_numeroPratoAtual < _quantidadeDePratos)
                    _numeroPratoAtual = _quantidadeDePratos;

                if (_ehDerivado.Equals(pratos.EhDerivado) && _numeroPratoAtual.Equals(_quantidadeDePratos))
                {
                    if (_textMessages.QuestionMessage(pratos.Tipo).Equals(DialogResult.Yes))
                    {
                        _textMessages.InformationMessage();
                        _ehFimDeJogo = true;
                        return;
                    }

                    if (_numeroPratoAtual.Equals(_quantidadeDePratos) && !_ehFimDeJogo)
                        PerguntarPratoPensado(pratos.Tipo);

                    return;
                }

                if (!_ehFimDeJogo)
                    PerguntarPratoPensado(_ultimoPrato);

                return;
            }

            if (_textMessages.QuestionMessage(pratos.Tipo).Equals(DialogResult.Yes))
            {
                _ehDerivado = true;
                _qtdPratosPenDerivados = _pratosPensados.Where(p => p.EhDerivado.Equals(true)).Sum(p => p.Prato.Count);

                if (_pratosPensados.Any())
                    Perguntar(_pratosPensados);

                if (!_ehFimDeJogo)
                    Perguntar(pratos);
            }
            else
            {
                _qtdPratosPenDerivados = _pratosPensados.Where(p => p.EhDerivado.Equals(false)).Sum(p => p.Prato.Count);
                if (_pratosPensados.Any())
                    Perguntar(_pratosPensados);

                return;
            }

            if (_numeroPratoAtual.Equals(_quantidadeDePratos) && !_ehFimDeJogo)
            {
                PerguntarPratoPensado(_ultimoPrato != string.Empty ? _ultimoPrato :
                                      _pratosPrincipais.LastOrDefault(p => p.Tipo == pratos.Tipo).Tipo);
            }
        }

        private void Perguntar(Pratos pratos)
        {
            var pratoDerivado = _ehDerivado ? 0 : 1;

            foreach (var prato in pratos.Prato)
            {
                _numeroPratoAtual++;
                _ultimoPrato = prato;

                if (_ehDerivado.Equals(pratos.EhDerivado))
                {
                    pratoDerivado++;
                    if (_textMessages.QuestionMessage(prato).Equals(DialogResult.Yes))
                    {
                        _textMessages.InformationMessage();
                        _ehFimDeJogo = true;
                        return;
                    }
                    else
                    {
                        if (pratoDerivado >= _qtdPratosPenDerivados && !_ehDerivado)
                            _qtdPratosPenDerivados++;

                        if (pratoDerivado.Equals(_qtdPratosPenDerivados) && !_ehFimDeJogo)
                        {
                            PerguntarPratoPensado(_ultimoPrato);
                            _ehFimDeJogo = true;
                            return;
                        }
                    }
                }
                else
                    break;
            }
        }

        private void Perguntar(List<Pratos> pratosPensados)
        {
            try
            {
                foreach (var pratos in pratosPensados)
                {
                    if (_ehDerivado.Equals(pratos.EhDerivado) && !_ehFimDeJogo)
                    {
                        if (_textMessages.QuestionMessage(pratos.Tipo).Equals(DialogResult.Yes))
                            Perguntar(pratos);
                    }
                }
            }
            catch (Exception)
            {
                _ehFimDeJogo = true;
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
            var prato = new Pratos() { Tipo = novoTipo, Prato = new List<string>() { novoPrato }, EhDerivado = _ehDerivado };
            var indice = _pratosPensados.FindIndex(p => p.Tipo.Equals(prato.Tipo));

            if (indice > -1)
            {
                _pratosPensados[indice].Prato.Add(novoPrato);
                _pratosPensados[indice].EhDerivado = _ehDerivado;
            }
            else
                _pratosPensados.Add(prato);
        }
    }

    #endregion
}
