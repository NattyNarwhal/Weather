using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weather
{
    public class SearchResult
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Metadata { get; set; }
        public string CountryCode { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1})",
                Name, Metadata);
        }
    }
}
