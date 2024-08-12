using Fahad_Portfolio.Client.Service;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<E_Service>();

await builder.Build().RunAsync();
