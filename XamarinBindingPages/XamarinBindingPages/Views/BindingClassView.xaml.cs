using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBindingPages.Models;

namespace XamarinBindingPages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingClassView : ContentPage
    {
        public BindingClassView()
        {
            InitializeComponent();
            ////AQUI VAMOS A CREAR LA CLASE COMIC
            ////AUNQUE NO SE REALIZA NORMALMENTE ASI EN XAMARIN
            //Comic comic = new Comic();
            //comic.Titulo = "Spiderman Torment";
            //comic.Personaje = "Spiderman";
            //comic.Autor = "Todd McFarlane";
            //comic.Imagen = "https://townsquare.media/site/622/files/2016/04/Torment1.jpg";
            ////INDICAMOS A LA VISTA EL OBJETO QUE VA A UTILIZAR COMO 
            ////ENLACE
            //this.BindingContext = comic;
        }
    }
}