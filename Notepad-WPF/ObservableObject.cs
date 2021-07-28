using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Notepad_WPF
{
    public class ObservableObject : ObjectDataProvider
    {
        /// <summary>
        /// Simplified version
        /// </summary>
        /// <param name="name"></param>
        public virtual void OnPropertyChanged([CallerMemberName] string name = null)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(name));
        }
    }
}
