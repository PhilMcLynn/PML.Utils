using System;
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
                var primes = pns.FindPrimeNumbers(2);

                interactionType.PrintValue(primes);
            }
        }
    }
}
