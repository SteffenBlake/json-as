using JsonAs.Tui.Models;
using Microsoft.Extensions.Hosting;
using Terminal.Gui;
using Terminal.Gui.Views;

namespace JsonAs.Tui;

public class App(
        JsonAsVM model, 
        IHostApplicationLifetime lifetime
) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        if (!model.Silent)
        {
            Application.Init();
            Application.Run(new MainWindow(model));
        }



        lifetime.StopApplication();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        if (!model.Silent)
        {
            Application.Shutdown();
        }
        return Task.CompletedTask;
    }
}
