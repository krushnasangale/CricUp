using CricUp.Services;
using CricUp.ViewModels;
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
    }
}
