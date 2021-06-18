using System;
using System.Linq;

namespace AoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
        }

        /// <summary>
        /// https://adventofcode.com/2015/day/1
        /// </summary>
        static void Day1()
        {
            var input = InputData.Get(1) as string;
            var apartment = new ApartmentInstruction(input);
            var result = apartment.CulculateFloor();

            Console.WriteLine(result);
        }
    }
}
