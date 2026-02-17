# WPF Fluent UI — MVC (Model-View-Controller)

## Architektur

```
         ┌──observes──→ Model (INotifyPropertyChanged)
         │                 ↑
       View                │ mutates
         │                 │
         └──input──→ Controller
```

## Beziehungen

| Komponente | Kennt | Kennt nicht |
|---|---|---|
| **Model** | niemanden | View, Controller |
| **View** | Model, Controller | — |
| **Controller** | Model | View |

## Verantwortlichkeiten

| Komponente | Aufgabe |
|---|---|
| **Model** (`CounterModel`) | Zustand + Geschäftslogik, benachrichtigt Beobachter via `INotifyPropertyChanged` |
| **View** (`MainWindow`) | Beobachtet das Model direkt (`PropertyChanged`), leitet User-Input an den Controller weiter |
| **Controller** (`CounterController`) | Empfängt User-Input, verändert das Model — hat keinen Zugriff auf die View |

## Datenfluss

```
User klickt "+" → View ruft Controller.Increment()
                → Controller mutiert Model
                → Model feuert PropertyChanged
                → View aktualisiert sich selbst
```

## Starten

```bash
dotnet run
```
