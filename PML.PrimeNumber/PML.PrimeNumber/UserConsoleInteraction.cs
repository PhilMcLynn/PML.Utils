using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber
{
    public class UserConsoleInteraction : IInteractionType
    {
        public long GetValue()
        {
            long rc = -1;
            Console.WriteLine("Enter # primes requested");
            var primesRequestedStr = Console.ReadLine();
            long primesRequested = 0;
            if (long.TryParse(primesRequestedStr, out primesRequested))
            {
                if (primesRequested == 0)
                    Console.WriteLine("Enter a value greater than 0!");
                else
                    rc = primesRequested;
            }
            else
            {
                Console.WriteLine("Not a valid long value!");
            }
            return rc;
        }

        public void PrintValue(List<long> printValues)
        {
            printValues.ForEach(row => Console.Write($" {row},"));
        }
    }
}
