using Microsoft.Win32;
using Notepad_WPF.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad_WPF.ViewModels
{
    class FileViewModel
    {

        public DocumentModel Document { get; private set; }

        public ICommand NewCommand { get; set; }

        public ICommand SaveCommand { get; set; }

        public ICommand SaveAsCommand { get; set; }

        public ICommand OpenCommand { get; set; }

        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);
        }

        public void NewFile(object parameter)
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            Document.Text = string.Empty;

        }

        private void SaveFile(object parameter)
        {
            if (Document.FilePath == string.Empty)
            {
                SaveFileAs(parameter);
            }
            else
            {
                File.WriteAllText(Document.FilePath, Document.Text);
            }
        }

        private void SaveFileAs(object parameter)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text File (*.txt) | *.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
            }

        }

        private void OpenFile(object parameter)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text File (*.txt) | *.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DockFile(FileDialog dialog)
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }


    }
}
