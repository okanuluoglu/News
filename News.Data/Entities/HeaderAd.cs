using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public record HeaderAd
    {
        [JsonProperty("itemType")]
        public string ItemType { get; set; }

        [JsonProperty("adUnit")]
        public string AdUnit { get; set; }

        [JsonProperty("itemWidth")]
        public int ItemWidth { get; set; }

        [JsonProperty("itemHeight")]
        public int ItemHeight { get; set; }
    }
}
