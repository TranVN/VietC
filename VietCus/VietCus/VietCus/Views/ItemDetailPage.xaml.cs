using System.ComponentModel;
using Xamarin.Forms;
using VietCus.ViewModels;

namespace VietCus.Views
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