using SimpleAudiobookPlayer.Logic;
using SimpleAudiobookPlayer.Model;
using SimpleAudiobookPlayer.Utils;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleAudiobookPlayer.GUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            initialize_components();
        }

        private void initialize_components()
        {
            clear_fields();
            SelectBook_ComboBox.Items.AddRange(Cache.Instance.Books.ToArray());
        }

        private void clear_fields()
        {
            SelectBook_ComboBox.Items.Clear();
            SelectBook_ComboBox.Text = string.Empty;
            Title_TextBox.Text = string.Empty;
            Author_TextBox.Text = string.Empty;
            Path_Label.Text = string.Empty;
        }

        private bool are_all_book_components_valid()
        {
            if (string.IsNullOrEmpty(Title_TextBox.Text))
            {
                MessageBoxes.ShowInfoBox("Wprowadź poprwany tytuł książki!");
                return false;
            }
            if (string.IsNullOrEmpty(Author_TextBox.Text))
            {
                MessageBoxes.ShowInfoBox("Wprowadź poprawnego autora!");
                return false;
            }
            if (string.IsNullOrEmpty(Path_Label.Text))
            {
                MessageBoxes.ShowInfoBox("Wybierz ścieżkę!");
                return false;
            }
            return true;
        }

        private void SelectPath_Button_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                    Path_Label.Text = fbd.SelectedPath;
                else
                    MessageBoxes.ShowInfoBox("Wprowadź poprawną ścieżkę!");
            }
            catch (Exception ex)
            {
                MessageBoxes.ShowErrorBox(ex.Message);
            }
        }

        private void AddBook_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!are_all_book_components_valid())
                    return;
                string[] chapters = Directory.GetFiles(Path_Label.Text, "*.mp3", SearchOption.TopDirectoryOnly);
                Array.Sort(chapters, new NaturalStringComparer());
                Book book = new Book(
                    Title_TextBox.Text,
                    Author_TextBox.Text,
                    chapters.Length,
                    Path_Label.Text,
                    0,
                    TimeSpan.Zero,
                    chapters.ToList()
                    );
                Cache.Instance.Books.Add(book);
                CacheManager.SaveCache();
                initialize_components();
                string chapter_paths = "\n";
                book.ChapterPaths.ForEach(path => chapter_paths = $"{chapter_paths}\n{path}");
                MessageBoxes.ShowInfoBox($"Pomyślnie dodano książkę {book} o {book.Chapters} rozdziałach: {chapter_paths}");
            }
            catch (Exception ex)
            {
                MessageBoxes.ShowErrorBox(ex.Message);
            }
        }

        private void DeleteBook_Button_Click(object sender, EventArgs e)
        {
            Book to_remove = (Book)SelectBook_ComboBox.SelectedItem;
            if (!MessageBoxes.ShowQuestionBox($"Czy na pewno chcesz usunąć książkę {to_remove}?"))
                return;
            try
            {
                Cache.Instance.Books.Remove(to_remove);
                CacheManager.SaveCache();
                initialize_components();
                MessageBoxes.ShowInfoBox("Książka usunięta poprwanie!");
            }
            catch (Exception ex)
            {
                MessageBoxes.ShowErrorBox(ex.Message);
            }
        }
    }
}
