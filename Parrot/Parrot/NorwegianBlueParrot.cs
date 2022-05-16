using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class NorwegianBlueParrot : BaseParrot
    {
        private readonly bool _isNailed;
        private readonly double _voltage;

        public NorwegianBlueParrot(bool isNailed, double voltage)
        {
            _isNailed = isNailed;
            _voltage = voltage;
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : Math.Min(24.0, _voltage * base.GetSpeed());
        }
    }
}
