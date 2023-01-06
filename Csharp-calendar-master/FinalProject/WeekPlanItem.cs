using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public enum WeekOfDay
    {
        mon,
        tue,
        wed,
        thur,
        fri,
        sat,
        sun
    }
    public class WeekPlanItem
    {
        public string Task;
        public WeekOfDay Week;

        public WeekPlanItem(string task, WeekOfDay week)
        {
            Task = task;
            Week = week;
        }
    }
}
