using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinBindingPages.Models;

namespace XamarinBindingPages.ViewModels
{
    public class CancionesViewModel : INotifyPropertyChanged
    {
        public CancionesViewModel()
        {
            this.Canciones =
                new List<Cancion>
                {
                    new Cancion()
                    {
                        Titulo = "Cuando zarpa el amor",
                        Artista = "Camela",
                        Imagen = "https://m.media-amazon.com/images/I/71eyfcDTKbL._SS500_.jpg"
                    },
                    new Cancion()
                    {
                        Titulo = "El chiqui chiqui",
                        Artista = "Rodolfo Chikilicuatre",
                        Imagen = "https://www.leonidasmartin.net/wp-content/uploads/2018/01/Rodolfo-Chikilicuatre-Baila-El-Chiki-Chiki.jpg"
                    },
                    new Cancion()
                    {
                        Titulo = "Carol",
                        Artista = "John Cobra",
                        Imagen = "https://e00-elmundo.uecdn.es/elmundo/imagenes/2010/11/05/television/1288959797_0.jpg"
                    },
                    new Cancion()
                    {
                        Titulo = "Dame veneno",
                        Artista = "Los chunguitos",
                        Imagen = "https://cps-static.rovicorp.com/3/JPG_400/MI0000/711/MI0000711921.jpg"
                    },
                    new Cancion()
                    {
                        Titulo = "El baile del Gorila",
                        Artista = "Melody",
                        Imagen = "https://images.genius.com/9c06333da8e379aa3e4592e93f857122.500x500x1.jpg"
                    }
                };
        }

        private List<Cancion> _Canciones;

        public List<Cancion> Canciones
        {
            get { return this._Canciones; }
            set {
                this._Canciones = value;
                RaisePropertyChanged("Canciones");
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
