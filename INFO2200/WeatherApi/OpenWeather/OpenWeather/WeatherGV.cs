using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeather
{
    public static class WeatherGV
    {
        // a place to store variables globally so we can access them on multiple pages.
        public static string City { get; set; }
        public static string CurTemp { get; set; }
        public static string High { get; set; }
        public static string Low { get; set; }
        public static string WindSpeed { get; set; }
        public static string WindDirection { get; set; }
        public static string Pressure { get; set; }
        public static string Humidity { get; set; }
        public static string Sunrise { get; set; }
        public static string Sunset { get; set; }
        public static string Timezone { get; set; }
        public static string GuessInput { get; set; }
    }
}
