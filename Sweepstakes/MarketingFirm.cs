using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {

        //members
        public string name;
        List<Contestant> contestants;

        //ctr
        public MarketingFirm(string name)
        {
            contestants = new List<Contestant>();
            this.name = name;

        }


        //methods

        public Sweepstakes CreateASweepstakes(ISweepstakesManager manager)//add note here about dependency injection
        {
            Sweepstakes sweepstakes =  GetSweepstakes(stack);
            return sweepstakes;
        }
        public void AddContestant()
        {
            contestants.Add(Contestant contestant);
        }
    }
}
