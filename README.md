# **Overview**

Software design patterns are essential programming paradigms that outline reusable solutions for common design problems. These patterns are not mere algorithms or code snippets but are sophisticated templates that can be adapted to different situations in software development. While they don't replace fundamental software design principles, they serve as a solid foundation for structuring and organizing code. Moreover, design patterns are an effective means of documenting design decisions and communicating design strategies among developers.

The **Abstract Factory design pattern** is highlighted in this project. The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is particularly useful when the system needs to be independent of how its objects are created, composed, or represented. By using the Abstract Factory, the code becomes more flexible and can easily switch between different families of products, making the design more scalable and maintainable.

**Real-world applications** of the Abstract Factory pattern include scenarios where a system must be configured with one of multiple families of products, and the exact types of products are not known until runtime. The Abstract Factory pattern is commonly used in:

- **GUI Toolkits:** To create consistent interfaces for different platforms.
- **Database Libraries:** To provide interfaces for different types of databases (e.g., SQL, NoSQL) without altering the client code.
- **Cross-Platform Development:** To ensure that an application can run on multiple platforms with different implementations.

# **Design**

This project demonstrates the Abstract Factory pattern by defining a vehicle creation system that allows the creation of related objects (e.g., Car, Bike) without specifying their concrete classes. The `VehicleFactory` serves as the Abstract Factory, while `CarFactory` and `BikeFactory` act as Concrete Factories. These factories create the `Car` and `Bike` products, respectively. The `VehicleWorld` class, functioning as the client, interacts with these factories to produce and operate vehicles without needing to know their specific implementations.

As an example, the `VehicleWorld` class can be configured to create and drive either a `Car` or a `Bike` by simply switching the factory it uses, demonstrating the flexibility and extensibility of the Abstract Factory pattern.

# **Module & Class Diagram**
The **Class Diagram** provides a detailed view of the classes involved, their attributes, methods, and how they relate to each other, particularly focusing on the abstract factory structure.

<img src = './class diagram.png'>

# **Environment**

This project is developed and tested using **Visual Studio Community 2022**. Ensure that the necessary workloads, such as .NET desktop development, are installed for a smooth build and run experience.

# **Coverage Report**
<img width="1088" alt="Screenshot 2024-09-01 at 12 27 22 AM" src="https://github.com/user-attachments/assets/8764c28e-d023-4f79-b09e-391233cd457c">

[More Details](https://dshreddy.github.io/abstract-factory-pattern-demo/)

# References 
[README](https://github.com/chittur/observer-pattern-demo)
[Abstract Factory Pattern](https://www.dofactory.com/net/abstract-factory-design-pattern)
[UML Diagram Maker](https://plantuml.com/)
[Test Coverage Report Generator](https://reportgenerator.io/getstarted)
