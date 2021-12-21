using CoursesApp;
using CoursesApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseAddress = builder.Configuration.GetValue<string>("App:ApiUrl");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

// service registrations
builder.Services.AddScoped<ICoursesProvider, CoursesProvider>();

await builder.Build().RunAsync();
