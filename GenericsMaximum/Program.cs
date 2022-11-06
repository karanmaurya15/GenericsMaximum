using System.Net.Http.Headers;

namespace GenericsMaximum
{
    public class MaxNumCheck
    {
       
        public static int MaxIntNumber(int firstNumber, int secondNumber, int thirdNumber)
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
            int result = MaxNumCheck.MaxIntNumber(55,43,23);
            Console.WriteLine(result);
         

        }
    }
}