using System;

namespace CommonDataStructures.Primitives.Geography
{
    public class PostalAddress
    {
        public PostalAddress()
        {
        }

        public PostalAddress(string addresseeName, string line1, string cityName,
            string stateOrProvinceCode, string postalCode)
            : this(addresseeName, line1, string.Empty, cityName, stateOrProvinceCode, postalCode)
        {

        }

        public PostalAddress(string addresseeName, string line1, string cityName,
            string stateOrProvinceCode, IPostalCode postalCode)
            : this(addresseeName, line1, string.Empty, cityName, stateOrProvinceCode, postalCode)
        {

        }

        public PostalAddress(string addresseeName, string line1, string line2, string cityName,
            string stateOrProvinceCode, string postalCode)
            : this(addresseeName, line1, line2, cityName, stateOrProvinceCode, new PostalCode(postalCode))
        {
        }

        public PostalAddress(string addresseeName, string line1, string line2, string cityName,
            string stateOrProvinceCode, IPostalCode postalCode)
        {
            AddresseeName = addresseeName;
            Line1 = line1;
            Line2 = line2;
            CityName = cityName;
            StateOrProvinceCode = stateOrProvinceCode;
            PostalCode = postalCode;
        }

        public string AddresseeName { get; }
        public string Line1 { get; }
        public string Line2 { get; }
        public string CityName { get; }
        public string StateOrProvinceCode { get; }
        public IPostalCode PostalCode { get; }
    }
}
