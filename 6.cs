using System;
using System.Collections.Generic;

namespace AoC
{
    class Day6
    {
        public static void solution()
        {
            string input = System.IO.File.ReadAllText(@"C:\Users\marec\Desktop\AoC\input6.txt");
            var InputArray = input.Split(",");

            List<int> fish = new List<int>();
            double[] count = new double[10];
            foreach (string str in InputArray)
            {
                fish.Add(Convert.ToInt32(str));
            }
            for (int i = 0; i < fish.Count; i++)
            {
                count[fish[i]]++;
            }

            for (int days = 1; days <= 256; days++)
            {
                Console.WriteLine("after Day " + days);

                for (int i = 0; i < 9; i++)
                {
                    count[i] = count[i + 1];
                }
                count[7] += count[0];
                count[9] = count[0];
                double sum = 0;
                for (int i = 1; i < 9; i++)
                {
                    sum += count[i];
                }
                Console.WriteLine(sum);

            }

        }
    }
}
