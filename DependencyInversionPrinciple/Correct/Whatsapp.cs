namespace DependencyInversionPrinciple.Correct
{
    public class Whatsapp : IMessageType
    {
        public void Send(string message)
        {
            // ... send message
        }
    }
}
