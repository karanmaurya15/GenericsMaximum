using System.Net.Http.Headers;

namespace GenericsMaximum
{
   
    internal class program
    { 
        static void Main(string[] args) 
        {
            MaximumComputation maximumComputation = new MaximumComputation();
            Console.WriteLine("Wellcome to Generics Program\n");

            Console.WriteLine("Maximum Interger Number is : " + maximumComputation.MaxNumber<int>(56, 78, 67));
            Console.WriteLine("Maximum Float Number is : " + maximumComputation.MaxNumber<float>(56.8f, 20.8f, 12.9f));
            Console.WriteLine("Maximum String  is : " + maximumComputation.MaxNumber<string>("Input", "Value", "Data"));


        }
    }
}