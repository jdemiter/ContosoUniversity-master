
namespace ContosoUniversity.Services
{ 
    //public class AuthMessageSender : IEmailSender, ISmsSender
 
//{
//    public AuthMessageSenderOptions Options { get; }
//    public AuthMessageSender(Ioptions<AuthMessageSenderOptions> optionsAccessor)
//    {
//        Options = optionsAccessor.value;
//    }
//}

public class AuthMessageSenderOptions
{
    public string SendGridUser { get; set; }
    public string SendGridKey { get; set; }
}
}
  