using CricUp.ViewModels.Series;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CricUp.Views.Series
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeriesLandingPage : ContentPage
    {
        public SeriesLandingPage()
        {
            InitializeComponent();
            this.BindingContext = new SeriesLandingPageViewModel();
        }
    }
}