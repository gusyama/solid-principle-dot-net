namespace DependencyInversionPrinciple.Correct
{
    public class Notification
    {
        private IMessageType _messageType;

        public Notification(IMessageType messageType)
        {
            _messageType = messageType;
        }

        public void SendNotification(string message)
        {
            _messageType.Send(message);
        }
    }
}
