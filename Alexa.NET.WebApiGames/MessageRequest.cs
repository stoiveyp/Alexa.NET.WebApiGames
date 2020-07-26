using Alexa.NET.Request.Type;
using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public class MessageRequest: Request.Type.Request
    {
        public static void AddToRequestConverter()
        {
            RequestConverter.RequestConverters.Add(new MessageRequestConverter());
        }

        [JsonProperty("message")]
        public object Message { get; set; }
    }
}
