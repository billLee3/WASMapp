global using CRUDBlazorApp.Client.Services.ProjectService;
global using CRUDBlazorApp.Client.Services.FormService;
global using CRUDBlazorApp.Shared;
using CRUDBlazorApp.Client;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IFormService, FormService>();
await builder.Build().RunAsync();
