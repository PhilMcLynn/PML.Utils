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
            for (long y = 3; y <= (_primeCanditate/3); y+=2)
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
