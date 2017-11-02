using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives.UnitedStates
{
    public class PhoneNumber : SimplePhoneNumber
    {
        public PhoneNumber(string areaCode, string exchange, string lineNumber, PhoneTypes type)
            : base($"+1{areaCode}{exchange}{lineNumber}", type)
        {
            if (string.IsNullOrEmpty(areaCode))
                throw new ArgumentException("Area code must not be null!", nameof(areaCode));

            if (string.IsNullOrEmpty(exchange))
                throw new ArgumentException("Exchange code must not be null!", nameof(exchange));

            if (string.IsNullOrEmpty(lineNumber))
                throw new ArgumentException("Line number must not be null!", nameof(lineNumber));

            AreaCode = areaCode;
            Exchange = exchange;
            LineNumber = lineNumber;
        }

        public string AreaCode { get; }
        public string Exchange { get; }
        public string LineNumber { get; }
    }
}
