using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class AfricanParrot : BaseParrot
    {
        private readonly int _numberOfCoconuts;
        private const double LoadFactor = 9.0;

        public AfricanParrot(int numberOfCoconuts)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public override double GetSpeed()
        {
            return Math.Max(0, base.GetSpeed() - LoadFactor * _numberOfCoconuts);
        }
    }
}
