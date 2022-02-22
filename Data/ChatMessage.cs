using System;
namespace test2.Data
{
    public class ChatMessage
    {
        public long Id { get; set; }
        public long SitterRequestId { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

        public ChatMessage()
        {
        }
    }
}
