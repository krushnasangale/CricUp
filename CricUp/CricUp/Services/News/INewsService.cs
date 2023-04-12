using CricUp.Models.News;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CricUp.Services.News
{
    public interface INewsService
    {
        [Get("/news/v1/index")]
        Task<NewsModel> GetRecentNews([Header("X-RapidAPI-Key")] string XRapidAPIKey, [Header("X-RapidAPI-Host")] string XRapidAPIHost);
    }
}
