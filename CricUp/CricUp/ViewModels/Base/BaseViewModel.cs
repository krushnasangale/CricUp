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



        public BaseViewModel()
        {

        }
    }
}
