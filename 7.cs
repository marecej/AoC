using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC
{
    class Day7
    {
        public static void solution()
        {
            string input = System.IO.File.ReadAllText(@"C:\Users\marec\Desktop\AoC\input7.txt");
            int[] positions = Array.ConvertAll(input.Split(','), int.Parse);

            var lowestfuel = int.MaxValue;
            var distance = 0;

            for (var i = positions.Min(); i < positions.Max(); i++)
            {
                var fuel = 0;
                foreach (var position in positions)
                {
                    distance = (Math.Abs(position - i));
                    fuel += (distance * (distance + 1)) / 2;
                }
                if (fuel < lowestfuel) { lowestfuel = fuel; }
            }
            Console.WriteLine(lowestfuel);
        }
    }
}
