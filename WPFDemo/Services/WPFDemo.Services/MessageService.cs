using WPFDemo.Services.Interfaces;

namespace WPFDemo.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
