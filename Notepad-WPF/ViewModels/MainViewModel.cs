using Notepad_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_WPF.ViewModels
{
    class MainViewModel
    {
        private DocumentModel _document = new DocumentModel();

        public EditorViewModel Editor { get; set; }

        public FileViewModel File { get; set; }

        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {

            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
            Help = new HelpViewModel();

        }
    }
}
