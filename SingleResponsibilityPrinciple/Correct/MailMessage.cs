namespace SingleResponsibilityPrinciple.Correct
{
    public class MailMessage
    {
        public MailMessage(string email, string message)
        {
            Email = email;
            Message = message;
        }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}