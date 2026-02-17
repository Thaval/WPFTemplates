using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfFluentUIMvi.Intents;
using WpfFluentUIMvi.Models;
using WpfFluentUIMvi.Store;

namespace WpfFluentUIMvi.ViewModels;

/// <summary>
/// MVVM layer on top of the unidirectional store.
/// Exposes immutable state as observable properties and
/// translates user actions into intents dispatched to the store.
/// </summary>
public partial class CounterViewModel : ObservableObject
{
    private readonly CounterStore _store = new();

    [ObservableProperty]
    private int _count;

    public CounterViewModel()
    {
        _store.StateChanged += OnStateChanged;
        OnStateChanged(_store.State);
    }

    private void OnStateChanged(CounterState state)
    {
        Count = state.Count;
    }

    [RelayCommand]
    private void Increment() => _store.Dispatch(new CounterIntent.Increment());

    [RelayCommand]
    private void Decrement() => _store.Dispatch(new CounterIntent.Decrement());

    [RelayCommand]
    private void Reset() => _store.Dispatch(new CounterIntent.Reset());
}
