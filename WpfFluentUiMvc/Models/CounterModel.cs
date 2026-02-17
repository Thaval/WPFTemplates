using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfFluentUiMvc.Models;

/// <summary>
/// Observable Model: notifies observers (the View) when state changes.
/// This is the key difference to MVP — the View observes the Model directly.
/// </summary>
public class CounterModel : INotifyPropertyChanged
{
    private int _count;

    public int Count
    {
        get => _count;
        private set { _count = value; OnPropertyChanged(); }
    }

    public void Increment() => Count++;
    public void Decrement() => Count--;
    public void Reset() => Count = 0;

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
