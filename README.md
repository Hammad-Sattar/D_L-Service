# D_L Service
## Adding Dependency Injection 
In the Bulky Razor project, three types of dependency injection are demonstrated: Transient, Scoped, and Singleton. Transient services are created each time they are requested, ensuring a new instance with each call. Scoped services are instantiated once per request, providing a consistent instance throughout the lifecycle of a single request. Singleton services are created once and shared across the entire application, maintaining a single instance for the application's duration. This setup allows for a clear understanding of how each DI lifetime affects service management and instance behavior in an ASP.NET Core application.


