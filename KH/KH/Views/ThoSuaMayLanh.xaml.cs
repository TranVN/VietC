using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThoSuaMayLanh : ContentPage
    {
        public ThoSuaMayLanh()
        {
            InitializeComponent();
            Title = "Thợ Sửa Máy Lạnh";
        }
        private async void ButtonFabcon_Clicked(object sender, System.EventArgs e)
        {
          
            await Launcher.OpenAsync(new Uri("tel:0903532938"));
          
        }
    }
}