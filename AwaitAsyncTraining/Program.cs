using System;

namespace AwaitAsyncTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            new RegularTaskMain().Execute();
            new AsyncTaskMain().ExecuteAsync().Wait();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
