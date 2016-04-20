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
        const string yrnoBase = "http://www.yr.no/place/{0}/forecast.xml";
        static WebClient wc = new WebClient();

        static Fetcher()
        {
            wc.Headers.Add(HttpRequestHeader.UserAgent, ua);
        }

        static string GetUrl(string location)
        {
            return String.Format(yrnoBase, location);
        }

        public static Stream GetStream(string location)
        {
            return wc.OpenRead(GetUrl(location));
        }

        public static bool LocationExists(string location)
        {
            var wr = (HttpWebRequest)WebRequest.Create(GetUrl(location));
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
