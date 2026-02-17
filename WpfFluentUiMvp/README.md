# WPF Fluent UI — MVP (Model-View-Presenter)

## Architektur

```
  View (ICounterView) ←→ Presenter ←→ Model
```

## Beziehungen

| Komponente | Kennt | Kennt nicht |
|---|---|---|
| **Model** | niemanden | View, Presenter |
| **View** | niemanden (implementiert nur `ICounterView`) | Presenter, Model |
| **Presenter** | View (via Interface), Model | — |

## Verantwortlichkeiten

| Komponente | Aufgabe |
|---|---|
| **Model** (`CounterModel`) | Zustand + Geschäftslogik |
| **View** (`MainWindow` : `ICounterView`) | Reine UI-Darstellung, feuert Events bei User-Interaktion, bietet `UpdateCounter()` an |
| **Presenter** (`CounterPresenter`) | Einziger Vermittler — reagiert auf View-Events, verändert Model, pusht Ergebnis an View |

## Datenfluss

```
User klickt "+" → View feuert IncrementClicked-Event
                → Presenter empfängt Event
                → Presenter mutiert Model
                → Presenter ruft View.UpdateCounter()
```

## Unterschied zu MVC

- View hat **keinen** Kontakt zum Model (alles über Presenter)
- View ist über ein **Interface** (`ICounterView`) abstrahiert → testbar/mockbar
- Presenter steuert die View aktiv (Push), statt dass die View sich selbst aktualisiert (Pull)

## Starten

```bash
dotnet run
```
