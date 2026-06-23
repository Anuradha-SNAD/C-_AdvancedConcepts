using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class AsyncProgram
    {
        public static async Task Demo()
        {
            Console.WriteLine("1");
            await Task.Delay(2000);
            
            Console.WriteLine("2");
        }
        public static async Task Main()
        {
            Console.WriteLine("Before");
            await Demo();

            Console.WriteLine("After");
        }

        public static void Run()
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Task Started...");
                Thread.Sleep(3000);
                Console.WriteLine("Task Finished...");

            });
            Console.WriteLine("Main Method..!!");
            task.Wait();
        }
    }
}
