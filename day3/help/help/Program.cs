using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"00100
11110
10110
10111
10101
01111
00111
11100
10000
11001
00010
01010";

            string[] lines = input.Split('\n');

            string result = "";

            for (int j = 0; j < 5; j++)
            {
                int zeros = 0;
                int ones = 0;

                for (int i = 0; i < lines.Length; i++)
                {

                    char[] line = lines[i].ToCharArray();

                    if (line[j] == '0')
                    {
                        zeros++;
                    }
                    else
                    {
                        ones++;
                    }


                }

                if (zeros > ones)
                {
                    result += "0";
                }
                else
                {
                    result += "1";
                }
            }

            Console.WriteLine(result);

            string reversedResult = "";

            for (int i = 0; i < result.Length; i++)
            {
                if (result.ToCharArray()[i] == '0')
                {
                    reversedResult += "1";
                }
                else
                {
                    reversedResult += "0";
                }
            }

            Console.WriteLine(reversedResult);

            int resultToDecimal = Convert.ToInt32(result, 2); //https://stackoverflow.com/questions/1961599/how-to-convert-binary-to-decimal
            int reversedResultToDecimal = Convert.ToInt32(reversedResult, 2);

            Console.WriteLine(resultToDecimal * reversedResultToDecimal);
            


            Console.ReadLine();
        }
    }
}
