using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weather
{
    /// <summary>
    /// This a wrapper class for ServiceLanguage that gives human-readable names.
    /// </summary>
    public class ServiceLanguageWrapper
    {
        public ServiceLanguage Language { get; set; }

        public ServiceLanguageWrapper(ServiceLanguage lang)
        {
            Language = lang;
        }

        public override string ToString()
        {
            switch (Language)
            {
                case ServiceLanguage.English:
                    return "English";
                case ServiceLanguage.NorwegianBokmal:
                    return "Norwegian (Bokmål)";
                case ServiceLanguage.NorwegianNynorsk:
                    return "Norwegian (Nynorsk)";
                default:
                    throw new InvalidOperationException();
            }
        }

        public static ServiceLanguageWrapper[] GetAllPossible()
        {
            return ((ServiceLanguage[])Enum.GetValues(typeof(ServiceLanguage)))
                .Select(x => new ServiceLanguageWrapper(x)).ToArray();
        }
    }
}
