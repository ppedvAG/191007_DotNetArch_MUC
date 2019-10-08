using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.LibertyBooks.UI.WPF.ViewModels
{
    // Weitere Alternative:  https://github.com/Fody/PropertyChanged
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        protected virtual void SetProperty<T>(ref T field, T value, [CallerMemberName]string PropertyName = null)
        {
            //if (field != value)
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(PropertyName);
            }
        }

    }
}
