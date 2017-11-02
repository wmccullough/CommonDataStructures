using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives.Geography
{
    public class PostalCode : IPostalCode
    {
        public PostalCode()
        {

        }

        public PostalCode(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!", nameof(value));

            Value = value;
        }

        public string Value { get; protected set; }
    }
}
