using System;
using System.Linq;

namespace AoC
{
    class Day7
    {
        public static void solution()
        {
            var input = System.IO.File.ReadAllText(@"C:\Users\marec\Desktop\AoC\input7.txt");
            int[] positions = Array.ConvertAll(input.Split(','), int.Parse);

            var lowestfuel = int.MaxValue;
            var distance = 0;

            for (var position = positions.Min(); position < positions.Max(); position++)
            {
                var fuel = 0;
                foreach (var crab in positions)
                {
                    distance = (Math.Abs(crab - position));
                    fuel += (distance * (distance + 1)) / 2;
                }
                if (fuel < lowestfuel) { lowestfuel = fuel; }
            }
            Console.WriteLine(lowestfuel);
        }
    }
}
