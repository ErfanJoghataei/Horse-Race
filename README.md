# 🏇 Horse Race Simulator

A simple, interactive, and animated console-based application written in **C#** that simulates a horse racing event with a basic betting system and weather-affected mechanics.

---

## 📄 Overview

In this game, multiple horses compete against each other on a custom-length track. The player inputs the name of the horse they wish to bet on, and the race kicks off. The progress of each horse is displayed dynamically using real-time text animations in the console. Once a horse crosses the finish line, the application announces the winner and tells the player if their bet succeeded.

### Key Features:
* **Dynamic Weather System:** The speed of the horses is directly affected by the chosen weather condition (`Normal`, `Rainy`, or `Snowy`).
* **Console-Based Animation:** Uses active frame-clearing to simulate a smooth, real-time racing track in the command line interface.
* **Randomized Movement Logic:** Every horse moves using randomized step intervals per turn, making each race unpredictable and exciting.
---

## 🛠️ Prerequisites

To run and develop this project, you will need:
* **.NET SDK** (Version 6.0 or higher is recommended)
* An IDE or Text Editor such as **Visual Studio** or **VS Code**

---

## 🚀 How to Run

1. Clone or download the repository files to your local machine.
2. Open your terminal or Command Prompt in the project's root directory.
3. Run the following command to start the application:

```bash
dotnet run
