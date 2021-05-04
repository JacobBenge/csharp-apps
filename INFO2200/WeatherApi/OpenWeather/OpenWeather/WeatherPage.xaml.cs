using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenWeather
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            // Load the values that were stored globally
            LblCurrentCity.Text = $"City: {WeatherGV.City}";
            LblCurrentTemp.Text = $"Current Temp: {WeatherGV.CurTemp} °F";
            LblHighTemp.Text = $"High Temp: {WeatherGV.High} °F";
            LblLowTemp.Text = $"Low Temp: {WeatherGV.Low} °F";
            LblWindSpeed.Text = $"Wind Speed: {WeatherGV.WindSpeed} MPH";
            LblWindDirection.Text = $"Wind Direction: {WeatherGV.WindDirection}°";
            LblPressure.Text = $"Pressure: {WeatherGV.Pressure}";
            LblHumidity.Text = $"Humidity: {WeatherGV.Humidity}";
            LblSunrise.Text = $"Sunrise: {WeatherGV.Sunrise} UTC";
            LblSunset.Text = $"Sunset: {WeatherGV.Sunset} UTC";
            LblGuess.Text = $"Incorrect Guess: {WeatherGV.GuessInput} °F";

            // Change background color based on current temp
            double temp = Convert.ToDouble(WeatherGV.CurTemp); // convert to double
            if (temp >= 80) // if hot
            {
                MainGrid.Background = new SolidColorBrush(Color.FromRgb(255, 81, 46)); // update background color
            } else if (temp >= 60) // if nice
            {
                MainGrid.Background = new SolidColorBrush(Color.FromRgb(230, 230, 230));
            } else // if cold
            {
                MainGrid.Background = new SolidColorBrush(Color.FromRgb(140, 140, 255));
            }

            // Update if guess is correct
            double guess = Convert.ToDouble(WeatherGV.GuessInput); // convert to double
            if (guess == temp) // if guess is correct
            {
                LblGuess.TextColor= Color.Green; // update text color
                LblGuess.Text = $"Correct Guess: {WeatherGV.GuessInput} °F"; // update to correct text
            }
        }
    }
}