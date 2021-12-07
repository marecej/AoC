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
            var InputArray = input.Split(",");

            List<int> positions = new List<int>();
            foreach (string str in InputArray)
            {
                positions.Add(Convert.ToInt32(str));

            }

            var lowestfuel = 9999999999;
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
