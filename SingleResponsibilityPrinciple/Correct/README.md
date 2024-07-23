# Single Responsibility Principle

## Good Design

In this example we applythe Single Responsibility Principle, hence each class has its own job:
- UserService.cs - deals with user work
- DbContext - deals with inserting the user context
- MailService - deals with the mail tasks (validation, sending mail)
- MailClient - implementation of sending the mail
- MailMessage - defines user mail message object
- User - defines user object
