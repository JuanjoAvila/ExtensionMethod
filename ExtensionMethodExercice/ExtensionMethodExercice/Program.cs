using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Result());
            Console.Read();

            bool Result()
            {
                String hello = "Hello World";
                bool result = hello.TotalWordsGreaterThan(10);
                return result;
            }


        }
    }
}
