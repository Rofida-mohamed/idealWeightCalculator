using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idealWeightCalculator
{
    public class IdealWeight
    {
        public int Height { get; set; }
        public char Gender { get; set; }
        public int GetIdealWeight()
        {
            switch (Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'w':
                    return (Height - 100) - ((Height - 100) / 6);
                default:
                    return 0;
            }
        }

    }
}

