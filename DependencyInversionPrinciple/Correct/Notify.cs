namespace DependencyInversionPrinciple.Correct
{
    public class Notify
    {
        public void NotifyMessage(string message, EnumMessageType type)
        {
            Notification notification = new Notification(type);
            notification.SendNotification(message);
        }

    }
}
