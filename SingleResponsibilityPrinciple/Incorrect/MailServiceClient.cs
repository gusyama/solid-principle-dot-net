namespace SingleResponsibilityPrinciple.Incorrect
{
    public static class MailServiceClient
    {
        public static bool Send(MailMessage mail)
        {
            return true;
        }
    }
}