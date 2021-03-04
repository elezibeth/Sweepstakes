using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        
        Queue<Sweepstakes> sweepQueue;
        public string name;

        public SweepstakesQueueManager(string name)
        {
            sweepQueue = new Queue<Sweepstakes>();
               
            this.name = name;
            
        }

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepQueue.Enqueue(sweepstake);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = sweepQueue.Dequeue();
            return sweepstakes;
        }
        //methods

        //enqueue()add

        //Dequeue() remove
    }
}
