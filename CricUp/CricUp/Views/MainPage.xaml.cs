using CricUp.Services;
using CricUp.ViewModels;
using CricUp.Views.Series;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CricUp
{
    public partial class MainPage : ContentPage
    {
        private readonly IMatchesService matchesService;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            try
            {
                var selectedItem = sender as Frame;
                if (selectedItem.ClassId != null)
                {
                    Preferences.Set("SelectedSeriesId", selectedItem.ClassId);
                    await Application.Current.MainPage.Navigation.PushAsync(new SeriesLandingPage(), false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
