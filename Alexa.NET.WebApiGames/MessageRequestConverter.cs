using Alexa.NET.Request.Type;

namespace Alexa.NET.WebApiGames
{
    public class MessageRequestConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Alexa.Presentation.HTML.Message";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new MessageRequest();
        }
    }
}