# Alexa.NET.WebApiGames
A small library to allow Alexa.NET skills to interact with the Alexa Web Api for Games

### Check to see if HTML is supported on the device

```csharp
using Alexa.NET.WebApiGames;
...
skillRequest.HTMLSupported();
```

### Start a Web API Game

```csharp
using Alexa.NET.WebApiGames;
...
skillResponse.Response.Directives.Add(new StartDirective(uri, data))
```