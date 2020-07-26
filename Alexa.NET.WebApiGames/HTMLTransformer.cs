using Newtonsoft.Json;

namespace Alexa.NET.WebApiGames
{
    public class HTMLTransformer
    {
        public HTMLTransformer() { }

        public HTMLTransformer(string transformerType, string outputName)
        {
            Transformer = transformerType;
            OutputName = outputName;
        }

        public HTMLTransformer(string transformerType, string inputPath, string outputName)
        {
            Transformer = transformerType;
            InputPath = inputPath;
            OutputName = outputName;
        }

        [JsonProperty("inputPath", NullValueHandling = NullValueHandling.Ignore)]
        public string InputPath { get; set; }

        [JsonProperty("outputName", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputName { get; set; }

        [JsonProperty("transformer")]
        public string Transformer { get; set; }

        public static HTMLTransformer SsmlToSpeech(string inputPath, string outputName)
        {
            return new HTMLTransformer("ssmlToSpeech", inputPath, outputName);
        }


        public static HTMLTransformer TextToSpeech(string inputPath, string outputName)
        {
            return new HTMLTransformer("textToSpeech", inputPath, outputName);
        }
    }
}