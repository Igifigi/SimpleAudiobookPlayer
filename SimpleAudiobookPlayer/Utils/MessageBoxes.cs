using System.Windows.Forms;

namespace SimpleAudiobookPlayer.Utils
{
    internal class MessageBoxes
    {
        public static void ShowErrorBox(string message)
        {
            MessageBox.Show($"Wytstąpił błąd: {message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfoBox(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowQuestionBox(string message)
        {
            return MessageBox.Show(message, "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
