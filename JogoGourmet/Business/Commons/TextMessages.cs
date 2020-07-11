using System.Windows.Forms;

namespace JogoGourmet.Business.Commons
{
    public sealed class TextMessages
    {        
        public TextMessages()
        {

        }

        public DialogResult InformationMessage()
        {
            return MessageBox.Show("Acertei de novo!", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult QuestionMessage(string message)
        {
            return MessageBox.Show($"O prato que você pensou é {message}?", "Jogo Gourmet", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public DialogResult WarningMessage(string message)
        {
            return MessageBox.Show(message, "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public DialogResult ErrorMessage(string message)
        {
            return MessageBox.Show(message, "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
