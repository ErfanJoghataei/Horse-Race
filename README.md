# 🏇 Horse Race Simulator (شبیه‌ساز مسابقه اسب‌دوانی)

یک برنامه ساده، جذاب و متنی (Console-based) به زبان **#C** برای شبیه‌سازی مسابقه اسب‌دوانی همراه با سیستم شرط‌بندی و مکانیزم آب‌و‌هوا.

---

## 📄 معرفی پروژه

در این برنامه، چندین اسب در یک پیست مسابقه به رقابت می‌پردازند. کاربر در ابتدا نام اسب مورد نظر خود را برای شرط‌بندی وارد می‌کند، سپس مسابقه شروع شده و به صورت زنده (انیمیشن خطی در کنسول) جلو رفتن اسب‌ها نمایش داده می‌شود. در نهایت مشخص می‌شود که آیا اسب انتخابی کاربر برنده شده است یا خیر.

### ویژگی‌های کلیدی:
* **سیستم آب و هوا (Weather System):** سرعت حرکت اسب‌ها کاملاً تحت تأثیر شرایط جوی (`Normal`، `Rainy`، `Snowy`) قرار می‌گیرد.
* **شبیه‌سازی انیمیشنی:** پیشرفت اسب‌ها در طول مسابقه با کاراکترهای متنی و به صورت Real-time در کنسول پاک‌سازی و بروزرسانی می‌شود.
* **منطق تصادفی (Randomized Movement):** حرکت هر اسب در هر گام بر اساس شانس و بازه عددی مشخصی تعیین می‌شود تا مسابقه غیرقابل پیش‌بینی باشد.

---

## 🛠️ پیش‌نیازها

برای اجرا و توسعه این پروژه به ابزارهای زیر نیاز دارید:
* **.NET SDK** (نسخه 6.0 یا بالاتر پیشنهاد می‌شود)
* یک IDE یا ادیتور مانند **Visual Studio** یا **VS Code**

---

## 🚀 نحوه اجرا

1. ابتدا پروژه را کلون کنید یا کدهای آن را دانلود کنید.
2. ترمینال یا Command Prompt را در پوشه اصلی پروژه باز کنید.
3. دستور زیر را برای اجرای برنامه وارد کنید:

```bash
dotnet run
.
.
.
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
