using System;
using Alexa.NET.Request;
using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public static class HTMLInterface
    {
        public const string InterfaceName = "Alexa.Presentation.HTML";

        public static bool HTMLSupported(this SkillRequest request)
        {
            return Supported(request);
        }

        public static bool Supported(SkillRequest request)
        {
            return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
        }
    }
}
