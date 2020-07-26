using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public class StartRequest
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,string> Headers { get; set; }
    }
}