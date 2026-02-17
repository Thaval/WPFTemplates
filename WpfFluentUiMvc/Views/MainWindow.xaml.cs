using System.ComponentModel;
using System.Windows;
using Wpf.Ui.Controls;
using WpfFluentUiMvc.Controllers;
using WpfFluentUiMvc.Models;

namespace WpfFluentUiMvc.Views;

/// <summary>
/// View: observes the Model directly (classic MVC).
/// Routes user input to the Controller.
/// Knows both Model (to observe) and Controller (to delegate input).
/// </summary>
public partial class MainWindow : FluentWindow
{
    private CounterController _controller = null!;

    public MainWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Called by App to wire up Model observation and Controller reference.
    /// </summary>
    public void Initialize(CounterModel model, CounterController controller)
    {
        _controller = controller;
        model.PropertyChanged += Model_PropertyChanged;
        CounterText.Text = model.Count.ToString();
    }

    /// <summary>
    /// View observes Model directly — this is what makes MVC different from MVP.
    /// </summary>
    private void Model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (sender is CounterModel model && e.PropertyName == nameof(CounterModel.Count))
            CounterText.Text = model.Count.ToString();
    }

    // --- User input → Controller ---

    private void OnIncrementClick(object sender, RoutedEventArgs e) => _controller.Increment();
    private void OnDecrementClick(object sender, RoutedEventArgs e) => _controller.Decrement();
    private void OnResetClick(object sender, RoutedEventArgs e) => _controller.Reset();
}
