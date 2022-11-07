using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximum
{
    public class MaximumComputation<K> where K : IComparable
    {
        public K firstValue, secondvalue, thirdValue;
        public MaximumComputation(K firstValue, K secondvalue, K thirdValue)
        {
            this.firstValue = firstValue;
            this.secondvalue = secondvalue;
            this.thirdValue = thirdValue;
        }

        public static K MaxNumber<K>(K firstValue, K secondvalue, K thirdValue) where K : IComparable
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
        public K MaxMethod()
        {
            K Max = MaximumComputation<K>.MaxNumber(this.firstValue, this.secondvalue, this.thirdValue);
            return Max;
        }
    }
}
