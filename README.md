## What is this?

CorrelatorSharp.RestSharp is an add-on for RestSharp that enables support for [CorrelatorSharp](http://correlatorsharp.github.io). 

## Get it


|   Where    |    What   |
|-------------|-------------|
| NuGet       | [CorrelatorSharp.RestSharp](https://www.nuget.org/packages/CorrelatorSharp.RestSharp/)
| Latest Build (master)      |   [![Build status](https://ci.appveyor.com/api/projects/status/q3nhddka9nku400w/branch/master?svg=true)](https://ci.appveyor.com/project/CorrelatorSharp/correlatorsharp-restsharp/branch/master)  |


## Using it

When making requests with RestSharp you can inject the current activity scope's correlation id using the `AddCorrelationHeader()` extension method on `RestRequest`: 

```csharp
RestRequest request;

request.AddCorrelationHeader();
```


