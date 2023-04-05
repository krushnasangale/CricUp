using CricUp.Services;
using CricUp.ViewModels.Base;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CricUp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<SeriesMatch> recentMatches { get; set; }
        public List<SeriesMatch> recentMatchesList { get; set; }
        public ObservableCollection<TypeMatch> typeMatches { get; set; }
        public List<TypeMatch> typeMatchesList { get; set; }
        public MainPageViewModel()
        {
            typeMatchesList = new List<TypeMatch>();
            recentMatchesList = new List<SeriesMatch>();
            GetRecentMatches();
        }

        public async Task GetRecentMatches()
        {
            try
            {
                var httpClient = RestService.For<IMatchesService>(APIHostUrl);
                var resp = httpClient.GetRecentMatches(XRapidAPIKey: RapidAPIKey, XRapidAPIHost: RapidAPIHost);
                var recentMatchesResult = resp.Result.typeMatches[0].seriesMatches;
                var matchTypesResult = resp.Result.typeMatches.ToList();
                foreach (var match in recentMatchesResult)
                {
                    if (match.seriesAdWrapper != null)
                        recentMatchesList.Add(match);
                }
                foreach (var match in matchTypesResult)
                {
                    typeMatchesList.Add(match);
                }
                recentMatches = new ObservableCollection<SeriesMatch>(recentMatchesList);
                typeMatches = new ObservableCollection<TypeMatch>(typeMatchesList);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
