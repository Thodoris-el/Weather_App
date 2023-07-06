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
            getWetaher();

        }

        string APIkey = "cbec624ef2c60055a21f567c45b3fd47";
        void getWetaher()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCity.Text, APIkey);
                var json = web.DownloadString(url);
                WeatherInformation.root Info = JsonConvert.DeserializeObject<WeatherInformation.root>(json);

                picWeather.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lbCondition.Text = Info.weather[0].main;
                lbDetails.Text = Info.weather[0].description;
                lbSunrise.Text = "Sunrise: " + convertDate(Info.sys.sunrise).ToShortTimeString();
                lbSunset.Text = "Sunset: " + convertDate(Info.sys.sunset).ToShortTimeString();
                lbWind.Text = "Wind Speed: " + Info.wind.speed.ToString();
                lbPressure.Text = "Pressure: " + Info.main.pressure.ToString();
                

            }
        }

        DateTime convertDate(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;
        }
    }
}
