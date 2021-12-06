using System;

namespace AoC
{
    class Day5
    {
        public static void solution()
        {
            int[,] matrix = new int[1000, 1000];
            string input = System.IO.File.ReadAllText(@"C:\Users\marec\Desktop\AoC\input5.txt");

            var InputArray = input.Split("\n");

            foreach (string str in InputArray)
            {
                string tmp;
                tmp = str.Replace(" -> ", ",");

                var arr = tmp.Split(',');

                int x1 = Convert.ToInt32(arr[0]);
                int y1 = Convert.ToInt32(arr[1]);
                int x2 = Convert.ToInt32(arr[2]);
                int y2 = Convert.ToInt32(arr[3]);

                var length = Math.Sqrt((Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2)));

                int xdirection = Math.Sign(x2.CompareTo(x1));
                int ydirection = Math.Sign(y2.CompareTo(y1));

                if (x1 == x2)
                {

                    for (int i = y1; i != (y1 + (ydirection * (length + 1))); i = i + ydirection)
                    {
                        matrix[x1, i] += 1;
                    }
                }

                else if (y1 == y2)
                {

                    for (int i = x1; i != (x1 + (xdirection * (length + 1))); i = i + xdirection)
                    {
                        matrix[i, y1] += 1;
                    }
                }
                else
                {
                    int x = x1;
                    int y = y1;
                    for (int i = 0; i <= (xdirection * (x2 - x1)); i++)
                    {
                        matrix[x, y] += 1;
                        x += xdirection;
                        y += ydirection;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (matrix[i, j] > 1) { count++; }
                }
            }
            Console.WriteLine(count);
        }
    }
}
