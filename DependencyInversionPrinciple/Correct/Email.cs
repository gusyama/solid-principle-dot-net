namespace DependencyInversionPrinciple.Correct
{
    public class Email : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
