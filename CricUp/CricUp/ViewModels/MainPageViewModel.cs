using CricUp.Models.News;
using CricUp.Services;
using CricUp.Services.News;
using CricUp.ViewModels.Base;
using CricUp.Views.International;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;

namespace CricUp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {

        #region Properties
        public ObservableCollection<StoryList> newsStories { get; set; }
        public ObservableCollection<SeriesMatch> recentMatches { get; set; }
        public ObservableCollection<TypeMatch> typeMatches { get; set; }

        public List<StoryList> newsStoriesList { get; set; }
        public List<SeriesMatch> recentMatchesList { get; set; }
        public List<TypeMatch> typeMatchesList { get; set; }

        private TypeMatch _selectedMatchType;
        public TypeMatch SelectedMatchType
        {
            get => _selectedMatchType;
            set
            {
                _selectedMatchType = value;
                OnPropertyChanged();
                NavigateToSelectedMatchType();
            }
        }

        #endregion

        public MainPageViewModel()
        {
            newsStoriesList = new List<StoryList>();
            typeMatchesList = new List<TypeMatch>();
            recentMatchesList = new List<SeriesMatch>();
            GetRecentMatches();
            GetLatestNews();
        }

        private void GetLatestNews()
        {
            try
            {
                var httpClient = RestService.For<INewsService>(APIHostUrl);
                var resp = httpClient.GetRecentNews(XRapidAPIKey: RapidAPIKey, XRapidAPIHost: RapidAPIHost);
                var newsList = resp.Result.storyList;
                foreach (var item in newsList)
                {
                    if(item.story != null)
                    {
                        newsStoriesList.Add(item);
                    }
                }
                newsStories = new ObservableCollection<StoryList>(newsStoriesList);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private async void NavigateToSelectedMatchType()
        {
            try
            {
                if (SelectedMatchType != null)
                {
                    var matchType = SelectedMatchType.matchType;
                    await Application.Current.MainPage.Navigation.PushAsync(new InternationalLandingPage());
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        public void GetRecentMatches()
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
