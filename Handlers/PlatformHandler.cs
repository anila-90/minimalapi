using Microsoft.AspNetCore.Http.HttpResults;

namespace minimalapi.Handlers;

public static class PlatformHandler
{
    public static void MapPlatformEndpoints(this WebApplication app)
    {
        app.MapGet("/platform", GetPlatform);
        app.MapGet("/platform/{name}", GetPlatformByName);
    }
    public static IResult GetPlatformByName(string name)
    {
        List<Platform> platforms = [ new
         Platform
            {
               Name="dotnet",
               Version= "10.0",
               Publisher= "Microsoft"
            },
             new Platform
            {
             Name="sql server",
               Version= "18.0",
               Publisher= "Microsoft"
            }];

        var platform = platforms.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        return Results.Ok(platform);
    }
    public static IResult GetPlatform()
    {
        var platform = new
        {
            name = "dotnet",
            version = "10.0",
            publisher = "Microsoft"
        };

        return Results.Ok(platform);
    }
}

public class Platform
{
    public string Name { get; set; }
    public string Version { get; set; }
    public string Publisher { get; set; }
}