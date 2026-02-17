using System.Windows;
using WpfFluentUiMvc.Controllers;
using WpfFluentUiMvc.Models;
using WpfFluentUiMvc.Views;

namespace WpfFluentUiMvc;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // Classic MVC wiring: Model is shared, View observes Model, Controller mutates Model
        var model = new CounterModel();
        var controller = new CounterController(model);
        var view = new MainWindow();
        view.Initialize(model, controller);
        view.Show();
    }
}
