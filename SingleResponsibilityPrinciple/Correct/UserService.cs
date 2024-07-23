using System.Activities;

namespace SingleResponsibilityPrinciple.Correct
{
    public class UserService
    {
        private MailService _mailServiceClient;
        private DbContext _dbContext;

        public UserService(MailService mailClient, DbContext dbContext)
        {
            _mailServiceClient = mailClient;
            _dbContext = dbContext;
        }

        public User RegisterUser(string name, string email)
        {
            if (!_mailServiceClient.ValidateEmail(email))
                throw new ValidationException($"{nameof(email)} is not a valid email address.");

            var user = new User(name, email);

            var response = _dbContext.Insert(user);

            if (response)
                _mailServiceClient.SendMail(new MailMessage(user.Email, $"Welcome, ${user.Name}"));

            return user;
        }
    }
}
