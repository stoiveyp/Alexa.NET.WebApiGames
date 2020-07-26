using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public class StartConfiguration
    {
        public StartConfiguration(){}

        public StartConfiguration(int timeoutInSeconds)
        {
            TimeoutInSeconds = timeoutInSeconds;
        }

        [JsonProperty("timeoutInSeconds")]
        public int TimeoutInSeconds { get; set; }
    }
}