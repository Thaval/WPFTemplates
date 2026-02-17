using System.Windows;
using WpfFluentUiMvp.Presenters;
using WpfFluentUiMvp.Views;

namespace WpfFluentUiMvp;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var view = new MainWindow();
        _ = new CounterPresenter(view);
        view.Show();
    }
}
