﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo01 : ContentPage
    {
        public Conteudo01()
        {
            InitializeComponent();
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conteudo02());
        }
    }
}