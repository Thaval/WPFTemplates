using System;
using WpfFluentUIMvi.Domain;
using WpfFluentUIMvi.Intents;
using WpfFluentUIMvi.Models;

namespace WpfFluentUIMvi.Store;

/// <summary>
/// Unidirectional store: single source of truth.
/// Dispatches intents through the domain reducer and notifies subscribers.
/// </summary>
public class CounterStore
{
    private CounterState _state = new();

    public CounterState State => _state;

    public event Action<CounterState>? StateChanged;

    public void Dispatch(CounterIntent intent)
    {
        _state = CounterReducer.Reduce(_state, intent);
        StateChanged?.Invoke(_state);
    }
}
