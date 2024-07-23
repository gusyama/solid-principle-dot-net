# SOLID Principles

The SOLID principles are a set of five design guidelines that aim to make software designs more understandable, flexible, and maintainable. 
They help developers create code that is easier to manage and extend over time by promoting good practices like modularity, separation of concerns, and reducing dependencies. 
The principles encourage writing clean code that is easier to test and less prone to bugs, ultimately leading to more robust and scalable software systems.

## Single Responsibility Principle (SRP)
A class should have only one reason to change, meaning it should have only one job or responsibility.

## Open/Closed Principle (OCP)
Software entities should be open for extension but closed for modification. This means you can extend a class's behavior without modifying its existing code.

## Liskov Substitution Principle (LSP)
Subtypes must be substitutable for their base types without altering the correctness of the program. Derived classes should extend base classes without changing their behavior.

## Interface Segregation Principle (ISP)
Clients should not be forced to depend on interfaces they do not use. This encourages creating more specific interfaces rather than one general-purpose interface.

## Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions. This promotes decoupling of software components.
