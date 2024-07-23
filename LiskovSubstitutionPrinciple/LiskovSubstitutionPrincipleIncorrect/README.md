# Liskov Substitution Principle

## Bad Design

In this example, Square inherits from Rectangle, and it overrides setWidth and setHeight methods to maintain the invariant that width and height are always equal for a square. However, this violates LSP because Square changes the behavior of setWidth and setHeight methods in a way that doesn't conform to the expected behavior of Rectangle.

