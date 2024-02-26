using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chatApp.Models
{
    public class Chat
    {
        public Chat()
        {
        }

        public Chat(Guid id, string chatName, bool isGroupChat, User[] users, User groupAdmin, Message latestMsg)
        {
            Id = id;
            ChatName = chatName;
            IsGroupChat = isGroupChat;
            Users = users;
            GroupAdmin = groupAdmin;
            LatestMsg = latestMsg;
        }


        [Key]
        public Guid Id { get; set; }
        public string ChatName { get; set; }
        public bool IsGroupChat{ get; set; } =false;
        public User[] Users{ get; set; }
        public User  GroupAdmin{ get; set; }
        public Message LatestMsg{ get; set; }
    }
}