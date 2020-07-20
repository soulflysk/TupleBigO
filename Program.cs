using System;

namespace TupleBigO
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<Nullable<int>>[] values =
                    { new Tuple<Nullable<int>>(78),
                      new Tuple<Nullable<int>>(92),
                      new Tuple<Nullable<int>>(88),
                      new Tuple<Nullable<int>>(91),
                      new Tuple<Nullable<int>>(null),
                      new Tuple<Nullable<int>>(82),
                      new Tuple<Nullable<int>>(99),
                      new Tuple<Nullable<int>>(84) };
            int secondMax;
            double Max = GetMaxTwo(values, out secondMax);
            Console.WriteLine("Max = {0}, Second max = {1})", Max, secondMax);
        }
        private static double GetMaxTwo(Tuple<Nullable<int>>[] values, out int secondMax)
        {
            int max = 0;
            secondMax = 0;
            foreach (var value in values)
            {
                if (value.Item1.HasValue)
                {
                    //หาค่ามากสุดกับรองมากสุดใน array

                    if (value.Item1.Value > max)
                    {
                        secondMax = max;
                        max = value.Item1.Value;
                        
                    }

                    else if(value.Item1.Value > secondMax)
                        secondMax = value.Item1.Value;
                }
            }
            return max;
        }
    }
}
