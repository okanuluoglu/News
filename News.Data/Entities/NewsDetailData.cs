using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public record NewsDetailData
    {

        [JsonProperty("headerAd")]
        public HeaderAd HeaderAd { get; set; }

        [JsonProperty("newsDetail")]
        public NewsDetail NewsDetail { get; set; }

        [JsonProperty("footerAd")]
        public FooterAd FooterAd { get; set; }

        [JsonProperty("multimedia")]
        public Multimedia Multimedia { get; set; }

        [JsonProperty("itemList")]
        public List<ItemList> ItemList { get; set; }

        [JsonProperty("relatedNews")]
        public RelatedNews RelatedNews { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("photoGallery")]
        public PhotoGallery PhotoGallery { get; set; }
    }
}
