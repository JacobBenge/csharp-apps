using System;
using System.Collections.Generic;
using System.Text;

namespace EarthquakeAPI
{
    public class Earthquake
    {
        // a place to store variables globally so we can access them on multiple pages.
        public int EQid { get; set; }
        public string EQLocation { get; set; }
        public string EQSize { get; set; }
        public int EarthquakeId { get; internal set; }
        public double Magnitude { get; internal set; }
        public string Place { get; internal set; }
    }
}
