﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsyncTraining
{
    class AsyncSubtask1
    {
        public Task Foo()
        {
            return Task.Delay(1000);
        }
    }
}
