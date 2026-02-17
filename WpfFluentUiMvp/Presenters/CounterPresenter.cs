using WpfFluentUiMvp.Models;
using WpfFluentUiMvp.Views;

namespace WpfFluentUiMvp.Presenters;

public class CounterPresenter
{
    private readonly CounterModel _model = new();
    private readonly ICounterView _view;

    public CounterPresenter(ICounterView view)
    {
        _view = view;
        _view.IncrementClicked += (_, _) => { _model.Increment(); RefreshView(); };
        _view.DecrementClicked += (_, _) => { _model.Decrement(); RefreshView(); };
        _view.ResetClicked += (_, _) => { _model.Reset(); RefreshView(); };
        RefreshView();
    }

    private void RefreshView() => _view.UpdateCounter(_model.Count);
}
