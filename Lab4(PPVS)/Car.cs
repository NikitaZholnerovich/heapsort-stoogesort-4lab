using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab4_PPVS_
{
    public class Car : IComparable, IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public int CompareTo([AllowNull] Car other)
        {
            if (Speed > other.Speed)
            {
                return 1;
            }
            if (Speed < other.Speed)
            {
                return -1;
            }
            return 0;

        }

        public int CompareTo(object obj)
        {
            return CompareTo((Car)obj);
        }

        public override string ToString()
        {
            return $"[{Name}, {Speed} km/h]";
        }
    }
}
