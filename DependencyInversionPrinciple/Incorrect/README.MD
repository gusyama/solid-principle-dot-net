# Dependency Inversion Principle

## Bad Design

In the example code, we want to use a mechanism to send messages via Email, SMS, or WhatsApp.

In the incorrect way, the notification methods are implemented within the notification service, which depends entirely on knowing what the delivery methods are to handle each independently. 
This is terrible for code maintainability and evolution because the notification module and the delivery methods are tightly coupled.