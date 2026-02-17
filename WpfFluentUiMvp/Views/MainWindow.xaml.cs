using System;
using System.Windows;
using Wpf.Ui.Controls;

namespace WpfFluentUiMvp.Views;

/// <summary>
/// Passive View: implements ICounterView contract.
/// Has no knowledge of the Presenter.
/// </summary>
public partial class MainWindow : FluentWindow, ICounterView
{
    public event EventHandler? IncrementClicked;
    public event EventHandler? DecrementClicked;
    public event EventHandler? ResetClicked;

    public MainWindow()
    {
        InitializeComponent();
    }

    public void UpdateCounter(int count) => CounterText.Text = count.ToString();

    private void OnIncrementClick(object sender, RoutedEventArgs e) => IncrementClicked?.Invoke(this, EventArgs.Empty);
    private void OnDecrementClick(object sender, RoutedEventArgs e) => DecrementClicked?.Invoke(this, EventArgs.Empty);
    private void OnResetClick(object sender, RoutedEventArgs e) => ResetClicked?.Invoke(this, EventArgs.Empty);
}
