using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AwaitAsyncTraining
{
    class AsyncTaskMain
    {
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            var asyncTask1 = new AsyncTask1();
            var asyncTask2 = new AsyncTask2();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await asyncTask1.FooAsync();
            await asyncTask2.FooAsync();
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time for regular tasks: {stopwatch.ElapsedMilliseconds}");
            Debug.Assert(stopwatch.ElapsedMilliseconds < 3000);
        }
    }
}
