using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber
{
    public class PrimeNumberCandidate : IDisposable
    {
        private readonly long _primeCanditate;
        public PrimeNumberCandidate( long primeCanditate)
        {
            _primeCanditate = primeCanditate;
        }

        public bool GetIsPrimeNumber()
        {
            var rc = true;
            for (int y = 2; y < _primeCanditate; y++)
            {
                if (_primeCanditate % y == 0)
                {
                    rc = false;
                    break;
                }
            }
            return rc;
        }

        public void Dispose()
        { }
    }
}
