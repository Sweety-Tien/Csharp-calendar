using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public enum EventType
    {
        None,
        Activity,
        Work,
        Remind,
        Party,
        Other
    }
    public class TodoItem
    {
        public string Title { get; set; }
        public string Place { get; set; }
        public string Descripetion { get; set; }
        public DateTime Date { get; set; }
        public EventType Type { get; set; }

        public TodoItem() { }

        public TodoItem(string title,string place, string description, DateTime date, EventType eventType)
        {
            Title = title;
            Place = place;
            Descripetion = description;
            Date = date;
            Type = eventType;
        }
    }
}
