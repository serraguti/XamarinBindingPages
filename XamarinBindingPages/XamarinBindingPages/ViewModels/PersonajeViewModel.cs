using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinBindingPages.Models;

namespace XamarinBindingPages.ViewModels
{
    public class PersonajeViewModel : INotifyPropertyChanged
    {
        public PersonajeViewModel()
        {
            Personaje personaje = new Personaje();
            personaje.Nombre = "Steve Harrington";
            personaje.Serie = "Stranger Things";
            personaje.Imagen = "https://i.pinimg.com/736x/cd/08/7e/cd087ef80bd96e63910f02b7c2d222da.jpg";
            this.Personaje = personaje;
        }

        private string _Nombre;
        public string Nombre
        {
            get { return this._Nombre; }
            set
            {
                this._Nombre = value;
                RaisePropertyChanged("Nombre");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this
                , new PropertyChangedEventArgs(propertyName));
        }

        private Personaje _Personaje;
        public Personaje Personaje
        {
            get { return this._Personaje; }
            set {
                this._Personaje = value;
                RaisePropertyChanged("Personaje");
            }
        }

        //PARA CAPTURAR ACCIONES (BUTTON) NECESITAMOS
        //PROPIEDADES DE TIPO COMMAND.
        //UNICAMENTE SE NECESITA UNA PROPIEDAD get { }
        public Command NewPersonaje
        {
            get {
                return new Command(() =>
                {
                    Personaje personaje = new Personaje();
                    personaje.Nombre = this.Nombre;
                    personaje.Serie = "Stranger Things";
                    personaje.Imagen = "https://i.pinimg.com/236x/cf/76/9e/cf769e18285f2706b457a4dd845db707.jpg";
                    this.Personaje = personaje;
                });
            }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return this._Descripcion; }
            set {
                this._Descripcion = value;
                RaisePropertyChanged("Descripcion");
            }
        }

        public Command MostrarDescripcion
        {
            get
            {
               return new Command(() =>
               {
                   this.Descripcion = this.Personaje.Nombre + ", "
                   + this.Personaje.Serie;
                   RaisePropertyChanged("Personaje");
               });
            }
        }
    }
}
