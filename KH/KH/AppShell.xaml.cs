using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KH.ViewModels;
using KH.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace KH
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void ButtonFabcon_Clicked(object sender, System.EventArgs e)
        {
            //await ((ImageButton)sender).ScaleTo(0.8, 50, Easing.Linear);
            //await Task.Delay(100);
            await Launcher.OpenAsync(new Uri("tel:0903532938"));
            //await ((ImageButton)sender).ScaleTo(1, 50, Easing.Linear);
        }
    }
}
