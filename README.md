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

### Send a message to your game

```csharp
using Alexa.NET.WebApiGames;
...
skillResponse.Response.Directives.Add(new HandleMessageDirective(message))
```

### Receive a message from your game

```csharp
using Alexa.NET.WebApiGames;
MessageRequest.AddToRequestConverter();
...
if request.Request is MessageRequest messageRequest{
    var msg = messageRequest.Message;
}
```