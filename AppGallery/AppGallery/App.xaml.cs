﻿using Xamarin.Forms;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(
            //        new Conteudo01()
            //    );

            //var pagina = new CarouselPage();
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());

            //pagina.CurrentPage = pagina.Children[1];

            //var pagina = new MasterDetailPage();
            ////Menu
            //pagina.Master = ;
            ////Conteudo  
            //pagina.Detail = ;

            MainPage = new AppBase.Menu();
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
