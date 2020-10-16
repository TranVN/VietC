using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KH.Services;
using KH.Views;

namespace KH
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Expander_Experimental" });//them moi
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
