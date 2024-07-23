namespace DependencyInversionPrinciple.Correct
{
    public class Sms : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
