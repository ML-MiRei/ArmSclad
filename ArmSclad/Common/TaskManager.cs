namespace ArmSclad.UI.Common
{
    public class TaskManager
    {
        private static List<Task> _tasks = new List<Task>();

        public static void AddTask(Action action)
        {
            Task task = new Task(action);
            task.Start();
            _tasks.Add(task);
        }

        public static void WaitAllTask()
        {
            Task.WaitAll(_tasks.ToArray());
        }
    }
}
