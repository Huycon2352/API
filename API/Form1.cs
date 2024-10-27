using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace API
{
    public partial class Form1 : Form
    {
        private const string ApiKey = ""; // Thay thế bằng API key của bạn
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text.Trim();
            try
            {
                string weatherData = await GetWeatherAsync(city);
                DisplayWeatherData(weatherData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task<string> GetWeatherAsync(string city)
        {
            using HttpClient client = new();
            string url = $"{BaseUrl}?q={city}&appid={ApiKey}&units=metric&mode=xml";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync(); // Trả về XML raw data
            }
            else
            {
                throw new Exception($"Failed to get weather data. Status code: {response.StatusCode}");
            }
        }

        private void DisplayWeatherData(string xmlData)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlData);

            var tempNode = xmlDoc.SelectSingleNode("//temperature");
            var tempValue = tempNode.Attributes["value"].Value;

            var weatherNode = xmlDoc.SelectSingleNode("//weather");
            var weatherDescription = weatherNode.Attributes["value"].Value;

            var humidityNode = xmlDoc.SelectSingleNode("//humidity");
            var humidityValue = humidityNode.Attributes["value"].Value;

            var pressureNode = xmlDoc.SelectSingleNode("//pressure");
            var pressureValue = pressureNode.Attributes["value"].Value;

            var windSpeedNode = xmlDoc.SelectSingleNode("//wind/speed");
            var windSpeedValue = windSpeedNode.Attributes["value"].Value;

            var windDirectionNode = xmlDoc.SelectSingleNode("//wind/direction");
            var windDirectionValue = windDirectionNode.Attributes["value"].Value;

            var cityNode = xmlDoc.SelectSingleNode("//city");
            var cityName = cityNode.Attributes["name"].Value;

            // Hiển thị thông tin
            richTextBox1.Text = $"City/Country: {cityName}\n" +
                            $"Temperature: {tempValue} °C\n" +
                            $"Weather: {weatherDescription}\n" +
                            $"Humidity: {humidityValue}%\n" +
                            $"Pressure: {pressureValue} hPa\n" +
                            $"Wind Speed: {windSpeedValue} m/s\n" +
                            $"Wind Direction: {windDirectionValue}°\n\n\n\n Hahahahaha never doubt me ahaha !";
        }

      
    }
}
