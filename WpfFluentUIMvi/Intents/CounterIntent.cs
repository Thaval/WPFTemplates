namespace WpfFluentUIMvi.Intents;

/// <summary>
/// All possible user intents for the counter feature.
/// </summary>
public abstract record CounterIntent
{
    public sealed record Increment : CounterIntent;
    public sealed record Decrement : CounterIntent;
    public sealed record Reset : CounterIntent;
}
