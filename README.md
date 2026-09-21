# 🎮 Tres en Raya (Tic-Tac-Toe) - WinForms & Minimax AI

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-14-239120?style=flat&logo=csharp)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat&logo=windows)
![License](https://img.shields.io/badge/License-MIT-green)

Aplicación de escritorio interactiva del clásico juego **Tres en Raya** construida con **C# y Windows Forms (.NET 10)**. El proyecto implementa arquitectura orientada a eventos, control de estados matriciales, soporte para efectos de sonido y un motor de inteligencia artificial invencible basado en el algoritmo **Minimax**.

---

## 🎮 Demostración

<img width="406" height="664" alt="Tres en Raya - Minimax AI 2026-09-21 16-46-48" src="https://github.com/user-attachments/assets/95ea2448-3e60-4b25-bc86-9689b312d419" />

---

## ✨ Características Principales

* **Inteligencia Artificial Invencible (Minimax):** Modo contra la máquina que calcula recursivamente el árbol de decisiones óptimo para asegurar victoria o forzar empate.
* **Modos de Juego Flexibles:** Alternancia en tiempo real entre modo local de 2 Jugadores (humano vs. humano) y contra la computadora (IA).
* **Feedback Auditivo Dinámico:** Integración de efectos de sonido nativos (`System.Media.SoundPlayer`) para clics de casilla, fanfarria de victoria y empate.
* **Manejo Unificado de Eventos:** Arquitectura limpia que delega la interacción del tablero 3x3 mediante el desacoplamiento del parámetro `sender`.
* **Marcador Histórico Persistente:** Contador de victorias para 'X', 'O' y empates durante toda la sesión con confirmación de reinicio seguro.
* **Diseño Visual Adaptativo:** Maquetación estructurada con `TableLayoutPanel`, previniendo distorsiones de coordenadas y resaltando la línea ganadora en color verde.

---

## 🧠 Arquitectura Algorítmica: Motor Minimax

El motor de decisión evalúa el tablero virtual asignando puntuaciones a los estados terminales:

* **+10 - profundidad:** Si gana la IA ('O'). Restar la profundidad prioriza las victorias más rápidas.
* **-10 + profundidad:** Si gana el jugador ('X'). Sumar la profundidad penaliza las derrotas y busca retrasarlas.
* **0:** Si la partida concluye en empate.

---

## 🛠️ Tecnologías y Requisitos

* **Entorno:** Visual Studio 2022 con carga de trabajo *.NET Desktop Development*.
* **Framework:** .NET 10.0 LTS (Windows Forms).
* **Lenguaje:** C# 14.
* **Sistema Operativo:** Windows 10 / Windows 11.

---

## 🚀 Instalación y Ejecución

### Opción 1: Mediante Terminal (.NET CLI)

1. Clona el repositorio:
```bash
https://github.com/ArielCusipumaOrtega/TresEnRaya-WinForms.git
cd TresEnRaya-WinForms
```

2. Restaura dependencias y compila:
```bash
dotnet build
```

3. Ejecuta las pruebas unitarias:
```bash
dotnet test
```

4. Ejecuta la aplicación:
```bash
dotnet run --project TresEnRayaApp
```

### Opción 2: Desde Visual Studio

1. Abre el archivo de solución `TresEnRayaApp.slnx`.
2. Selecciona la configuración de compilación `Debug` o `Release` en `Any CPU`.
3. Presiona **F5** o haz clic en **Iniciar**.

---

## 📂 Estructura del Proyecto

El proyecto sigue una arquitectura desacoplada respetando los principios **SOLID** y el principio de responsabilidad única (**SRP**):

```text
TresEnRayaApp/
├── Engine/
│   ├── GameEvents.cs          # DTOs y argumentos inmutables para eventos del juego
│   ├── ITicTacToeGame.cs      # Contrato del motor de juego
│   └── TicTacToeGame.cs       # Coordinador central de reglas, turnos y puntuación
├── Models/
│   ├── Board.cs               # Representación matricial 3x3 y validación de victorias
│   ├── GameMode.cs            # Modos de juego (Humano vs IA, Humano vs Humano)
│   ├── GameState.cs           # Estados del juego (InProgress, Won, Draw)
│   ├── Player.cs              # Enumeración fuertemente tipada y extensiones
│   ├── ScoreCard.cs           # Registro y control histórico del marcador
│   └── WinLine.cs             # Registro de casillas que forman la línea ganadora
├── Services/
│   ├── IAiPlayer.cs           # Contrato de algoritmos de inteligencia artificial
│   ├── MinimaxAiPlayer.cs     # Implementación pura de Minimax (desacoplada de UI)
│   ├── ISoundService.cs       # Contrato para reproducción de efectos sonoros
│   └── SoundService.cs        # Implementación con SoundPlayer y liberación de recursos
├── MainForm.cs                # Formulario WinForms (Vista puramente reactiva a eventos)
├── MainForm.Designer.cs       # Componentes visuales y layout
├── MainForm.resx              # Recursos del formulario
├── Program.cs                 # Punto de entrada de la aplicación
└── TresEnRayaApp.csproj       # Configuración de compilación

TresEnRayaApp.Tests/           # Suite de pruebas unitarias (xUnit)
├── BoardTests.cs              # Pruebas de reglas, casillas y combinaciones de victoria
├── MinimaxAiPlayerTests.cs    # Pruebas de invencibilidad, bloqueos y búsqueda óptima
├── TicTacToeGameTests.cs      # Pruebas del flujo de juego, eventos y marcador
└── TresEnRayaApp.Tests.csproj # Configuración de pruebas unitarias
```

---

## 📄 Licencia

Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.

