using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nanotek.Helpers
{
    public static class TaskHelper
    {
        public static void RunTasks<T>(List<Task<T>> tasks, bool runParallel)
        {
            if (runParallel)
            {
                Parallel.ForEach(tasks, task => task.Start());
                Task.WaitAll(tasks.ToArray());
            }
            else
            {
                foreach (var task in tasks)
                {
                    task.Start();
                    task.Wait();
                }
            }
        }

        public static async Task RunTasksAsync<T>(List<Task<T>> tasks, bool runParallel, CancellationToken cancellationToken)
        {
            if (runParallel)
            {
                Parallel.ForEach(tasks, task => task.Start());
                await Task.WhenAll(tasks.ToArray());
            }
            else
            {
                foreach (var task in tasks)
                {
                    task.Start();
                    await task.WaitAsync(cancellationToken);
                }
            }
        }
    }
}
