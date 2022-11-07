 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximum
{
    public class MaximumComputation<K> where K : IComparable
    {
        public K firstValue, secondvalue, thirdValue, fourthValue;
        public MaximumComputation(K firstValue, K secondValue, K thirdValue, K fourthValue)
        {
            this.firstValue = firstValue;
            this.secondvalue = secondValue;
            this.thirdValue = thirdValue;
            this.fourthValue = fourthValue;
        }

        public static K MaxNumber<K>(K firstValue, K secondValue, K thirdValue, K fourthValue) where K : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 && firstValue.CompareTo(fourthValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 && firstValue.CompareTo(fourthValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0 && firstValue.CompareTo(fourthValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 && firstValue.CompareTo(fourthValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(fourthValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(fourthValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(fourthValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(fourthValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(fourthValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(fourthValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(fourthValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(fourthValue) >= 0)
            {
                return thirdValue;
            }
            if (fourthValue.CompareTo(firstValue) > 0 && fourthValue.CompareTo(secondValue) > 0 && fourthValue.CompareTo(thirdValue) > 0 ||
                fourthValue.CompareTo(firstValue) >= 0 && fourthValue.CompareTo(secondValue) > 0 && fourthValue.CompareTo(thirdValue) > 0 ||
                fourthValue.CompareTo(firstValue) > 0 && fourthValue.CompareTo(secondValue) >= 0 && fourthValue.CompareTo(thirdValue) > 0 ||
                fourthValue.CompareTo(firstValue) > 0 && fourthValue.CompareTo(secondValue) > 0 && fourthValue.CompareTo(thirdValue) >= 0)
            {
                return fourthValue;
            }

            return firstValue;
        }
        public K MaxMethod()
        {
            K Max = MaximumComputation<K>.MaxNumber(this.firstValue, this.secondvalue, this.thirdValue, this.fourthValue);
            return Max;

        }
    }
}
