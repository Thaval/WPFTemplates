using WpfFluentUiMvc.Models;

namespace WpfFluentUiMvc.Controllers;

/// <summary>
/// Controller: handles user input and mutates the Model.
/// Does NOT update the View — the View observes the Model directly.
/// Does NOT hold a reference to the View.
/// </summary>
public class CounterController
{
    private readonly CounterModel _model;

    public CounterController(CounterModel model)
    {
        _model = model;
    }

    public void Increment() => _model.Increment();
    public void Decrement() => _model.Decrement();
    public void Reset() => _model.Reset();
}
