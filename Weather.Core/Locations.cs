using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Weather
{
    public class AvailableLocation
    {
        const string querySlicingRegex = @"\/(?:place|sted)\/(\w*\/\w*\/\w*)\/?";

        public string CountryCode { get; set; }
        public string Name { get; set; }
        public int GeonamesId { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Altitude { get; set; }
        public string XmlUrl { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} ({2})",
                Name, Country, Type);
        }

        public string UrlSubsection()
        {
            return Regex.Match(XmlUrl, querySlicingRegex).Groups[1].Value;
        }

        // File for all locations:
        // http://fil.nrk.no/yr/viktigestader/verda.txt
        // More info, including Norway-specific ones:
        // http://om.yr.no/verdata/xml/

        public static IEnumerable<AvailableLocation> GetList()
        {
            return FromTabulated(Core.Properties.Resources.locations);
        }

        public static IEnumerable<AvailableLocation> FromTabulated(string tabulatedData)
        {
            // first item is a header, so skip it
            return FromTabulated(tabulatedData.Split
                ('\n').Skip(1).ToArray());
        }

        public static IEnumerable<AvailableLocation> FromTabulated(string[] tabulatedData)
        {
            foreach (var item in tabulatedData)
            {
                if (string.IsNullOrWhiteSpace(item)) continue;
                var subitem = item.Split('\t');
                yield return new AvailableLocation()
                {
                    CountryCode = subitem[0],
                    Name = subitem[3],
                    GeonamesId = int.Parse(subitem[4]),
                    Type = subitem[7],
                    Country = subitem[10],
                    Population = int.Parse(subitem[11]),
                    Latitude = subitem[12],
                    Longitude = subitem[13],
                    Altitude = String.IsNullOrEmpty(subitem[14]) ?
                        0 : int.Parse(subitem[14]),
                    XmlUrl = subitem[17].Trim()
                };
            }
        }
    }
}
