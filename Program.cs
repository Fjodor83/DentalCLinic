using DentalCLinic;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using DentalCLinic.Services;
using FluentValidation;
using DentalCLinic.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Enterprise Services
builder.Services.AddScoped<ToastService>();

// Validators
builder.Services.AddScoped<IValidator<ContactFormModel>, ContactFormModelValidator>();

await builder.Build().RunAsync();
