namespace ArmSclad.UI.Common
{
    public class TaskManager
    {
        private static Task _currentTask;
        private static Queue<Task> _queue = new Queue<Task>();

        private static event EventHandler<Task> _taskCreated;

        static TaskManager()
        {
            _taskCreated += TaskManager_taskCreatedAsync;
        }


        private static async void TaskManager_taskCreatedAsync(object? sender, Task e)
        {
            while (_queue.Count > 0)
            {
                if (_currentTask == null)
                    await StartTask();
            }
        }

        private static async Task StartTask()
        {
            _currentTask = _queue.Dequeue();
            _currentTask.Start();
            await _currentTask;
            _currentTask = null;
        }

        public static void AddTask(Action action)
        {
            Task task = new Task(action);
            _queue.Enqueue(task);
            if (_currentTask == null)
            {
                _taskCreated?.Invoke(null, task);
            }
        }

        public static void WaitAllTask()
        {
            while (_queue.Count > 0)
            {
            }
        }
    }
}
