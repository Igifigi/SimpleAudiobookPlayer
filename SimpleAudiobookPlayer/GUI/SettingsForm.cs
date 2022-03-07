using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SimpleAudiobookPlayer.Model;

/*
 * Pełna funkcjonalność osiągnięta!
 * **/

namespace SimpleAudiobookPlayer.GUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeElements();
        }

        UserCommunication uc = new UserCommunication();
        MemoryManager mm = new MemoryManager();
        List<Book> readBooks = new List<Book>();
        string selectedPath;

        private void InitializeElements()
        {
            readBooks = mm.ReadBooksFromCache();
            clearFields();
            readBooks.ForEach(book => selectBookComboBox.Items.Add(book.Author + " \"" + book.Title + "\""));
        }

        private void clearFields()
        {
            selectBookComboBox.Items.Clear();
            selectBookComboBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
            authorTextBox.Text = string.Empty;
            pathLabel.Text = string.Empty;
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            Book toRemove = readBooks[selectBookComboBox.SelectedIndex];
            if(uc.ShowQuestionBox("Czy na pewno chesz usunąć książkę autora " + toRemove.Author + " \"" + toRemove.Title + "\"?"))
            {
                try
                {
                    readBooks.Remove(toRemove);
                    mm.WriteBooksToCache(readBooks);
                    InitializeElements();
                    uc.ShowInfoBox("Książka usunięta poprawnie!");
                }
                catch(Exception ex)
                {
                    uc.ShowErrorBox(ex.Message);
                }
            }
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    selectedPath = folderBrowserDialog.SelectedPath;
                    pathLabel.Text = selectedPath;
                }
                else
                {
                    uc.ShowErrorBox("Wprowadź poprawną ścieżkę!");
                }
            }
            catch(Exception ex)
            {
                uc.ShowErrorBox(ex.Message);
            }
        }

        private bool areBookComponentsValid()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                uc.ShowErrorBox("Wprowadź poprawny tytuł książki!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(authorTextBox.Text))
            {
                uc.ShowErrorBox("Wprowadź poprawnego autora!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(selectedPath))
            {
                uc.ShowErrorBox("Wybierz ścieżkę!");
                return false;
            }
            return true;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!areBookComponentsValid())
                    return;
                mm.ExpandBooksCache(new Book(
                    titleTextBox.Text, 
                    authorTextBox.Text, 
                    Directory.GetFiles(selectedPath, "*.mp3", SearchOption.TopDirectoryOnly).Length, 
                    selectedPath,
                    1,
                    TimeSpan.Zero,
                    Directory.GetFiles(selectedPath, "*.mp3", SearchOption.TopDirectoryOnly).ToList()));
                InitializeElements();
                uc.ShowInfoBox("Książka została dodana poprawnie!");
            }
            catch(Exception ex)
            {
                uc.ShowErrorBox(ex.Message);
            }

        }

        private void selectBookComboBox_Click(object sender, EventArgs e)
        {
            InitializeElements();
        }
    }
}
