using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Weather
{
    public static class Fetcher
    {
        const string ua = "https://github.com/NattyNarwhal/Weather";

        const string yrnoBase = "http://www.yr.no/place/{0}/{1}.xml";
        const string normalForecast = "forecast";
        const string hourlyForecast = "forecast_hour_by_hour";

        static WebClient wc = new WebClient();

        static Fetcher()
        {
            wc.Headers.Add(HttpRequestHeader.UserAgent, ua);
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
    }
}
