
//bad code
public class InvitationSender
{
    UserNameService _userNameService;
    EmailValidator _emailValidator;

    public InvitationSender()
    {
        _userNameService = new UserNameService();
        _emailValidator = new EmailValidator();
    }
    public void SendInvite(string email, string firstName, string lastName)
    {
        _userNameService.Validate(firstName, lastName);
        _emailValidator.Validate(email);
        SmtpClient client = new SmtpClient();
        client.Send(new MailMessage("sitename@invites2you.com", email) { Subject = "Please join me at my party!" });
    }
}

//good code
public class InvitationSender
{
    UserNameService _userNameService;
    EmailValidator _emailValidator;

    public InvitationSender(UserNameService userNameService, EmailValidator emailValidator)
    {
        _userNameService = userNameService;
        _emailValidator = emailValidator;
    }
    public void SendInvite(string email, string firstName, string lastName)
    {
        _userNameService.Validate(firstName, lastName);
        _emailValidator.Validate(email);
        SmtpClient client = new SmtpClient();
        client.Send(new MailMessage("sitename@invites2you.com", email) { Subject = "Please join me at my party!" });
    }
}



