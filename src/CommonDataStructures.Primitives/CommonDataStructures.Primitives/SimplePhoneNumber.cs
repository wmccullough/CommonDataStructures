using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives
{
    public class SimplePhoneNumber : IPhoneNumber
    {
        public SimplePhoneNumber()
        {

        }

        public SimplePhoneNumber(string value, PhoneTypes type)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value));

            FormattedValue = value;
            Type = type;
        }

        public virtual string FormattedValue { get; protected set; }
        public virtual PhoneTypes Type { get; protected set; }
    }
}
