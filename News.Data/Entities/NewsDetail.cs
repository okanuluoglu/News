using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace News.Data.Entities
{
    public record NewsDetail
    {
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("bodyText")]
        public string BodyText { get; set; }

        [JsonProperty("hasPhotoGallery")]
        public bool HasPhotoGallery { get; set; }

        [JsonProperty("hasVideo")]
        public bool HasVideo { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("fullPath")]
        public string FullPath { get; set; }

        [JsonProperty("shortText")]
        public string ShortText { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }
    }

}
