using System;
using System.Diagnostics;
using System.Text;

namespace PML.PrimeNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IInteractionType interactionType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.ConsoleUser);

            long primesRequested = interactionType.GetValue();
            if ( primesRequested > 0)
            {
                var pns = new PrimeNumberService(primesRequested);

                var timeTaken = new Stopwatch();
                timeTaken.Start();
                var primes = pns.FindPrimeNumbers(2);
                timeTaken.Stop();
                var msg = $"Time taken to calc {primesRequested} was {timeTaken.ElapsedMilliseconds} (milliseconds); per prime avg {timeTaken.ElapsedMilliseconds / primesRequested} (milliseconds)";
                interactionType.PrintValue(primes);
                interactionType.PrintValue(msg);
            }
        }
    }
}
