using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace S3_Deadline.ViewModels
{
    public class ViewModelBase<T>: INotifyPropertyChanged, IViewModelBase<T> where T : class
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void Initialize()
        {
            LoadAll();
        }

        public virtual void LoadAll()
        {

        }
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
