using System;
using System.Collections.Generic;
using System.Xml.Serialization;

//http://www.yr.no/place/Norway/Telemark/Sauherad/Gvarv/forecast.xml
namespace Weather
{
    [XmlRoot(ElementName = "weatherdata")]
    public class WeatherData
    {
        [XmlElement(ElementName = "location")]
        public Location Location { get; set; }
        [XmlElement(ElementName = "credit")]
        public Credit Credit { get; set; }
        [XmlArray(ElementName = "links")]
        [XmlArrayItem(ElementName = "link", Type = typeof(Link))]
        public List<Link> Links { get; set; }
        [XmlElement(ElementName = "meta")]
        public Meta Meta { get; set; }
        [XmlElement(ElementName = "sun")]
        public Sun Sun { get; set; }
        [XmlElement(ElementName = "forecast")]
        public Forecast Forecast { get; set; }
        [XmlArray(ElementName = "observations")]
        [XmlArrayItem(ElementName = "weatherstation",
            Type = typeof(WeatherStation))]
        public List<WeatherStation> Observations { get; set; }
    }

    #region Location
    public class Location
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "timezone", Type = typeof(TimeZone))]
        public TimeZone TimeZone { get; set; }
        [XmlElement(ElementName = "location", Type = typeof(LocationInner))]
        public LocationInner LocationInner { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", Name, Country);
        }
    }

    public class TimeZone
    {
        [XmlAttribute(AttributeName = "id")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "utcoffsetMinutes")]
        public int UTCOffsetMinutes { get; set; }

        public override string ToString()
        {
            return ID;
        }
    }

    public class LocationInner
    {
        [XmlAttribute(AttributeName = "geobaseid")]
        public int GeobaseID { get; set; }
        [XmlAttribute(AttributeName = "geobase")]
        public string Geobase { get; set; }
        [XmlAttribute(AttributeName = "longitude")]
        public string Longitude { get; set; }
        [XmlAttribute(AttributeName = "latitude")]
        public string Latitude { get; set; }
        [XmlAttribute(AttributeName = "altitude")]
        public int Altitude { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", Latitude, Longitude);
        }
    }
    #endregion

    #region Credit
    public class Credit
    {
        [XmlElement(ElementName = "link", Type = typeof(CreditLink))]
        public CreditLink Link { get; set; }

        public override string ToString()
        {
            return Link.ToString();
        }
    }

    public class CreditLink
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
        [XmlAttribute(AttributeName = "text")]
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    #endregion
    
    public class Link
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return Id;
        }
    }
    public class Meta
    {
        [XmlElement(ElementName = "lastupdate")]
        public DateTime LastUpdate { get; set; }
        [XmlElement(ElementName = "nextupdate")]
        public DateTime NextUpdate { get; set; }
    }
    public class Sun
    {
        [XmlAttribute(AttributeName = "set")]
        public DateTime Set { get; set; }
        [XmlAttribute(AttributeName = "rise")]
        public DateTime Rise { get; set; }
    }

    #region Forecast
    public class Forecast
    {
        [XmlElement(ElementName = "text")]
        public Text TextTimes { get; set; }
        [XmlArray(ElementName = "tabular")]
        [XmlArrayItem(ElementName = "time",
            Type = typeof(TabularTime))]
        public List<TabularTime> Times { get; set; }
    }

    public class Text
    {
        [XmlArray(ElementName = "location")]
        [XmlArrayItem(ElementName = "time", Type = typeof(TextTime))]
        public List<TextTime> Times { get; set; }
    }

    public class TextTime
    {
        [XmlAttribute(AttributeName = "from")]
        public DateTime From { get; set; }
        [XmlAttribute(AttributeName = "to")]
        public DateTime To { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "body")]
        public string body { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }

    #endregion
    #region Forecast, Tabular Form
    public class TabularTime
    {
        [XmlAttribute(AttributeName = "from")]
        public DateTime From { get; set; }
        [XmlAttribute(AttributeName = "to")]
        public DateTime To { get; set; }
        [XmlAttribute(AttributeName = "period")]
        public int Period { get; set; }
        [XmlElement(ElementName = "symbol")]
        public TabularTimeSymbol Symbol { get; set; }
        [XmlElement(ElementName = "precipitation")]
        public Precipitation Precipitation { get; set; }
        [XmlElement(ElementName = "windDirection")]
        public WindDirection WindDirection { get; set; }
        [XmlElement(ElementName = "windSpeed")]
        public WindSpeed WindSpeed { get; set; }
        [XmlElement(ElementName = "temperature")]
        public Temperature Temperature { get; set; }
        [XmlElement(ElementName = "pressure")]
        public Pressure Pressure { get; set; }

    }

    public enum SymbolNumber
    {
        Sunny = 1,
        Fair = 2,
        PartlyCloudy = 3,
        Cloudy = 4,
        RainShowers = 5,
        RainShowersWithThunder = 6,
        SleetShowers = 7,
        SnowShowers = 8,
        Rain = 9,
        HeavyRain = 10,
        RainAndThunder = 11,
        Sleet = 12,
        Snow = 13,
        SnowAndThunder = 14,
        Fog = 15,
        SleetShowersAndThunder = 20,
        SnowShowersAndThunder = 21,
        RainAndThunderAlternate = 22,
        SleetAndThunder = 23
    }

    public class TabularTimeSymbol
    {
        [XmlAttribute(AttributeName = "number")]
        public SymbolNumber Number { get; set; }
        [XmlAttribute(AttributeName = "numberEx")]
        public int NumberEx { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "var")]
        public string Var { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Precipitation
    {
        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }

        public override string ToString()
        {
            return String.Format("{0:F0} mm", Value);
        }
    }

    public class WindDirection
    {
        [XmlAttribute(AttributeName = "deg")]
        public float Degrees { get; set; }
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class WindSpeed
    {
        [XmlAttribute(AttributeName = "mps")]
        public float MetersPerSecond { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Temperature
    {
        [XmlAttribute(AttributeName = "value")]
        public int Value { get; set; }
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }

        public override string ToString()
        {
            return String.Format("{0} C", Value);
        }
    }

    public class Pressure
    {
        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }

        public override string ToString()
        {
            return String.Format("{0:F0} {1}", Value, Unit);
        }
    }
    #endregion

    #region Observations
    public class WeatherStation
    {
        [XmlAttribute(AttributeName = "stno")]
        public int StationNumber { get; set; }
        [XmlAttribute(AttributeName = "sttype")]
        public string StationType { get; set; }
        [XmlAttribute(AttributeName = "distance")]
        public int Distance { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Latitude { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Longitude { get; set; }
        [XmlAttribute(AttributeName = "source")]
        public string Source { get; set; }
        [XmlElement(ElementName = "windDirection")]
        public WeatherStationWindDirection WindDirection { get; set; }
        [XmlElement(ElementName = "windSpeed")]
        public WeatherStationWindSpeed WindSpeed { get; set; }
        [XmlElement(ElementName = "temperature")]
        public WeatherStationTemperature Temperature { get; set; }
    }

    // we don't inherit because the forecasts seem to be ints
    public class WeatherStationTemperature
    {
        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "time")]
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} at {2}", Value, Unit, Time);
        }
    }

    public class WeatherStationWindSpeed : WindSpeed
    {
        [XmlAttribute(AttributeName = "time")]
        public DateTime Time { get; set; }
    }

    public class WeatherStationWindDirection : WindDirection
    {
        [XmlAttribute(AttributeName = "time")]
        public DateTime Time { get; set; }
    }
    #endregion
}
