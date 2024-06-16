using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public record Data
    {
        [JsonProperty("sectionType")]
        public string SectionType { get; set; }

        [JsonProperty("repeatType")]
        public string RepeatType { get; set; }

        [JsonProperty("itemCountInRow")]
        public int ItemCountInRow { get; set; }

        [JsonProperty("lazyLoadingEnabled")]
        public bool LazyLoadingEnabled { get; set; }

        [JsonProperty("titleVisible")]
        public bool TitleVisible { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("titleColor")]
        public object TitleColor { get; set; }

        [JsonProperty("titleBgColor")]
        public string TitleBgColor { get; set; }

        [JsonProperty("sectionBgColor")]
        public string SectionBgColor { get; set; }

        [JsonProperty("itemList")]
        public List<NewsItem> NewsItemList { get; set; } = new();

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }
    }
}
