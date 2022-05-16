using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class BaseParrot : IParrot
    {
        public virtual double GetSpeed()
        {
            return 12.0;
        }
    }
}
