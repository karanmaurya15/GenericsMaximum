using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximum
{
    internal class MaximumComputation
    {
        public K MaxNumber<K>(K firstValue, K secondvalue, K thirdValue) where K : IComparable
        {
            if (firstValue.CompareTo(secondvalue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondvalue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondvalue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondvalue.CompareTo(firstValue) > 0 && secondvalue.CompareTo(thirdValue) > 0 ||
                secondvalue.CompareTo(firstValue) >= 0 && secondvalue.CompareTo(thirdValue) > 0 ||
                secondvalue.CompareTo(firstValue) > 0 && secondvalue.CompareTo(thirdValue) >= 0)
            {
                return secondvalue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondvalue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondvalue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondvalue) >= 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
