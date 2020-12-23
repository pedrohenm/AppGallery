﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInserida : ContentPage
    {
        public PaginaInserida()
        {
            InitializeComponent();
        }

        private void AbrirPaginaInicial(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(
                    new Conteudo01()
                ); ;
        }
    }
}