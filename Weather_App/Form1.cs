using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();

        }

        string APIkey = "cbec624ef2c60055a21f567c45b3fd47";
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCity.Text, APIkey);
                var json = web.DownloadString(url);
                WeatherInformation.root Info = JsonConvert.DeserializeObject<WeatherInformation.root>(json);

                picWeather.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lbTemparature.Text = "Temparature: " + Info.main.temp.ToString() + "°F";
                lbCondition.Text = Info.weather[0].main;
                lbDetails.Text = Info.weather[0].description;
                lbSunrise.Text = "Sunrise: " + convertDate(Info.sys.sunrise).ToShortTimeString();
                lbSunset.Text = "Sunset: " + convertDate(Info.sys.sunset).ToShortTimeString();
                lbWind.Text = "Wind Speed: " + Info.wind.speed.ToString();
                lbPressure.Text = "Pressure: " + Info.main.pressure.ToString();
                

                if (Info.weather[0].main == "Snow")
                {
                    Image backimage = new Bitmap(@"C:\Users\Y9GL7F726\source\repos\Weather_App\Weather_App\snowy_weather.jpg");
                    this.BackgroundImage = backimage;
                }
                else if (Info.weather[0].main == "Rain" || Info.weather[0].main == "Thunderstorm")
                {
                    Image backimage = new Bitmap(@"C:\Users\Y9GL7F726\source\repos\Weather_App\Weather_App\rainy_weather.jpg");
                    this.BackgroundImage = backimage;
                }
                else if (Info.weather[0].main == "Clouds")
                {
                    Image backimage = new Bitmap(@"C:\Users\Y9GL7F726\source\repos\Weather_App\Weather_App\cloudy_weather.jpg");
                    this.BackgroundImage = backimage;
                }
                else
                {
                    Image backimage = new Bitmap(@"C:\Users\Y9GL7F726\source\repos\Weather_App\Weather_App\clear_weather.jpg");
                    this.BackgroundImage = backimage;
                }

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }

        DateTime convertDate(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;
        }

        double lat;
        double lon;
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", lat, lon, APIkey);
                var json = web.DownloadString(url);
                Console.WriteLine(json);

                WeatherForecast.ForecastInformation forecast = JsonConvert.DeserializeObject<WeatherForecast.ForecastInformation>(json);

                ForecastUC FUC;
                var tmp_date = "";

                for (int i = 0; i < forecast.list.Count; i++)
                {
                    if ( tmp_date != convertDate(forecast.list[i].dt).DayOfWeek.ToString())
                    {
                        tmp_date = convertDate(forecast.list[i].dt).DayOfWeek.ToString();
                        Console.WriteLine(i);
                        FUC = new ForecastUC();
                        FUC.picWIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecast.list[i].weather[0].icon + ".png";
                        FUC.lbWCondition.Text = forecast.list[i].weather[0].main;
                        FUC.lbWCondition.Text = forecast.list[i].weather[0].description;
                        FUC.lbTemp.Text = forecast.list[i].main.temp.ToString();
                        FUC.lbDay.Text = convertDate(forecast.list[i].dt).DayOfWeek.ToString();
                        FLP.Controls.Add(FUC);
                    }

                }

            }
        }

        private void FLP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
