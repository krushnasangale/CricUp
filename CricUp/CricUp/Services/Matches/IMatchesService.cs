using Refit;
using System.Threading.Tasks;

namespace CricUp.Services
{
    public interface IMatchesService
    {
        [Get("/matches/v1/recent")]
        Task<RecentMatches> GetRecentMatches([Header("X-RapidAPI-Key")] string XRapidAPIKey, [Header("X-RapidAPI-Host")] string XRapidAPIHost);
    }
}
