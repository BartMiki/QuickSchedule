using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSchedule
{
    public class Scheduler
    {
        private HashSet<Task> tasks;

        public Scheduler()
        {
            tasks = new HashSet<Task>();
        }

        public bool AddTask(Task task)
        {
            return tasks.Add(task);
        }

        public bool RemoveTask(Task task)
        {
            return tasks.Remove(task);
        }

        public List<Task> TasksToList()
        {
            return tasks.ToList();
        }

        public List<Task> TasksToList(Comparison<Task> comparer)
        {
            var list = tasks.ToList();
            list.Sort(comparer);
            return list;
        }
    }
}
