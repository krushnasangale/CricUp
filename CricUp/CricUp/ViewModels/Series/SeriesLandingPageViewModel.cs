using CricUp.Services;
using CricUp.ViewModels.Base;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CricUp.ViewModels.Series
{
    public class SeriesLandingPageViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public List<SeriesMatch> seriesMatches { get; set; }
        public SeriesLandingPageViewModel()
        {
            seriesMatches = new List<SeriesMatch>();
            GetSeriesData();
        }

        public async Task GetSeriesData()
        {
            try
            {
                var selectedSeriesId = Preferences.Get("SelectedSeriesId", string.Empty);
                var httpClient = RestService.For<IMatchesService>(APIHostUrl);
                var resp = httpClient.GetRecentMatches(XRapidAPIKey: RapidAPIKey, XRapidAPIHost: RapidAPIHost);
                var recentMatchesResult = resp.Result.typeMatches[0].seriesMatches;
                recentMatchesResult.ForEach(match => seriesMatches.Add(match));
                var currentSeries = recentMatchesResult.Where(x => x.seriesAdWrapper.seriesId == Convert.ToInt32(selectedSeriesId));
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
