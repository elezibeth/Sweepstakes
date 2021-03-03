using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<string> sweepStack;
        public string name;

        public SweepstakesStackManager(string name)
        {
            sweepStack = new Stack<string>();
            this.name = name;
            

        }
        //methods

        //Push()

        //Pop()
        //FIFO


    }
}
