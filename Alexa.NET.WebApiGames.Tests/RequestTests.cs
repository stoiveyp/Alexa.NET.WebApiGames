using System;
using Alexa.NET.Request;
using Xunit;
using Alexa.NET.WebApiGames;

namespace Alexa.NET.WebApiGames.Tests
{
    public class RequestTests
    {
        [Fact]
        public void HtmlSupported()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("HtmlInterface.json");
            Assert.True(request.HTMLSupported());
        }
    }
}
