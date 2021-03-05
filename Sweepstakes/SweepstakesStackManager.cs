using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepStack;
        public string name;

        public SweepstakesStackManager(string name)
        {
            sweepStack = new Stack<Sweepstakes>();
            this.name = name;
            
            

        }
        //methods
      

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepStack.Push(sweepstake);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstake = sweepStack.Pop();
            return sweepstake;
        }



        //Push()

        //Pop()
        //FIFO


    }
}
