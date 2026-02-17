# WPF Fluent UI Starter Templates

Vier minimalistische Starter-Projekte für **WPF** mit **Fluent UI** (Wpf.Ui) auf **.NET 10** — jeweils ein Architekturmuster, sofort lauffähig.

## Projekte

| Ordner | Pattern | Beschreibung |
|---|---|---|
| `WpfFluentUiMvc/` | **MVC** | Model-View-Controller — View beobachtet Model direkt, Controller verarbeitet Input |
| `WpfFluentUiMvp/` | **MVP** | Model-View-Presenter — View hinter Interface, Presenter als einziger Vermittler |
| `WpfFluentUiMvvm/` | **MVVM** | Model-View-ViewModel — DataBinding + Commands, kein Code-Behind |
| `WpfFluentUIMvi/` | **MVI** | Model-View-Intent — MVVM + Clean Domain + Unidirectional State Flow |

## Architektur-Vergleich

```
MVC:   View ──observes──→ Model ←──mutates── Controller ←──input── View
MVP:   View (ICounterView) ←──→ Presenter ←──→ Model
MVVM:  View ──DataBinding──→ ViewModel ──→ Model
MVI:   View ──Binding──→ ViewModel ──Intent──→ Store ──Reducer──→ State ──→ ViewModel
```

## Tech Stack

- **.NET 10** (`net10.0-windows`)
- **WPF-UI** (Wpf.Ui) — Fluent Design System
- **CommunityToolkit.Mvvm** — Source Generators für MVVM & MVI

## Schnellstart

```bash
cd WpfFluentUiMvc   # oder Mvp, Mvvm, MVI
dotnet run
```

## Lizenz

MIT
