using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string input = @"forward 5
down 5
forward 8
up 3
down 8
forward 2";
            string[] lines = input.Split('\n');

            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;


            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineSplit = lines[i].Split(' ');
                //Console.WriteLine(lineSplit[1]);

                switch (lineSplit[0])
                {
                    case "forward":
                        horizontalPosition += int.Parse(lineSplit[1]);
                        depth += int.Parse(lineSplit[1]) * aim;
                        break;
                    case "down":
                        aim += int.Parse(lineSplit[1]); //1* depth += int.Parse(lineSplit[1]);
                        break;
                    case "up":
                        aim -= int.Parse(lineSplit[1]); //1* depth -= int.Parse(lineSplit[1]);
                        break;
                    default:
                        break;
                }

            }

            int result = depth * horizontalPosition;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
