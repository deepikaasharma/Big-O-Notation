using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O_Notation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void printFirstItem(int[] items)  // this method runs in O(1) time, this method requires just one step even if input is huge
        {
            Console.WriteLine(items[0]);
        }

        public void printAllItems(int[] items) // this method runs in O(n), Linear time where n is the number of items in the array
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void printAllPossibleOrderedPairs(int[] items) // this method runs in O(n^2) time, because we use two nested loops
        {
            foreach (var firstitem in items)
            {
                foreach (var seconditem in items)
                {
                    Console.WriteLine($"{firstitem}, {seconditem}");
                }
            }
        }
    }
}
