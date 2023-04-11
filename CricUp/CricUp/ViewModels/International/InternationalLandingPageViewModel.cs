using CricUp.Services;
using CricUp.ViewModels.Base;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricUp.ViewModels.International
{
    public class InternationalLandingPageViewModel : BaseViewModel
    {
        public ObservableCollection<SeriesMatch> SeriesMatches;
        public List<TypeMatch> typeMatchesList { get; set; }
        public InternationalLandingPageViewModel()
        {
            typeMatchesList = new List<TypeMatch>();
            GetInternationalMatches();
        }

        public void GetInternationalMatches()
        {
            try
            {
                var httpClient = RestService.For<IMatchesService>(APIHostUrl);
                var resp = httpClient.GetRecentMatches(XRapidAPIKey: RapidAPIKey, XRapidAPIHost: RapidAPIHost);
                var matchTypesResult = resp.Result.typeMatches[0].seriesMatches.ToList();
                SeriesMatches = new ObservableCollection<SeriesMatch>(matchTypesResult);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
