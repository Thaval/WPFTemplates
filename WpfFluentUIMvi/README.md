# WPF Fluent UI — MVI (Model-View-Intent)

## Architektur

MVVM + Clean Domain + Unidirectional State Flow

```
  View ──Binding──→ ViewModel ──Dispatch(Intent)──→ Store ──→ Reducer ──→ neuer State
    ↑                    ↑                                                    │
    └────DataBinding─────└──────────────StateChanged──────────────────────────┘
```

## Beziehungen

| Komponente | Kennt | Kennt nicht |
|---|---|---|
| **State** (`CounterState`) | niemanden | alles andere |
| **Intent** (`CounterIntent`) | niemanden | alles andere |
| **Reducer** (`CounterReducer`) | State, Intent | Store, ViewModel, View |
| **Store** (`CounterStore`) | Reducer, State, Intent | ViewModel, View |
| **ViewModel** (`CounterViewModel`) | Store, Intent | View |
| **View** (`MainWindow.xaml`) | ViewModel (via DataBinding) | Store, Reducer, Model |

## Verantwortlichkeiten

| Komponente | Aufgabe |
|---|---|
| **State** (`CounterState`) | Immutable `record` — beschreibt den gesamten Zustand |
| **Intent** (`CounterIntent`) | Sealed records — alle möglichen User-Aktionen als Datentypen |
| **Reducer** (`CounterReducer`) | Pure Funktion: `(State, Intent) → State` — gesamte Domain-Logik |
| **Store** (`CounterStore`) | Single Source of Truth — dispatcht Intents über Reducer, benachrichtigt Subscriber |
| **ViewModel** (`CounterViewModel`) | MVVM-Brücke — übersetzt State in ObservableProperties, User-Commands in Intents |
| **View** (`MainWindow.xaml`) | Reine XAML-Deklaration via DataBinding — kein Code-Behind |

## Datenfluss (unidirektional)

```
1. User klickt "+"
2. View → {Binding IncrementCommand}
3. ViewModel → Store.Dispatch(new CounterIntent.Increment())
4. Store → CounterReducer.Reduce(currentState, intent)
5. Reducer erzeugt neuen immutable State
6. Store feuert StateChanged
7. ViewModel empfängt neuen State → setzt ObservableProperty
8. DataBinding aktualisiert View
```

## Unterschied zu MVVM

| Aspekt | MVVM | MVI |
|---|---|---|
| State | Mutable Properties im ViewModel | **Immutable** `record` im Store |
| Logik | Im ViewModel verstreut | **Pure Reducer** (Clean Domain) |
| Datenfluss | Bidirektional (TwoWay Binding möglich) | **Strikt unidirektional** |
| Aktionen | Commands direkt im ViewModel | **Intents als Datentypen** → Reducer |
| Vorhersagbarkeit | Mittel | **Hoch** (jeder Intent erzeugt deterministisch neuen State) |

## Starten

```bash
dotnet run
```
