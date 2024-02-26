

namespace chatApp.Models
{
    public class Message
    {
        public Message()
        {
        }

        public Message(User sender, string content, Chat chat, DateTime timeStamp)
        {
            Sender = sender;
            Content = content;
            Chat = chat;
            TimeStamp = timeStamp;
        }

        public User Sender { get; set; }
        public string Content { get; set; }
        public Chat Chat { get; set; }
        public DateTime TimeStamp { get; set; } =DateTime.UtcNow;
    }
}