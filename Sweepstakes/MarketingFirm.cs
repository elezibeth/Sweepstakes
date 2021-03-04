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

        //ctr
        public MarketingFirm(string name)
        {
            this.name = name;

        }


        //methods

        public Sweepstakes CreateASweepstakes(ISweepstakesManager manager)//add note here about dependency injection
        {
            Sweepstakes sweepstakes =  GetSweepstakes(stack);
            return sweepstakes;
        }
    }
}
