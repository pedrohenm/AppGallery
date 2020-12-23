﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void AbrirPagina01(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo01());
            IsPresented = false;
        }

        private void AbrirPagina02(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo02());
            IsPresented = false;
        }

        private void AbrirPagina03(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo03());
            IsPresented = false;
        }
    }
}