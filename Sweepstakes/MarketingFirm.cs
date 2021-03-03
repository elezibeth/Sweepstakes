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

        //ctr
        public MarketingFirm()
        {

        }


        //methods

        public Sweepstakes CreateASweepstakes(ISweepstakesManager manager)//add note here about dependency injection
        {
            Sweepstakes sweepstakes = GetSweepstakes(stack);
            return sweepstakes;
        }
    }
}
