using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives
{
    public class SimpleEmailAddress : IEmailAddress
    {
        public SimpleEmailAddress()
        {

        }

        public SimpleEmailAddress(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value must not be null or empty!", nameof(value));

            FormattedValue = value;
        }

        public string FormattedValue { get; }
    }
}
