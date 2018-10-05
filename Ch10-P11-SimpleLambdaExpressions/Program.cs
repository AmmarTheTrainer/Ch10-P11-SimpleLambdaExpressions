using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_P11_SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();

            //numbersList.fin

            TraditionalDelegateSyntax();
            Console.ReadLine();
        }

        private static void TraditionalDelegateSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //// Call FindAll() using traditional delegate syntax.
            //Predicate<int> callback = IsEvenNumber;
            //List<int> evenNumbers = list.FindAll(callback);

            ///// use anonymous methods
            //List<int> evenNumbers = list.FindAll(delegate(int i)
            //{
            //    return (i % 2) == 0;
            //});

            // now use C# lambda expression
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        private static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }
    }
}
