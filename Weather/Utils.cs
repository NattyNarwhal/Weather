using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public static class Utils
    {
        /// <summary>
        /// Gets a string representing wind information.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Wind(this TabularTime t)
        {
            return string.Format("{0} m/s {1}",
                t.WindSpeed.MetersPerSecond.ToString(), t.WindDirection.Code);
        }

        public static bool FitsInPeriod(this TabularTime t, DateTime time)
        {
            return time > t.From && time < t.To;
        }
    }
}
