using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public static class ParrotFactory
    {
        public static IParrot GetParrot(ParrotTypeEnum type, int numberOfCoconuts, bool isNailed, double voltage)
        {
            return type switch
            {
                ParrotTypeEnum.EUROPEAN => new EuropeanParrot(),
                ParrotTypeEnum.AFRICAN => new AfricanParrot(numberOfCoconuts),
                ParrotTypeEnum.NORWEGIAN_BLUE => new NorwegianBlueParrot(isNailed, voltage),
                _ => throw new Exception("Should be unreachable"),
            };
        }
    }
}
