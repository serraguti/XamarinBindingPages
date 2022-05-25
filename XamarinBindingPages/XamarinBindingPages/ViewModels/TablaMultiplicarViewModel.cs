using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinBindingPages.Models;

namespace XamarinBindingPages.ViewModels
{
    public class TablaMultiplicarViewModel : INotifyPropertyChanged
    {
        private int _Numero;

        public int Numero
        {
            get { return this._Numero; }
            set {
                this._Numero = value;
                RaisePropertyChanged("Numero");
            }
        }

        private List<Tabla> _TablaMultiplicar;

        public List<Tabla> TablaMultiplicar
        {
            get { return this._TablaMultiplicar; }
            set {
                this._TablaMultiplicar = value;
                RaisePropertyChanged("TablaMultiplicar");
            }
        }

        public Command MostrarTablaMultiplicar
        {
            get
            {
                return new Command(() =>
                {
                    //PARA QUE LAS VISTAS ACTUALICEN SUS DIBUJOS
                    //ES NECESARIO CAMBIAR LAS PROPIEDADES ENLAZADAS
                    //this.Numero = ???
                    //this.TablaMultiplicar = ???
                    List<Tabla> temporal = new List<Tabla>();
                    for (int i = 1; i <= 10; i++)
                    {
                        Tabla tabla = new Tabla();
                        tabla.Operacion = this.Numero + " * " + i;
                        tabla.Resultado = this.Numero * i;
                        temporal.Add(tabla);
                    }
                    //CAMBIAMOS LA PROPIEDAD PARA LA VISTA
                    this.TablaMultiplicar = temporal;
                });
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
