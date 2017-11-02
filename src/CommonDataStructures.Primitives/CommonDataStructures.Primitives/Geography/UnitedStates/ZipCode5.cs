using System;

namespace CommonDataStructures.Primitives.Geography.UnitedStates
{
    public class ZipCode5 : PostalCode
    {
        public ZipCode5(string value)
            : base(value)
        {
            if (value.Length != 5)
                throw new ArgumentException("ZipCode9 values must me 5 characters in length", nameof(value));
        }

    }
}
