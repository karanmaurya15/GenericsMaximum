using System.Net.Http.Headers;

namespace GenericsMaximum
{
    public class MaxNumCheck
    {

        public static string MaxString(string firstString, string secondString, string thirdString)
        {
           

            if (firstString.Length.CompareTo(secondString.Length) > 0 && firstString.CompareTo(thirdString.Length) > 0)
            {
                return firstString;
            }
            if (secondString.Length.CompareTo(thirdString.Length) > 0 && secondString.Length.CompareTo(thirdString.Length) > 0)
            {
                return secondString;
            }
            if (thirdString.Length.CompareTo(firstString.Length) > 0 && thirdString.Length.CompareTo(secondString.Length) > 0)
            {
                return thirdString;
            }
            throw new Exception("firstword,secondword and thirdword are same length");
           
        }
        
    }
    
    internal class program
    { 
        static void Main(string[] args) 
        {

            Console.WriteLine("Wellcome to Generics Program\n");

            Console.WriteLine("Enter Three Strings to check : ");
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string thirdString = Console.ReadLine();
            string largest = MaxNumCheck.MaxString(firstString, secondString, thirdString);
            Console.WriteLine("The Largest String is : " + largest);


        }
    }
}