using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApiClient;

Console.WriteLine("Blazor API is started..."); 

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(
    sp => 
    new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }
);

await builder.Build().RunAsync();
