# Dependency Inversion Principle

## Good Design 

In the example code, we want to use a mechanism to send messages via Email, SMS, or WhatsApp.

The problem was solved by creating an `IMessageType.cs` type that serves as the foundation for all notification delivery methods. 
This ensures that our application is divided into interfaces that characterize existing and new delivery methods, opening the code for extensions.
Following this approach, the notification mechanism decides which delivery strategy to use. 
The notification service, in turn, is created already knowing which delivery method should be used and can send the notification without needing different implementations for delivery.
Thus, the notification service only needs to know which strategy to use to proceed with sending the message. 
t does not depend on how Email or SMS works, allowing any other message delivery method to be added to the project and still use the same service.