using WpfFluentUIMvi.Intents;
using WpfFluentUIMvi.Models;

namespace WpfFluentUIMvi.Domain;

/// <summary>
/// Pure reducer: computes the next state from current state + intent.
/// No side effects — all domain logic lives here (Clean Domain).
/// </summary>
public static class CounterReducer
{
    public static CounterState Reduce(CounterState state, CounterIntent intent) => intent switch
    {
        CounterIntent.Increment => state with { Count = state.Count + 1 },
        CounterIntent.Decrement => state with { Count = state.Count - 1 },
        CounterIntent.Reset    => new CounterState(),
        _ => state
    };
}
