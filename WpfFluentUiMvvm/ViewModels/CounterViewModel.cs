using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfFluentUiMvvm.Models;

namespace WpfFluentUiMvvm.ViewModels;

public partial class CounterViewModel : ObservableObject
{
    private readonly CounterModel _model = new();

    [ObservableProperty]
    private int _count;

    [RelayCommand]
    private void Increment()
    {
        _model.Increment();
        Count = _model.Count;
    }

    [RelayCommand]
    private void Decrement()
    {
        _model.Decrement();
        Count = _model.Count;
    }

    [RelayCommand]
    private void Reset()
    {
        _model.Reset();
        Count = _model.Count;
    }
}
