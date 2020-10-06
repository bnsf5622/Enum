using System;
using System.Linq;

namespace Enum1
{
    public enum ProductCodes
    { 
    Milk = 0,
    juice = 1,
    Tea = 2,
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductCodes test = ProductCodes.Milk;
            Console.WriteLine((int)test);

            int test2 = 1;
            Console.WriteLine((ProductCodes)test2);


            Console.WriteLine(test.ToString());

            string test3 = "Tea";
            ProductCodes getParse;
            bool checkParse = Enum.TryParse(test3, out getParse);
            Console.WriteLine(getParse);
        }   
    }
}