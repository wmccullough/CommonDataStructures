using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives
{
    public interface IPhoneNumber
    {
        string FormattedValue { get; }
        PhoneTypes Type { get; }
    }
}
