using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDataStructures.Primitives.Geography
{
    public class Country
    {
        public Country()
        {

        }

        public Country(string name, string abbreviation)
        {
            Name = name;
            Abbreviation = abbreviation;
        }

        public string Name { get; }
        public string Abbreviation { get; }
    }
}
