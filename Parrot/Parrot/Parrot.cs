using System;

namespace Parrot
{
    public class Parrot
    {
        private readonly bool _isNailed;
        private readonly int _numberOfCoconuts;
        private readonly ParrotTypeEnum _type;
        private readonly double _voltage;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public double GetSpeed()
        {
            var parrot = ParrotFactory.GetParrot(_type, _numberOfCoconuts, _isNailed, _voltage);

            return parrot.GetSpeed();
        }
    }
}