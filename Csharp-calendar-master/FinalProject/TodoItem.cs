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
        public string Title;
        public string Place;
        public string Descripetion;
        public DateTime Date;
        public EventType Type;

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
