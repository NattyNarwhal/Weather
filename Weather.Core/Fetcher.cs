using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Weather
{
    public static class Fetcher
    {
        const string ua = "https://github.com/NattyNarwhal/Weather";

        const string yrnoQueries = "http://www.yr.no/_/websvc/jsonforslagsboks.aspx?s={0}&s1t=&s1i=&s2t=&s2i=";
        const string querySlicingRegex = @"\/(?:place|sted)\/(\w*\/\w*\/\w*)\/?";

        const string yrnoBase = "http://www.yr.no/place/{0}/{1}.xml";
        const string normalForecast = "forecast";
        const string hourlyForecast = "forecast_hour_by_hour";

        static CookieAwareWebClient wc = new CookieAwareWebClient();

        static Fetcher()
        {
            wc.Headers.Add(HttpRequestHeader.UserAgent, ua);
            var jar = new CookieContainer();
            jar.Add(new Cookie("l", "en", "/", "yr.no"));
            jar.Add(new Cookie("brp", "spr=eng", "/", "yr.no"));
            wc.CookieContainer = jar;
        }

        static string GetUrl(string location, bool hourly)
        {
            return String.Format(yrnoBase, location,
                hourly ? hourlyForecast : normalForecast);
        }

        public static Stream GetStream(string location, bool hourly)
        {
            return wc.OpenRead(GetUrl(location, hourly));
        }

        public static bool LocationExists(string location)
        {
            var wr = (HttpWebRequest)WebRequest.Create(GetUrl(location, false));
            wr.Method = "HEAD";
            wr.UserAgent = ua;
            try
            {
                return ((HttpWebResponse)wr.GetResponse()).StatusCode < HttpStatusCode.BadRequest;
            }
            catch (WebException)
            {
                // server-side codes get this
                return false;
            }
        }

        public static IEnumerable<SearchResult> GetCompletions(string query)
        {
            using (var s = wc.OpenRead(String.Format(yrnoQueries, query)))
            {
                using (var sr = new StreamReader(s))
                {
                    var content = sr.ReadToEnd();
                    // TODO: actual proper serialization
                    // unfortunately, the fact it's all arrays makes it
                    // more challenging
                    var j = (JArray)JsonConvert.DeserializeObject(content);
                    
                    // the structure of the returned is an array
                    // containing two more arrays - the first one is
                    // the original query plus some additional settings
                    // that I'm unsure about their purpose. the latter
                    // is then an array of more arrays, but these
                    // arrays contain structure:
                    //    [name, url, meta, country]

                    foreach (JArray result in j[1])
                    {
                        yield return new SearchResult()
                        {
                            Name = (string)result[0],
                            Url = Regex.Match((string)result[1],
                                querySlicingRegex).Value,
                            Metadata = (string)result[2],
                            CountryCode = (string)result[3]
                        };
                    }
                }
            }
        }
    }
}
