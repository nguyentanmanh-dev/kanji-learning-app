using System;
using System.Collections.Generic;
using System.Text;

namespace KanjiConsoleApp.Models
{
    public abstract class LearningItem
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        protected LearningItem()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }
        public abstract void Display();
    }
}
