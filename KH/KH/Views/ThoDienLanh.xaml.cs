﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThoDienLanh : ContentPage
    {
        public ThoDienLanh()
        {
            InitializeComponent();
            Title = "Thợ Điện Lạnh";
        }
    }
}