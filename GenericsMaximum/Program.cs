using System.Net.Http.Headers;

namespace GenericsMaximum
{
    public class MaxNumCheck
    {

        public static double MaxDoubleNumber(double firstNumber, double secondNumber, double thirdNumber)
        {
           

            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(thirdNumber) > 0 && secondNumber.CompareTo(firstNumber) > 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            throw new Exception("firstNumber,secondNumber and thirdnumber are same");
           
        }
        
    }
    
    internal class program
    { 
        static void Main(string[] args) 
        {

            Console.WriteLine("Wellcome to Generics Program");
            // float result = MaxNumCheck.MaxFloatNumber(5.5f,4.43f,2.67f );
            // Console.WriteLine(result);
            Console.WriteLine("Enter First number, Second number, Third number to check : ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            double result = MaxNumCheck.MaxDoubleNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("The Maximum Number is : " + result);

        }
    }
}