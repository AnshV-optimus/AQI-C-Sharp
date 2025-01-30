using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public class AyncProgramming
    {
        public int cnt = 0;
        public async Task FetchData()
        {
            var Result = await GetData();
            Console.WriteLine("Data Fetched" + Result);
        }
        public async Task<string> GetData()
        {
            await Task.Delay(1000);
            cnt++;
            return $"Data fetched {cnt}";
        }
    }

    public class WhenAllExample
    {
        // Method to fetch data using async methods with method injection
        public async Task FetchData(AyncProgramming asyncProgramming)
        {
            // Create a list of tasks to fetch data concurrently
            var tasks = new List<Task<string>>
            {
                asyncProgramming.GetData(),
                asyncProgramming.GetData(),
                asyncProgramming.GetData()
            };

            // Wait for all tasks to complete
            var results = await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }

    public class WhenAnyExample
    {
        public async Task FetchData(AyncProgramming asyncProgramming)
        {
            List<Task<string>> TaskList = new List<Task<string>>
           {
               asyncProgramming.GetData(),
               asyncProgramming.GetData(),
               asyncProgramming.GetData()
           };
            var FristCompletedTask = await Task.WhenAny(TaskList);
            var Result = await FristCompletedTask;
            Console.WriteLine(Result);

            TaskList.Remove(FristCompletedTask);

            var Othertasks = await Task.WhenAll(TaskList);

            foreach(var task in Othertasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
