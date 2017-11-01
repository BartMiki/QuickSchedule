using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSchedule
{
    public enum Priority : Byte { LOW, MEDIUM, HIGH};

    public class Task
    {
        public string Name { get; set; }
        public Priority Priority { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime Date { get; set; }

        public Task(string name, DateTime dt, TimeSpan ts, Priority pr)
        {
            Name = name;
            Date = dt;
            Duration = ts;
            Priority = pr;
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(Name + ": " + Date +",duration: " + Duration + ", priority: " + Priority);
            return result.ToString();
        }
    }
}
