using CricUp.ViewModels.Base;
using CricUp.Views.Login;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CricUp.ViewModels.Login
{
    public class SignUpPageViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public Command CreateNewAccount { get; set; }
        public Command NavigateToLoginPage { get; set; }

        public SignUpPageViewModel()
        {
            NavigateToLoginPage = new Command(async () => await GoToLoginPage());
            CreateNewAccount = new Command(CreateNewUser);
        }

        private async Task GoToLoginPage()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new SignInPage(), false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateNewUser(object obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
