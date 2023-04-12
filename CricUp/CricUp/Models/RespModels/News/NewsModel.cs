using System;
using System.Collections.Generic;
using System.Text;

namespace CricUp.Models.News
{
    public class NewsModel
    {
        public List<StoryList> storyList { get; set; }
        public string lastUpdatedTime { get; set; }
        public AppIndex appIndex { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Ad
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

    public class CoverImage
    {
        public string id { get; set; }
        public string caption { get; set; }
        public string source { get; set; }
    }

    public class Story
    {
        public int id { get; set; }
        public string hline { get; set; }
        public string intro { get; set; }
        public string pubTime { get; set; }
        public string source { get; set; }
        public string storyType { get; set; }
        public int imageId { get; set; }
        public string seoHeadline { get; set; }
        public string context { get; set; }
        public CoverImage coverImage { get; set; }
    }

    public class StoryList
    {
        public Story story { get; set; }
        public Ad ad { get; set; }
    }


}
