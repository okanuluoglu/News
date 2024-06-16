using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public record NewsItem
    {
        [JsonProperty("hasPhotoGallery")]
        public bool HasPhotoGallery { get; set; }

        [JsonProperty("hasVideo")]
        public bool HasVideo { get; set; }

        [JsonProperty("titleVisible")]
        public bool TitleVisible { get; set; }

        [JsonProperty("fLike")]
        public string FLike { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("shortText")]
        public string ShortText { get; set; }

        [JsonProperty("fullPath")]
        public string FullPath { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("videoUrl")]
        public string VideoUrl { get; set; }

        [JsonProperty("externalUrl")]
        public string ExternalUrl { get; set; }

        [JsonProperty("columnistName")]
        public string ColumnistName { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }
    }
}
