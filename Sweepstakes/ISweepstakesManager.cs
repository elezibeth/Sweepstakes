using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
     public interface ISweepstakesManager

    {
        
        void InsertSweepstakes(Sweepstakes sweepstake);

        Sweepstakes GetSweepstakes();
        
    }
}
//(10 points) As a developer, I want to write an ISweepstakesManager interface with the following
//methods for a sweepstakes management system:
//-void InsertSweepstakes(Sweepstakes sweepstakes)
//- Sweepstakes GetSweepstakes()