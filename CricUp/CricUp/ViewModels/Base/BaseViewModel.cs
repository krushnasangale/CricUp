using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CricUp.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public const string RapidAPIKey = "2ec884daa0msha54b4e03640d382p1966f1jsnef3ccd9e1746";
        public const string RapidAPIHost = "cricbuzz-cricket.p.rapidapi.com";
        public const string APIHostUrl = "https://cricbuzz-cricket.p.rapidapi.com";

        public BaseViewModel()
        {

        }
    }
}
