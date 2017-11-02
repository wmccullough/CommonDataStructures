using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives.Geography.UnitedStates
{
    public class ZipCode9 : PostalCode
    {
        public ZipCode9(string value)
            : base(value)
        {
            if (value.Length != 9)
                throw new ArgumentException("ZipCode9 values must me 9 characters in length", nameof(value));
        }
    }
}
