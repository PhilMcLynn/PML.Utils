using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber
{
    public interface IInteractionType
    {
        long GetValue();
        void PrintValue(List<long> printValues);
        void PrintValue(string msg);
    }
}
