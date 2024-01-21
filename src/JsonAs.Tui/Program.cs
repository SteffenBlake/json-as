using Microsoft.Extensions.Hosting;
using JsonAs.Tui.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using JsonAs.Tui;
using Terminal.Gui;

var app = Host.CreateApplicationBuilder(args);

var model = app.Configuration.Get<JsonAsVM>() ??
    throw new JsonException();

app.Services.AddHostedService<App>();
app.Services.AddSingleton(model);

await app.Build().RunAsync();
