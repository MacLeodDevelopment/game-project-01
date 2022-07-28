using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Game.UI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddSingleton<ISharonTest, SharonTest>();

await builder.Build().RunAsync();

public interface ISharonTest
{
    string SayHello();
}

public class SharonTest : ISharonTest
{
    public string SayHello()
    {
        return "Hello everybody";
    }
}