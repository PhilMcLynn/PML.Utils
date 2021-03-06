﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber
{
    public class PrimeNumberService
    {
        private readonly long _primeNumbersRequested;
        public PrimeNumberService (long primeNumbersRequested)
        {
            _primeNumbersRequested = primeNumbersRequested;
        }

        public List<long> FindPrimeNumbers(long startNaturalNumber)
        {
            List<long> primes = new List<long>()
            { 2 };
            var primesFound = 1;
            long currentNaturalNumber = 3;
            while (primesFound < _primeNumbersRequested)
            {
                using (var pnc = new PrimeNumberCandidate(currentNaturalNumber))
                {
                    if (pnc.GetIsPrimeNumber())
                    {
                        primesFound++;
                        primes.Add(currentNaturalNumber);
                    }
                }
                currentNaturalNumber+=2;    // started on a odd number ...stay on odd as they are only candidates
            }
            return primes;
        }
        //public List<long> FindPrimeNumbers(long startNaturalNumber)
        //{
        //    List<long> primes = new List<long>();
        //    var primesFound = 0;
        //    long currentNaturalNumber = 2;
        //    while (primesFound < _primeNumbersRequested)
        //    {
        //        using( var pnc = new PrimeNumberCandidate( currentNaturalNumber))
        //        {
        //            if (pnc.GetIsPrimeNumber())
        //            { 
        //                primesFound++;
        //                primes.Add(currentNaturalNumber);
        //            }
        //        }
        //        currentNaturalNumber++;
        //        if ( currentNaturalNumber % 2 == 0) // All even numbers above 2 are not prime canditates ...so skip
        //            currentNaturalNumber++;

        //    }
        //    return primes;
        //}
    }
}
