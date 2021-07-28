using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Notepad_WPF.Models
{
    public class FormatModel : ObservableObject
    {

        private FontStyle _style;

        public FontStyle Style
        {
            get { return _style; }
            set { _style = value; OnPropertyChanged(); }
        }

        private FontWeight _weight;

        public FontWeight Weight
        {
            get { return _weight; }
            set { _weight = value; OnPropertyChanged(); }
        }

        private FontFamily _family;

        public FontFamily Family
        {
            get { return _family; }
            set { _family = value; OnPropertyChanged(); }
        }

        private TextWrapping _wrap;

        public TextWrapping Wrap
        {
            get { return _wrap; }
            set { _wrap = value; OnPropertyChanged(); IsWrapped = value == TextWrapping.Wrap; }
        }

        private bool _isWrapped;

        public bool IsWrapped
        {
            get { return _isWrapped; }
            set { _isWrapped = value; OnPropertyChanged(); }
        }


        private double _size;

        public double Size
        {
            get { return _size; }
            set { _size = value; OnPropertyChanged(); }
        }



    }
}
