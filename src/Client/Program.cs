using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StateManagement.Pax;
using StateManagement.Fields;
using StateManagementInterface;
using Client;
using StateManagement.Icons;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddTelerikBlazor()
    .AddFluxor(o 
        => o.ScanAssemblies(
                typeof(IPaxState).Assembly,
                typeof(PaxState).Assembly
            )
        .UseReduxDevTools()
    )
    .AddSingleton<IPaxState>(sp => sp.GetRequiredService<PaxState>())
    .AddSingleton<IFieldState>(sp => sp.GetRequiredService<FieldState>())
    .AddSingleton<IIconState>(sp => sp.GetRequiredService<IconState>());

var host = builder.Build();

await host.RunAsync();
