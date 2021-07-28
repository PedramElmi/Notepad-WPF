using Notepad_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Notepad_WPF.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }

        public FormatModel Format { get; set; }

        public DocumentModel Document { get; set; }

        public EditorViewModel(DocumentModel documentModel)
        {
            Document = documentModel;
            Format = new FormatModel();
            Format.Size = 16;

            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);

        }
        private void OpenStyleDialog(object parameter)
        {
            var formatDialog = new FormatDialog();
            formatDialog.DataContext = this.Format;
            formatDialog.ShowDialog();
        }

        private void ToggleWrap(object parameter)
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
            {
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.Wrap = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}
