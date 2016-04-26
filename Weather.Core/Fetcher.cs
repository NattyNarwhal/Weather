using System;
using System.IO;
using System.Net;

namespace Weather
{
    [Serializable]
    public enum ServiceLanguage
    {
        NorwegianNynorsk, NorwegianBokmal, English
    }

    public class Fetcher
    {
        private ServiceLanguage _language;

        public ServiceLanguage Language
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;

                // set the fetcher language in case
                var jar = new CookieContainer();

                if (value == ServiceLanguage.English)
                    jar.Add(new Cookie("lang", "en", "/", "yr.no"));
                else
                    jar.Add(new Cookie("lang", "no", "/", "yr.no"));

                if (value == ServiceLanguage.NorwegianBokmal)
                    jar.Add(new Cookie("brp", "spr=nob", "/", "yr.no"));
                else if (value == ServiceLanguage.NorwegianNynorsk)
                    jar.Add(new Cookie("brp", "spr=nno", "/", "yr.no"));
                else
                    jar.Add(new Cookie("brp", "spr=eng", "/", "yr.no"));
                wc.CookieContainer = jar;
            }
        }

        const string ua = "https://github.com/NattyNarwhal/Weather";

        const string yrnoBase = "http://www.yr.no/{0}/{1}/{2}.xml";
        const string normalForecastEn = "forecast";
        const string hourlyForecastEn = "forecast_hour_by_hour";
        const string normalForecastNo = "varsel";
        const string hourlyForecastNo = "varsel_time_for_time";

        CookieAwareWebClient wc;

        public Fetcher()
        {
            wc = new CookieAwareWebClient();
            wc.Headers.Add(HttpRequestHeader.UserAgent, ua);
            Language = ServiceLanguage.English;
        }

        static string GetPrefix(ServiceLanguage lang)
        {
            if (lang == ServiceLanguage.NorwegianNynorsk)
                return "stad";
            else if (lang == ServiceLanguage.NorwegianBokmal)
                return "sted";
            else return "place";
        }

        static string GetXmlName(bool hourly, ServiceLanguage lang)
        {
            if (hourly && lang == ServiceLanguage.English)
                return hourlyForecastEn;
            else if (!hourly && lang == ServiceLanguage.English)
                return normalForecastEn;
            else if (hourly && lang < ServiceLanguage.English)
                return hourlyForecastNo;
            else
                return normalForecastNo;
        }

        string GetUrl(string location, bool hourly)
        {
            return String.Format(yrnoBase, GetPrefix(Language), location,
                GetXmlName(hourly, Language));
        }

        public Stream GetStream(string location, bool hourly)
        {
            return wc.OpenRead(GetUrl(location, hourly));
        }
    }
}
