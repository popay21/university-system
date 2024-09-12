using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UniversitySystem.Models
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public List<Message> Messages { get; set; }
        public DateTime LastLoginDate { get; set; }
        public List<Message> GetRecentMessages(int count)
        {
            return Messages
                .OrderByDescending(m => m.Date)
                .Take(count)
                .ToList();
        }

        public Person()
        {
            Messages = new List<Message>();
        }
    }
}
