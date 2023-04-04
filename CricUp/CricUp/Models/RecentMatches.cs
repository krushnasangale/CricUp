using System.Collections.Generic;

namespace CricUp
{
    public class RecentMatches
    {
        public List<TypeMatch> typeMatches { get; set; }
        public Filters filters { get; set; }
        public AppIndex appIndex { get; set; }
        public string responseLastUpdated { get; set; }

    }
    public class AdDetail
    {
        public string name { get; set; }
        public string layout { get; set; }
        public int position { get; set; }
    }

    public class AppIndex
    {
        public string seoTitle { get; set; }
        public string webURL { get; set; }
    }

    public class Filters
    {
        public List<string> matchType { get; set; }
    }

    public class Inngs1
    {
        public int inningsId { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public double overs { get; set; }
        public bool? isDeclared { get; set; }
    }

    public class Inngs2
    {
        public int inningsId { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public double overs { get; set; }
        public bool isDeclared { get; set; }
        public bool isFollowOn { get; set; }
    }

    public class Match
    {
        public MatchInfo matchInfo { get; set; }
        public MatchScore matchScore { get; set; }
    }

    public class MatchInfo
    {
        public int matchId { get; set; }
        public int seriesId { get; set; }
        public string seriesName { get; set; }
        public string matchDesc { get; set; }
        public string matchFormat { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public Team1 team1 { get; set; }
        public Team2 team2 { get; set; }
        public VenueInfo venueInfo { get; set; }
        public string seriesStartDt { get; set; }
        public string seriesEndDt { get; set; }
        public bool isTimeAnnounced { get; set; }
        public string stateTitle { get; set; }
        public bool isFantasyEnabled { get; set; }
        public int? currBatTeamId { get; set; }
    }

    public class MatchScore
    {
        public Team1Score team1Score { get; set; }
        public Team2Score team2Score { get; set; }
    }

    public class SeriesAdWrapper
    {
        public int seriesId { get; set; }
        public string seriesName { get; set; }
        public List<Match> matches { get; set; }
    }

    public class SeriesMatch
    {
        public SeriesAdWrapper seriesAdWrapper { get; set; }
        public AdDetail adDetail { get; set; }
    }

    public class Team1
    {
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string teamSName { get; set; }
        public int imageId { get; set; }
    }

    public class Team1Score
    {
        public Inngs1 inngs1 { get; set; }
        public Inngs2 inngs2 { get; set; }
    }

    public class Team2
    {
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string teamSName { get; set; }
        public int imageId { get; set; }
    }

    public class Team2Score
    {
        public Inngs1 inngs1 { get; set; }
        public Inngs2 inngs2 { get; set; }
    }

    public class TypeMatch
    {
        public string matchType { get; set; }
        public List<SeriesMatch> seriesMatches { get; set; }
    }

    public class VenueInfo
    {
        public int id { get; set; }
        public string ground { get; set; }
        public string city { get; set; }
        public string timezone { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
