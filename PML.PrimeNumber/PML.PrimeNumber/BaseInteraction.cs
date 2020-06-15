using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber
{
    class BaseInteraction : IInteractionType
    {
        public long GetValue()
        {
            var rc = 100; // default but could be settings file etc...
            return rc;
        }

        public void PrintValue(List<long> printValues)
        {
            // throw an error ...but this could go to file etc...
            throw new NotImplementedException();
        }
        public void PrintValue(string msg)
        {
            // throw an error ...but this could go to file etc...
            throw new NotImplementedException();
        }
    }
}
