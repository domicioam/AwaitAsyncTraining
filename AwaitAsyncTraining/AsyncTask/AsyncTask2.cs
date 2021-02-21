using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsyncTraining
{
    class AsyncTask2
    {
        public async Task FooAsync()
        {
            await new AsyncSubtask1().Foo();
            await new AsyncSubtask2().Foo();
            await Task.Delay(1000);
        }
    }
}
