using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathContainer
{
     class Program
    {

        // Mathod that process an integer array and rturns a string array
        static string[] ProcessArray(int[] numbers)
        {
            //string[] result = new string[3];
            //{"raju","hguh","hgi" }


            string[] result = new string[numbers.Length];

            for(int i = 0; i < numbers.Length; i++ )
            {
                if (numbers[i] %2 == 0 )
                {
                    result[i] = $"{numbers[i]} is Even Number";
                }
                else
                {
                    result[i] = $"{numbers[i]} is Add Number";
                }
            }
            // return string array
            return result;
        } 
        static void Main()
        {
            int[] numbers = { 15, 14 };
            string[] output = ProcessArray(numbers);

            foreach (string result in output )
            {
                Console.WriteLine(result);
            }




            //Console.WriteLine(output);
        }
    }
}
