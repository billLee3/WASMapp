global using CRUDBlazorApp.Client.Services.ProjectService;
global using CRUDBlazorApp.Client.Services.FormService;
global using CRUDBlazorApp.Shared;
global using CRUDBlazorApp.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
using CRUDBlazorApp.Client;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using Blazored.LocalStorage;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IFormService, FormService>();
builder.Services.AddScoped<IAuthen, Authen>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddRadzenComponents();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustAuthStateProvider>();



await builder.Build().RunAsync();
