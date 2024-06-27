using System.Xml.Linq;

namespace WeatherAppForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label2.Text = DateTime.Now.ToShortDateString();

            string api = "d9abf9d2c97bb3df506948bf19229197";
            string connection = "https://api.openweathermap.org/data/2.5/weather?lat=38&lon=27&appid=d9abf9d2c97bb3df506948bf19229197&units=metric&mode=xml&lang=tr";
            XDocument weather = XDocument.Load(connection);
            var warm = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var windy = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var humidity = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var hava = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var feels_like = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            label4.Text = warm.ToString();
            label7.Text = windy + " m/s";
            label9.Text = humidity + " %";
            label10.Text = hava;
            label11.Text = feels_like + " Hissedilen Sıcaklık";

        }


    }
}
