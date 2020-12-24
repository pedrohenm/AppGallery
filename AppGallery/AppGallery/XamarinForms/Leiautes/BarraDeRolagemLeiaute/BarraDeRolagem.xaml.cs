using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Leiautes.BarraDeRolagemLeiaute
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        private void RolarParaSegunaLabel(object sender, EventArgs e)
        {
            BarraRolagem.ScrollToAsync(SegundaLabel, ScrollToPosition.Start, true);
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Posicao.Text = e.ScrollX + " - " + e.ScrollY;
        }
    }
}