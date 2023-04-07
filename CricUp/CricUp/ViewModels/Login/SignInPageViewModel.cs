using CricUp.ViewModels.Base;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CricUp.ViewModels.Login
{
    public class SignInPageViewModel : BaseViewModel
    {
        public Command LoginSuccessfullCommand { get; set; }
        public SignInPageViewModel()
        {
            LoginSuccessfullCommand = new Command(async () => await GoToHomePage());
        }

        private async Task GoToHomePage()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new MainPage(), false);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
