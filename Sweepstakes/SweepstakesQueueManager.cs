using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager
    {
        Stack<string> sweepStack;
        public string name;

        public SweepstakesQueueManager(string name)
        {
            sweepStack = new Stack<string>();
            this.name = name;
            
        }
        //methods

        //enqueue()add

        //Dequeue() remove
    }
}
