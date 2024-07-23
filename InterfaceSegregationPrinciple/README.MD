# Interface Segregation Principle

The Interface Segregation Principle (ISP) is one of the five principles of SOLID, a set of object-oriented design principles that promote building software systems that are easy to maintain and extend over time. 
Each letter in SOLID represents a different principle, and ISP specifically focuses on the idea that:

"Clients should not be forced to depend on interfaces they do not use."

## Key Points

### Interface Cohesion
ISP emphasizes that interfaces should be specific to the needs of the clients that use them. Instead of having large, monolithic interfaces that cater to multiple clients with different needs, interfaces should be tailored to the requirements of each client.

### Avoiding Fat Interfaces
A "fat" interface is one that contains more methods than a client needs. Clients that only need a subset of these methods still have to implement or depend on the entire interface, leading to unnecessary complexity and potential implementation of dummy methods.

### Client-Specific Interfaces
By breaking down interfaces into smaller, more cohesive ones, ISP encourages creating multiple interfaces that cater to specific clients or groups of clients. This way, each client only depends on the subset of methods it requires, reducing coupling and making the system more flexible to changes.

## Benefits

### Reduced Dependencies
Clients depend only on the interfaces that are relevant to them, reducing the impact of changes in unrelated parts of the system.
### Improved Maintainability
Smaller, focused interfaces are easier to understand, implement, and maintain.
### Enhanced Flexibility
The system becomes more flexible as interfaces can evolve independently without affecting unrelated clients.