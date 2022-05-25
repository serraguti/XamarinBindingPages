using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinBindingPages.ViewModels
{
    public class NumerosColoresViewModel : INotifyPropertyChanged
    {
        public NumerosColoresViewModel()
        {
            Random random = new Random();
            List<int> temporal = new List<int>();
            for (int i =1; i <= 50; i++)
            {
                temporal.Add(random.Next(-50, 50)); 
            }
            this.Numeros = temporal;
        }

        private List<int> _Numeros;

        public List<int> Numeros
        {
            get { return this._Numeros; }
            set {
                this._Numeros = value;
                RaisePropertyChanged("Numeros");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this
                , new PropertyChangedEventArgs(propertyName));
        }
    }
}
