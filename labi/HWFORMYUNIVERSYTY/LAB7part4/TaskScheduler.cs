namespace LAB7part4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public delegate void TaskExecution<TTask>(TTask task);

    public class TaskScheduler<TTask, TPriority>
    {
        private SortedDictionary<TPriority, Queue<TTask>> taskQueue = new SortedDictionary<TPriority, Queue<TTask>>();
        private TaskExecution<TTask> taskExecutionDelegate;

        public TaskScheduler(TaskExecution<TTask> taskExecutionDelegate)
        {
            this.taskExecutionDelegate = taskExecutionDelegate ?? throw new ArgumentNullException(nameof(taskExecutionDelegate));
        }

        public void AddTask(TTask task, TPriority priority)
        {
            if (!taskQueue.ContainsKey(priority))
            {
                taskQueue[priority] = new Queue<TTask>();
            }

            taskQueue[priority].Enqueue(task);
        }

        public void ExecuteNext()
        {
            if (taskQueue.Count > 0)
            {
                var highestPriority = taskQueue.Keys.Max();
                var nextTask = taskQueue[highestPriority].Dequeue();

                taskExecutionDelegate(nextTask);

                if (taskQueue[highestPriority].Count == 0)
                {
                    taskQueue.Remove(highestPriority);
                }
            }
            else
            {
                Console.WriteLine("No tasks to execute.");
            }
        }

        public IEnumerable<TTask> GetTasks()
        {
            foreach (var priority in taskQueue.Keys)
            {
                foreach (var task in taskQueue[priority])
                {
                    yield return task;
                }
            }
        }

        public void ReturnToPool(TTask task, TPriority priority)
        {
            if (!taskQueue.ContainsKey(priority))
            {
                taskQueue[priority] = new Queue<TTask>();
            }

            taskQueue[priority].Enqueue(task);
        }
    }
}