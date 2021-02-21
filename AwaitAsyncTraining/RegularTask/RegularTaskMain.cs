using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AwaitAsyncTraining
{
    class RegularTaskMain
    {
        public void Execute()
        {
            var regularTask1 = new RegularTask1();
            var regularTask2 = new RegularTask2();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            regularTask1.Foo();
            regularTask2.Foo();
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time for regular tasks: {stopwatch.ElapsedMilliseconds}");
            Debug.Assert(stopwatch.ElapsedMilliseconds < 3000);
        }
    }
}
