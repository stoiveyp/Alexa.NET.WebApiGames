using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.WebApiGames.Tests
{
    public static class Utility
    {
        private const string ExamplesPath = "Examples";

        public static bool CompareJson(object actual, string expectedFile, params string[] exclude)
        {
            var actualJObject = JObject.FromObject(actual);
            var expected = File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
            var expectedJObject = JObject.Parse(expected);

            foreach (var field in exclude)
            {
                expectedJObject.Remove(field);
                actualJObject.Remove(field);
            }

            return JToken.DeepEquals(expectedJObject, actualJObject);
        }



        public static T ExampleFileContent<T>(string expectedFile)
        {
            using (var reader = new JsonTextReader(new StringReader(ExampleFileContent(expectedFile))))
            {
                return new JsonSerializer().Deserialize<T>(reader);
            }
        }

        public static string ExampleFileContent(string expectedFile)
        {
            return File.ReadAllText(Path.Combine(ExamplesPath, expectedFile).Trim());
        }

        public static void AssertSerialization<T>(string expectedFile, params string[] exclude)
        {
            var obj = ExampleFileContent<T>(expectedFile);
            Assert.True(CompareJson(obj, expectedFile, exclude));
        }
    }
}
