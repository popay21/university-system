using System;

namespace UniversitySystem.Models
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Person Sender { get; set; }
        public Person Receiver { get; set; }
        public bool IsFavorite { get; set; }
        public string Subject { get; set; }

    }
}
