using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace EarthquakeAPI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnFind_Clicked(object sender, EventArgs e)
        {
            // instanitate the web connection
            using (WebClient wc = new WebClient())
            {
                // declare the connection type
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                try
                {   // Gets the data from the web api in json format
                    string jsontext = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={EntryStartDate.Text}&endtime={EntryEndDate.Text}&minmagnitude={EntrySize.Text}");
                    // Deserializes the data
                    JObject jo = JObject.Parse(jsontext);
                    // Create a javascript object
                    JObject main = JObject.Parse(jo["metadata"].ToString());

                    // Get the number of earthquakes
                    int count = 0;
                    int.TryParse(main["count"].ToString(), out count);

                    // Creates a list of earthquakes and gets values from the API
                    List<Earthquake> eqList = new List<Earthquake>();
                    int idx = 1;

                    // There is one feature for each earthquake in the features array
                    foreach (var eq in jo["features"])
                    {
                        // parses the properties property within the feature and puts it into an object
                        JObject eqJObj = JObject.Parse(eq["properties"].ToString());
                        // instantiate a list
                        Earthquake earthquake = new Earthquake
                        {
                            // create an id
                            EarthquakeId = idx,
                            // grab the magnitude
                            Magnitude = double.Parse(eqJObj["mag"].ToString()),
                            // grab the location description of the earthquake
                            Place = eqJObj["place"].ToString()
                        };
                        // add the item we just created into the list
                        eqList.Add(earthquake);
                    }

                    // instantiate a random number
                    Random random = new Random();
                    // pick a random item within our list
                    int randeq = random.Next(1, eqList.Count + 1);
                    // save the randomly generated eq
                    Earthquake displayEQ = eqList[randeq];
                    // display the results
                    LblResults.Text = $"There were {count} earthquakes during this time.\n\n" +
                       $"Details of one of them:\nPlace: {displayEQ.Place}, \nMagnitude: {displayEQ.Magnitude}.";
                }
                catch (Exception ex)
                {
                    DisplayAlert("Request Error", ex.Message, "Close");
                }
            }
        }
    }
}
