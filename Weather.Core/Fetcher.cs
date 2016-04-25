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
    }
}
