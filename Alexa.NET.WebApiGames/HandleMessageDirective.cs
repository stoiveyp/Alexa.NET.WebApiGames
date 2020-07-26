using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public class HandleMessageDirective : IDirective
    {
        private const string DirectiveType = "Alexa.Presentation.HTML.HandleMessage";

        [JsonProperty("type")]
        public string Type => DirectiveType;

        public static void AddSupport()
        {
            DirectiveConverter.TypeFactories.Add(DirectiveType, () => new HandleMessageDirective());
        }

        public HandleMessageDirective() { }

        public HandleMessageDirective(object message)
        {
            Message = message;
        }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public object Message { get; set; }

        [JsonProperty("transformers", NullValueHandling = NullValueHandling.Ignore)]
        public IList<HTMLTransformer> Transformers { get; set; }

    }
}
