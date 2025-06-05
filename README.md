# 🎮 Player Statistics Simulator - C# Console App

![App Demo](demo.gif) *<!-- Replace with your gameplay demo GIF -->*

[![C# Version](https://img.shields.io/badge/C%23-.NET%206.0-blue.svg)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![Console App](https://img.shields.io/badge/Platform-Console-black.svg)](https://docs.microsoft.com/en-us/dotnet/core/tutorials/console-apps)

> **The ultimate sports analytics toolkit** - Simulate, analyze, and visualize player performance with dynamic data structures!

### Screenshot
![Game Screenshot](csharpplayerstat.png)

## 🏆 Key Features

### 📊 Core Statistics Engine
| Feature | Description |
|---------|-------------|
| **⚡ Dynamic Arrays** | Auto-resizing player data storage |
| **📈 Performance Metrics** | Track 20+ stats per player |
| **🎯 Simulation Mode** | Generate realistic game scenarios |

## 🧰 Prerequisites

Before running this app, ensure the following are installed on your system:

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download)
- Git
- Visual Studio Code (or any preferred editor)

---

## 🚀 Getting Started

Follow these steps to set up and run the project:

### 1. Clone the Repository

```bash
git clone https://github.com/Kellybrackets/Player-statistics-simulator-C-console-app-.git
cd Player-statistics-simulator-C-console-app-
```
2. Open in VS Code (optional)
```bash
code .
```
### 🛠 Fix for .NET SDK Compatibility

	The original project targeted .NET Framework 4.7.2, which isn’t supported on macOS/Linux. We’ve updated it to use .NET 8.

If you’re seeing build errors due to duplicate assembly attributes, delete the old-style file:
```bash
rm Properties/AssemblyInfo.cs
```
### 📦 Restore Dependencies

Run:
```bash
dotnet restore
dotnet build
dotnet run --project TUT7_Question5.csproj
```

💻 Code Highlights
Dynamic Player Storage

```bash
// Flexible player data structure
List<Player> players = new List<Player>();

class Player {
    public string Name { get; set; }
    public int[] Stats { get; set; } // [Points, Rebounds, Assists...]
}
```
Stat Simulation Algorithm

```bash
public void SimulateGame(Player player)
{
    Random rng = new Random();
    player.Stats[0] += rng.Next(10, 50); // Points
    player.Stats[1] += rng.Next(5, 15);  // Rebounds
    // ... other stats
}
```
🤝 Contributing
We welcome sports fans and coders alike! How to help:

🍴 Fork the repository

🏗️ Create a feature branch

💻 Code your enhancement

📤 Submit a pull request
