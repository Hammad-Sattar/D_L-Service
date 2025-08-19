
# ⚡ Dependency Injection Lifetimes in ASP.NET Core

This project demonstrates **Dependency Injection (DI) lifetimes** (`Transient`, `Scoped`, and `Singleton`) in an **ASP.NET Core MVC** application.  

---

## 🚀 Features
- Demonstrates **Scoped**, **Transient**, and **Singleton** services  
- Uses **ASP.NET Core MVC** structure (Controllers, Views, Models, Services)  
- Simple and clear code for learning DI lifetimes  
- Showcases how service instances behave differently across requests  

---

## 📂 Project Structure
Controllers/ # MVC Controllers

Models/ # Models for the project

Services/ # Services implementing DI lifetimes

Views/ # Razor Views

wwwroot/ # Static files

Program.cs # Application entry point (DI registration here)

appsettings.json # Configuration settings


---

## 🛠️ How It Works
In `Program.cs`, services are registered with different lifetimes:
```csharp
builder.Services.AddScoped<IScopedGuid, ScopedGuid>();
builder.Services.AddTransient<ITransientGuid, TransientGuid>();


Transient → New instance every time requested

Scoped → One instance per request

Singleton → Same instance for the entire application

Controllers request these services, and GUIDs are displayed to show how lifetimes differ.


Singleton → Same instance for the entire application
builder.Services.AddSingleton<ISingletonGuid, SingletonGuid>();
