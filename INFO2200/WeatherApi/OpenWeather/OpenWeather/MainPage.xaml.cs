using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using Newtonsoft.Json.Linq; // Add this to access JObject for deserialization and serialization of JSON object tools>NuGet Package Manager> Manage Nuget Packages for Solution

namespace OpenWeather
{
    public partial class MainPage : ContentPage
    {
        // API key obtained from https://openweathermap.org/api
        string APIKEY = "26df8e3ed44a0c3be244ac7f9a852555";
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnShowTemp_Clicked(object sender, EventArgs e)
        {
            // instanitate the web connection
            using (WebClient wc = new WebClient())
            {
                // declare the content type (MIME) and store it in the HTTP headers
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                try
                {
                    // Obtain the user's selection and generate the appropriate zipcode
                    string zipcode = "";
                    string selection = PckCity.SelectedItem.ToString();
                    switch (selection)
                    {
                        case "Orem":
                            zipcode = "84097";
                            break;
                        case "Miami":
                            zipcode = "33101";
                            break;
                        case "Anchorage":
                            zipcode = "95503";
                            break;
                        default:
                            break;
                    }

                    // Gets the data from the web api in json format
                    string jsontext = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={zipcode}&appid={APIKEY}&units=imperial");

                    // Deserializes the JSON object / parses it to JavaScript
                    JObject jo = JObject.Parse(jsontext);

                    // Get the Main section from the jo array and store it in a JavaScript object
                    JObject main = JObject.Parse(jo["main"].ToString());

                    // Get the wind and sys arrays to simplify code below
                    JObject wind = JObject.Parse(jo["wind"].ToString());
                    JObject sys = JObject.Parse(jo["sys"].ToString());

                    // grab a property from the javascript object and store globally
                    WeatherGV.CurTemp = main["temp"].ToString();
                    WeatherGV.Low = main["temp_min"].ToString();
                    WeatherGV.High = main["temp_max"].ToString();
                    WeatherGV.Pressure = main["pressure"].ToString();
                    WeatherGV.Humidity = main["humidity"].ToString();
                    WeatherGV.WindSpeed = wind["speed"].ToString();
                    WeatherGV.WindDirection = wind["deg"].ToString();
                    WeatherGV.City = jo["name"].ToString();
                    WeatherGV.Sunrise = sys["sunrise"].ToString(); // in UTC 
                    WeatherGV.Sunset = sys["sunset"].ToString(); // in UTC
                    WeatherGV.GuessInput = EntryGuess.Text;

                    // Display the weather page
                    Navigation.PushAsync(new WeatherPage());
                }
                catch (Exception ex)
                {
                    // This occurs when response is not received from the weather api. The download string could have errors, lack of internet, or weather api is down.
                    DisplayAlert("Request Error", ex.Message, "Close");
                }
            }
        }
    }
}
