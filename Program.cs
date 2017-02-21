using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
namespace webapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
               .UseKestrel()
               .Configure(app =>
               {
                   app.Run(async (context) =>
                    { 
                        var person = context.Request.Path.Value.Replace("/","");
                        await context.Response.WriteAsync($"<h1>Hello World {person}</h1>");
                    });
               })
               .Build();
            host.Run();
        }
    }
}
