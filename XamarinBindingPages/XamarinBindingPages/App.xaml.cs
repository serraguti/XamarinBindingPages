using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBindingPages.Views;

namespace XamarinBindingPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CelsiusFarenhaitView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
