namespace WpfFluentUiMvp.Models;

public class CounterModel
{
    public int Count { get; set; }

    public void Increment() => Count++;
    public void Decrement() => Count--;
    public void Reset() => Count = 0;
}
