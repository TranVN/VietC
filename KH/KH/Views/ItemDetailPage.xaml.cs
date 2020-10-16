using System.ComponentModel;
using Xamarin.Forms;
using KH.ViewModels;

namespace KH.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}