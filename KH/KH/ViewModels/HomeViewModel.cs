using System;
using System.Collections.Generic;
using System.Text;

namespace KH.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "HomePage";
           // OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

       // public ICommand OpenWebCommand { get; }
    }
}
