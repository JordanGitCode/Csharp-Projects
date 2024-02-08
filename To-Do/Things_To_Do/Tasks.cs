using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Things_To_Do
{
    public class Tasks : CollectionBase
    {

        public Tasks() { }

        public int Add(Task newTask)
        {
            if (newTask != null)
            {
                return base.List.Add(newTask);
            }
            return -1;
        }

        public void Remove(Task task)
        {
            if (task != null)
            {
                base.List.Remove(task);
            }
        }

        public int IndexOf(Task task)
        {
            if (task != null)
            {
                return base.List.IndexOf(task);
            }
            return -1;
        }

    }
}
