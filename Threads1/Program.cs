using System;
using System.Collections.Generic;
using System.Threading;

namespace Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = 0;
            var incomingValues = GetIncomingValues();
            var outgoingValues = GetOutgoingValues();
            var lockObject = new object();
            var thread = new Thread(() =>
            {
                foreach (var value in incomingValues)
                {
                    // Let's suppose that there is a specific logic for calculating the 
                    // budget, ignore that here we're doing just +=
                    budget += value;

                }
            });

            thread.Start();

            foreach (var value in outgoingValues)
            {
                budget -= value;
            }

            thread.Join();

            Console.WriteLine($"Result: {budget}; Expected: 0");
            Console.ReadLine();
        }

        private static List<int> GetIncomingValues()
        {
            var values = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                values.Add(i);
            }

            return values;
        }

        private static List<int> GetOutgoingValues()
        {
            var values = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                values.Add(i);
            }

            return values;
        }
    }
}
