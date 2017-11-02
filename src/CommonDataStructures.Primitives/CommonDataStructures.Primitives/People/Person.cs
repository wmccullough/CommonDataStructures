using System;
using System.Collections.Generic;
using System.Text;
using CommonDataStructures.Primitives.Geography;
using Newtonsoft.Json;

namespace CommonDataStructures.Primitives.People
{
    public class Person
    {
        public Person()
        {
        }

        public Name Name { get; }

        [JsonProperty("Aliases")]
        private List<Name> _aliases;

        [JsonProperty("PreviousNames")]
        private List<Name> _previousNames;

        [JsonIgnore]
        public IReadOnlyList<Name> Aliases => _aliases.AsReadOnly();

        [JsonIgnore]
        public IReadOnlyList<Name> PreviousNames => _previousNames.AsReadOnly();

        public PostalAddress MailingAddress { get; }

        public PostalAddress PhysicalAddress { get; set; }

        [JsonProperty("EmailAddresses")]
        private List<EmailAddress> _emailAddresses;

        [JsonIgnore]
        public IReadOnlyList<EmailAddress> EmailAddresses => _emailAddresses.AsReadOnly();

        [JsonProperty("PhoneNumbers")]
        private List<SimplePhoneNumber> _phoneNumbers;

        [JsonIgnore]
        public IReadOnlyList<SimplePhoneNumber> PhoneNumbers => _phoneNumbers.AsReadOnly();

        public SimplePhoneNumber ContactPhoneNumber { get; }
        public SimplePhoneNumber AlternateContactPhoneNumber { get; }
    }
}
