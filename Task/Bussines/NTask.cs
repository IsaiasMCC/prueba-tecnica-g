using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Bussines
{
    public class NTask
    {
        public NTask() 
        {
            Tasks = new List<TaskModel>();
        }
        public List<TaskModel> Tasks { get; set; }

        public void add(TaskModel task)
        {
            task.Id = Tasks.Count() + 1;
            Tasks.Add(task);
        }
        public void remove(int id)
        {
            int taskId = id - 1;
            if (Tasks.Count() > taskId)
            {
                Tasks.RemoveAt(taskId);
                sort();
            }
        }
        public void sort()
        {
            int index = 0;
            foreach (TaskModel task in Tasks)
            {
                index++;
                task.Id = index;
            }
        }

        public void changeCompreteTask(int id)
        {
            int taskId = id - 1;
            if (Tasks.Count() > taskId)
            {
                Tasks[taskId].State = true;
                sort();
            }
        }

        public List<TaskModel> getPendingTask()
        {
            return Tasks.Where( task => !(task.State)).ToList(); 
        }

        public List<TaskModel> getCompleteTask()
        {
            return Tasks.Where(task => (task.State)).ToList();
        }

        public TaskModel get(int id)
        {
            int taskId = id - 1;
            if (Tasks.Count() > taskId)
            {
                return Tasks.ElementAt(taskId);
            }
            return null;
        }
    }
}
