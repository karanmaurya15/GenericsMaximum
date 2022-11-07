using System.Net.Http.Headers;

namespace GenericsMaximum
{
   
    internal class program
    { 
        static void Main(string[] args) 
        {
           
            Console.WriteLine("Wellcome to Generics Program\n");
            MaximumComputation<int> maximumInt = new MaximumComputation<int>(56, 245, 45);
            Console.WriteLine("Maximum Number is : " + maximumInt.MaxMethod());
            MaximumComputation<float> maximumFloat = new MaximumComputation<float>(17.9f, 20.6f, 309.5f);
            Console.WriteLine("Maximum Number is : " + maximumFloat.MaxMethod());
            MaximumComputation<string> maximumString = new MaximumComputation<string>("Apple", "AA", "Data");
            Console.WriteLine("Maximum Number is : " + maximumString.MaxMethod());



        }
    }
}