namespace WpfFluentUiMvp.Views;

public interface ICounterView
{
    void UpdateCounter(int count);

    event EventHandler? IncrementClicked;
    event EventHandler? DecrementClicked;
    event EventHandler? ResetClicked;
}
