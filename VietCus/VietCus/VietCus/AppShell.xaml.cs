using System;
using System.Collections.Generic;
using VietCus.ViewModels;
using VietCus.Views;
using Xamarin.Forms;

namespace VietCus
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
