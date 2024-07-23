# Open/Closed Principle

## Good Design

In this example, we work with an abstract class ReportGenerator.cs that exposes a method to contain the report generation implementation. This way, we can create classes for each report type - following the Single Responsibility Principle - that inherit from our abstract class. Each subclass will have its own logic for how to generate the report.
