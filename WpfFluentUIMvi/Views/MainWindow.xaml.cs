using Wpf.Ui.Controls;

namespace WpfFluentUIMvi.Views;

/// <summary>
/// Pure View: no logic, no event handlers.
/// All interaction flows through data binding to the ViewModel.
/// </summary>
public partial class MainWindow : FluentWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
