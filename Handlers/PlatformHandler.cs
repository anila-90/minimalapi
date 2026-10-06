namespace minimalapi.Handlers;

public static class PlatformHandler
{
    public static void MapPlatformEndpoints(this WebApplication app)
    {
        app.MapGet("/platform", GetPlatform);
    }
    public static IResult GetPlatform()
        {
            var platform = new
            {
               name="dotnet",
               version= "10.0",
               publisher= "Microsoft"
            };

            return Results.Ok(platform);
        }
}