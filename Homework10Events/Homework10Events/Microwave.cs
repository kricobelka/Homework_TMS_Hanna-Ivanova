using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10Events
{
    delegate void NotifyWarmUpCompleted(string dishBeingWarmedUp);
    internal class Microwave
    {
       public event NotifyWarmUpCompleted WarmUpCompleted;

        public void WarmUp(string dishBeingWarmedUp)
        {
            Console.WriteLine($"Warming up {dishBeingWarmedUp}");

           if  (WarmUpCompleted != null)
            {
                // callin out event:
               WarmUpCompleted ($"{dishBeingWarmedUp} has been warmed up!");
            }

           // second way fo calling out event:
            //WarmUpCompleted?.Invoke($"{dishBeingWarmedUp} has been warmed up!");
        }
    }
}
