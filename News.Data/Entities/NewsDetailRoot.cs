using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public record NewsDetailRoot
    {
        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("data")]
        public NewsDetailData Data { get; set; }
    }
}
