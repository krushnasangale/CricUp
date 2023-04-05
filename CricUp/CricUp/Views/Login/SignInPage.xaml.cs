using CricUp.ViewModels.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CricUp.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            this.BindingContext = new SignInPageViewModel();
        }
    }
}