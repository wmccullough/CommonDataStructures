using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives
{
    public class EmailAddress : IEmailAddress
    {
        public EmailAddress(string addressee, string domain)
        {
            Addressee = addressee;
            Domain = domain;
        }

        public string Addressee { get; }
        public string Domain { get; }
        public string FormattedValue => $"{Addressee}@{Domain}";
    }
}
