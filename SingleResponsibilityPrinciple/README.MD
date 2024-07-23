# Single Responsibility Principle

The Single Responsibility Principle (SRP) is one of the five principles of SOLID, a set of object-oriented design principles that aim to make software designs more understandable, flexible, and maintainable. 

Each letter in SOLID stands for one of these principles, and SRP specifically addresses the idea that:

"A class should have only one reason to change."

## Key Points
### Single Purpose
According to SRP, a class or module should have a single responsibility or reason to change. This means that it should encapsulate one and only one aspect of functionality within the software system.

### Separation of Concerns
By adhering to SRP, you ensure that each class is focused on doing one thing well. This not only makes the class easier to understand but also reduces the likelihood of unintended side effects when modifications are made.

### Encapsulation
SRP promotes encapsulation, which is the bundling of data (attributes) and methods (behavior) that operate on the data within a single unit (class). When a class adheres to SRP, changes to its functionality are localized and do not affect unrelated parts of the system.

## Benefits
### Code Readability
Classes with single responsibilities are easier to read and understand because they are focused on specific tasks.
### Ease of Maintenance
When a change is required, you only need to modify the relevant class, minimizing the risk of introducing bugs elsewhere.
### Reusability
Classes with a single responsibility are often more reusable in different contexts, as their functionality is well-defined and specific.

## Explaining the Example
In the example code, we need to insert a user into the database. Our user has a name and an email. Therefore, we want to:
- Validate their email;
- Insert the record into the database;
- Send a welcome email.