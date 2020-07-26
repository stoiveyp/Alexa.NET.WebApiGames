using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public class StartDirective:IDirective
    {
        private const string DirectiveType = "Alexa.Presentation.HTML.Start";

        [JsonProperty("type")]
        public string Type => DirectiveType;

        public static void AddSupport()
        {
            DirectiveConverter.TypeFactories.Add(DirectiveType, () => new StartDirective());
        }

        public StartDirective(){}

        public StartDirective(string requestUri, object data = null, int timeoutInSeconds = 30)
        {
            Request = new StartRequest {Uri = requestUri};
            Data = data;
            Configuration = new StartConfiguration(timeoutInSeconds);
        }

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        [JsonProperty("request")]
        public StartRequest Request { get; set; }

        [JsonProperty("transformers", NullValueHandling = NullValueHandling.Ignore)]
        public IList<HTMLTransformer> Transformers { get; set; }

        [JsonProperty("configuration")]
        public StartConfiguration Configuration { get; set; }
    }
}
