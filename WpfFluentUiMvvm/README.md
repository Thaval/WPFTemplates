# WPF Fluent UI — MVVM (Model-View-ViewModel)

## Architektur

```
  View ──DataBinding──→ ViewModel ──→ Model
```

## Beziehungen

| Komponente | Kennt | Kennt nicht |
|---|---|---|
| **Model** | niemanden | View, ViewModel |
| **View** | ViewModel (nur via DataBinding) | Model |
| **ViewModel** | Model | View |

## Verantwortlichkeiten

| Komponente | Aufgabe |
|---|---|
| **Model** (`CounterModel`) | Zustand + Geschäftslogik |
| **View** (`MainWindow.xaml`) | Reine XAML-Deklaration, bindet an ViewModel-Properties und Commands — kein Code-Behind |
| **ViewModel** (`CounterViewModel`) | Exponiert `ObservableProperty`s + `RelayCommand`s, delegiert Logik an Model |

## Datenfluss

```
User klickt "+" → {Binding IncrementCommand} löst ViewModel.Increment() aus
                → ViewModel mutiert Model
                → ViewModel setzt Count-Property
                → DataBinding aktualisiert View automatisch
```

## Technologien

- **CommunityToolkit.Mvvm** — `[ObservableProperty]`, `[RelayCommand]` Source Generators
- Lose Kopplung durch **DataBinding** — ViewModel kennt die View nicht

## Starten

```bash
dotnet run
```
