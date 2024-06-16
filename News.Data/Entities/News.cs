using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace News.Data.Entities
{
    public record News
    {
        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; } = new();
    }
}
