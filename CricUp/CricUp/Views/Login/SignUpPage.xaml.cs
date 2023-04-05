﻿using CricUp.ViewModels.Login;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CricUp.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            this.BindingContext = new SignUpPageViewModel();
        }
    }
}