using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsyncTraining
{
    class RegularTask2
    {
        public void Foo()
        {
            var t1 = new RegularSubtask1().Foo();
            var t2 = new RegularSubtask2().Foo();
            var t3 = Task.Delay(1000);
            Task.WaitAll(t1, t2, t3);
        }
    }
}
