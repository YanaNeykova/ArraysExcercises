using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] array2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int lengthLeft = 0;
            int lenghtRight = 0;

            int minLength = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < minLength ; i++)
            {
                if (array1[i]==array2[i])
                {
                    lengthLeft++;
                }
            }
            
            int difference = Math.Max(array1.Length, array2.Length) - minLength;

            for (int i = minLength - 1; i >= 0; i--)
            {
                if (array1.Length < array2.Length && array1[i] == array2[i + difference])
                {
                    lenghtRight++;
                }
                else if  (array1.Length >= array2.Length && array2[i] == array1[i + difference] ) 
                {
                    lenghtRight++;
                }
            }

            int result = Math.Max(lengthLeft, lenghtRight);
            Console.WriteLine(result);
           

        }
    }
}
