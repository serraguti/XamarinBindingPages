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
    public partial class MenuPrincipalView : MasterDetailPage
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
            //NECESITAMOS UNA COLECCION DE MENUITEM 
            //PARA ASOCIARLA AL LISTVIEW DEL MENU
            List<MenuElement> menuElements = new List<MenuElement>
            {
                new MenuElement()
                {
                    Titulo = "Tabla Multiplicar",
                    Imagen = "arriba.png",
                    Pagina = typeof(TablaMultiplicarView)
                },
                new MenuElement()
                {
                    Titulo = "Canciones",
                    Imagen = "abajo.png",
                    Pagina = typeof(CancionesView)
                },
                new MenuElement()
                {
                    Titulo = "Numeros Colores",
                    Imagen = "arriba.png",
                    Pagina = typeof(NumerosColoresView)
                },
                new MenuElement()
                {
                    Titulo = "Hora",
                    Imagen = "abajo.png",
                    Pagina = typeof(TiempoBindingView)
                },
                new MenuElement()
                {
                    Titulo = "Binding Objects",
                    Imagen = "abajo.png",
                    Pagina = typeof(BindingObjectsView)
                }
            };
            this.listViewMenu.ItemsSource = menuElements;
            //UNA PAGINA MASTERDETAIL SIEMPRE DEBE TENER UNA 
            //PAGINA A MOSTRAR EN SU ZONA <Detail>
            this.Detail =
                new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
            this.listViewMenu.ItemSelected += CambiarPaginaMenu;
        }

        private void CambiarPaginaMenu(object sender, SelectedItemChangedEventArgs e)
        {
            //DENTRO DE e VIENE EL ELEMENTO SELECCIONADO
            //Y LO QUE TRAE ES EL ELEMENTO DEL BINDING
            MenuElement pageSelected = (MenuElement)e.SelectedItem;
            Type pageType = pageSelected.Pagina;
            //INDICAMOS EN DETAIL LA NUEVA PAGINA A MOSTRAR
            this.Detail =
                new NavigationPage((Page)Activator.CreateInstance(pageType));
            //COMO EFECTO OPTION, QUITAMOS EL MENU AL SELECCIONAR
            //UNA PAGINA
            this.IsPresented = false;
        }
    }
}