using CricUp.Services;
using CricUp.ViewModels.Base;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CricUp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<SeriesMatch> recentMatches { get; set; }
        public List<SeriesMatch> recentMatchesList { get; set; }
        public MainPageViewModel()
        {
            recentMatchesList = new List<SeriesMatch>();
            GetRecentMatches();
        }

        public async Task GetRecentMatches()
        {
            try
            {
                var httpClient = RestService.For<IMatchesService>(APIHostUrl);
                var resp = httpClient.GetRecentMatches(XRapidAPIKey: RapidAPIKey, XRapidAPIHost: RapidAPIHost);
                var result = resp.Result.typeMatches[0].seriesMatches;
                foreach (var match in result)
                {
                    recentMatchesList.Add(match);
                }
                recentMatches = new ObservableCollection<SeriesMatch>(recentMatchesList);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
