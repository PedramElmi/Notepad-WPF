using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad_WPF.ViewModels
{
    public class HelpViewModel : ObservableObject
    {

        public ICommand HelpCommand { get; }

        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(null);
        }

        private void DisplayAbout()
        {
            // we will open a dialog

        }

    }
}
