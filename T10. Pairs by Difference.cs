using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_PairsByDifference

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairs = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int temporary = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    int newTemporary = array[j];
                    if (newTemporary - temporary == difference)
                    {
                        pairs++;
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
