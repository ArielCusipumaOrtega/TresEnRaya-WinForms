# 🎮 Tres en Raya (Tic-Tac-Toe) - WinForms & Minimax AI

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-14-239120?style=flat&logo=csharp)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat&logo=windows)
![License](https://img.shields.io/badge/License-MIT-green)

Aplicación de escritorio interactiva del clásico juego **Tres en Raya** construida con **C# y Windows Forms (.NET 10)**. El proyecto implementa arquitectura orientada a eventos, control de estados matriciales, soporte para efectos de sonido y un motor de inteligencia artificial invencible basado en el algoritmo **Minimax**.

---

## 📸 Captura de Pantalla

<img width="487" height="722" alt="image" src="https://github.com/user-attachments/assets/24fa8f82-0f0f-4a80-96c9-e5d114139c2a" />

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

3. Ejecuta la aplicación:
```bash
dotnet run --project TresEnRayaApp
```

### Opción 2: Desde Visual Studio

1. Abre el archivo de solución `TresEnRayaApp.sln`.
2. Selecciona la configuración de compilación `Debug` o `Release` en `Any CPU`.
3. Presiona **F5** o haz clic en **Iniciar**.

---

## 📂 Estructura del Proyecto

```text
TresEnRayaApp/
├── MainForm.cs             # Lógica del juego, Minimax y eventos
├── MainForm.Designer.cs    # Definición de componentes visuales (WinForms)
├── MainForm.resx           # Recursos del formulario
├── Program.cs              # Punto de entrada de la aplicación
└── TresEnRayaApp.csproj    # Configuración de compilación y Target Framework
```

---

## 📄 Licencia

Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.
