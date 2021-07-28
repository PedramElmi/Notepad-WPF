using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_WPF.Models
{
    public class DocumentModel : ObservableObject
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged(); }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; OnPropertyChanged(); }
        }

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; OnPropertyChanged(); }
        }

        public bool IsEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
