using System.Net.Http.Headers;
using Demo;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

var serviceCollection = new ServiceCollection();

serviceCollection
    .AddConferenceClient()
    .ConfigureHttpClient(client =>
    {
        client.BaseAddress = new Uri("https://api.spacex.land/graphql/");
        // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJSUzI1NiIsImtpZCI6IkUzMkYxNzI1NjE4QTE0OTc4Mjc1QkMzMDMwODAxMUJBOTQ1OEQ3OEEiLCJ0eXAiOiJKV1QiLCJ4NXQiOiI0eThYSldHS0ZKZUNkYnd3TUlBUnVwUlkxNG8ifQ.eyJuYmYiOjE2NDQyNDIwMzQsImV4cCI6MTY0NDI0NTYzNCwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5saWViaGVyci5jb20iLCJhdWQiOlsiaHR0cHM6Ly9sb2dpbi5saWViaGVyci5jb20vcmVzb3VyY2VzIiwibGltb2FwaSJdLCJjbGllbnRfaWQiOiI1YTU3ZjY3MC05NmU5LTRhN2YtYjc1MC1hYzg3YTQyNzk2OTMiLCJzdWIiOiJsd25iZW1jQGx3bi5saWViaGVyci5pIiwiYXV0aF90aW1lIjoxNjQ0MjQyMDM0LCJpZHAiOiJsb2NhbCIsInNjb3BlIjpbIm9wZW5pZCIsImxpbW9hcGkiXSwiYW1yIjpbInB3ZCJdfQ.bbY57FVSYAd2k1ixdUkzgWAc6-RDX-xQBcXNSCKhzcn4lR4YyRstH7eI_pAM7kIfcG-oQHFEUjyjKrA3vA4GbvO9fKWmF5R-FjpcBhR-snrrwzBJM-7p51atwo8Ae4wD3rEqR6eDq8wTwKbNP03rynPsKDWlIuN7bQmWkV3WSZxj6rN6H37ISW-rWb29kEc7ijTk50iRWK4Cg5bDU3V0AmbRBskLhXlB7QQoXgLxrZWFIGCjvBaXIYQfVblj6kwygiKclyONX392_6SHdyCWBiXiF-EnB_KtWrg4k_1g0AJTV_vQz651VtwUDmq7Fto6f7NKtLeKitzg7YABZIi-Lg");
    });

IServiceProvider services = serviceCollection.BuildServiceProvider();

IConferenceClient client = services.GetRequiredService<IConferenceClient>();

//var result = await client.LastKeyFigureQueries.ExecuteAsync("PME1.ID2:WHEELLOADER::LARGE_SIZE:L586:461:42499", new [] {"OperatingHoursMachine"}, CancellationToken.None);

//result.EnsureNoErrors();

//foreach (var session in result.Data.LastKeyFigureQueries.Result1)
//{
//    Console.WriteLine($"{session.Test} {session.Value}");
//}