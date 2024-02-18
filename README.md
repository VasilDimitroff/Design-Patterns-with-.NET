# .NET-Design-Patterns

In the repository you will find some popular design patterns implemented with .NET technologies. The goal is to illustrate with simple examples how we can use these patterns.

### Abstract Factory

The abstract factory pattern is a design pattern that provides a way to create families of related objects without imposing their concrete classes, by encapsulating a group of individual factories that have a common theme without specifying their concrete classes.[1] According to this pattern, a client software component creates a concrete implementation of the abstract factory and then uses the generic interface of the factory to create the concrete objects that are part of the family.

The example is based on ASP.NET Core and it is implemented with .NET 8 so be sure that your configuration supports this version of the platform.

### Facade

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

The example is based on ASP.NET Core and .NET 8.

To use it you can send POST request with image in payload via Postman:

1. Start Postman
2. Enter the URL and select POST request
3. Add "Content-Type" header to request with value "multipart/form-data"
4. In Body select form-data. For "key" enter "imageFile" and for value select image from your PC
5. Send request when the app is started
