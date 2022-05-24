using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XamarinBindingPages.ViewModels
{
    public class TiempoBindingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            //SI EL EVENTO ES DIFERENTE DE NULL
            if (PropertyChanged != null)
            {
                //REINICIE DE NUEVO LOS BINGING PARA VISUALIZAR
                //LOS CAMBIOS
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //LAS PROPIEDADES A ENLAZAR DENTRO DEL CODIGO XAML
        //PROPIEDADES QUE NO DESEAMOS QUE CAMBIEN
        public string Anyo { get; set; }
        public string Mes { get; set; }
        public string Dia { get; set; }

        //LAS PROPIEDADES QUE DESEAMOS QUE CAMBIEN EN EL ENLACE DEBEN
        //SER EXTENDIDAS
        private string _Hora;
        public string Hora
        {
            get { return this._Hora; }
            set {
                this._Hora = value;
                //LANZAMOS EL EVENTO DE CAMBIO DE PROPIEDAD
                RaisePropertyChanged("Hora");
            }
        }

        //PONGAMOS QUE TENEMOS UNA PROPIEDAD MAS COMPLEJA (OBJETO)
        private DateTime _Tiempo;
        public DateTime Tiempo
        {
            get { return this._Tiempo; }
            set {
                this._Tiempo = value;
                RaisePropertyChanged("Tiempo");
            }
        }

        //EN EL CONSTRUCTOR INICIAMOS LOS OBJETOS TIME
        public TiempoBindingViewModel()
        {
            this.Anyo = "Anyo: " + DateTime.Now.Year;
            this.Mes = "Mes: " + DateTime.Now.ToString("MMMM");
            this.Dia = "Dia: " + DateTime.Now.DayOfWeek;
            this.Hora = "Hora: " + DateTime.Now.ToLongTimeString();
            this.Tiempo = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Tiempo = DateTime.Now;
                this.Hora = DateTime.Now.ToLongTimeString();
                return true;
            });
        }
    }
}
