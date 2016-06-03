using System;
using System.Linq;

namespace Weather
{
    public static class Utils
    {
        /// <summary>
        /// Gets a string representing wind information.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Wind(this TabularTime t, bool descriptive)
        {
            return descriptive ?
                string.Format("{0} to the {1}",
                    t.WindSpeed.Name, t.WindDirection.Name) :
                string.Format("{0} m/s {1}",
                    t.WindSpeed.MetersPerSecond.ToString(), t.WindDirection.Code);
        }

        public static bool FitsInPeriod(this TabularTime t, DateTime time)
        {
            return time > t.From && time < t.To;
        }

        public static TabularTime GetCurrentForecast(this WeatherData data)
        {
            var adjustedNow = DateTime.UtcNow.AddMinutes
                (data.Location.TimeZone.UTCOffsetMinutes);
            return data.Forecast.Times.Where(x => x.FitsInPeriod(adjustedNow)).FirstOrDefault()
                ?? data.Forecast.Times.Where(x => x.From.Date == adjustedNow.Date).FirstOrDefault();
        }
    }
}
