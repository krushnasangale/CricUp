using CricUp.ViewModels.International;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CricUp.Views.International
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InternationalLandingPage : ContentPage
    {
        public InternationalLandingPage()
        {
            InitializeComponent();
            this.BindingContext = new InternationalLandingPageViewModel();
        }
    }
}