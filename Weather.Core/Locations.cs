using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weather
{
    public class AvailableLocation
    {
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
                var subitem = item.Split('\t');
                yield return new AvailableLocation()
                {
                    CountryCode = subitem[0],
                    Name = subitem[3],
                    GeonamesId = int.Parse(subitem[4]),
                    Type = subitem[7],
                    Country = subitem[9],
                    Population = int.Parse(subitem[10]),
                    Latitude = subitem[11],
                    Longitude = subitem[12],
                    Altitude = int.Parse(subitem[13]),
                    XmlUrl = subitem[14]
                };
            }
        }
    }
}
