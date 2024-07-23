# Liskov Substitution Principle

The Liskov Substitution Principle (LSP) is one of the five SOLID principles of object-oriented design, named after Barbara Liskov, who introduced it in 1987. It defines a set of guidelines that a class must follow for it to be considered a valid subtype of a base class, ensuring that objects of a derived class can be used in place of objects of the base class without affecting the correctness of the program.

## Key Concepts

### Behavioral Subtyping
Subtypes must be substitutable for their base types without altering the correctness of the program. This means that the subtype should honor the contract established by the base type.

### Invariant Preservation
Subtypes should not strengthen preconditions of methods (i.e., they cannot require more than their base class requires) and should not weaken postconditions of methods (i.e., they must fulfill the promises made by the base class methods).

## Practical Guidelines

### Method Signatures
The overridden methods in the derived class (subtype) should have the same method signatures as the methods in the base class (supertype). This includes the same input parameters and return types.

### Behavioral Consistency
The behavior of the derived class methods should adhere to the expectations set by the base class methods. This ensures that clients using objects of the base class can work seamlessly with objects of the derived class.