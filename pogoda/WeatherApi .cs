using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace pogoda
{
    public class WeatherApi
    {
        private readonly string key;
        private readonly XmlDocument xml;

        public WeatherApi(string key)
        {
            this.key = key;
            this.xml = new XmlDocument();
        }

        public WeatherDto Get()
        {
            var wetherDto = new WeatherDto();

            xml.Load("http://api.wunderground.com/api/" + key +
                     "/geolookup/conditions/conditions/lang:PL/q/Poland/Poznan.xml");


            foreach (XmlNode node in xml.GetElementsByTagName("temp_c"))
            {
                wetherDto.Temperature = double.Parse(node.InnerText);
            }

            foreach (XmlNode node in xml.GetElementsByTagName("windchill_c"))
            {
                try
                {
                    wetherDto.TemperatureFeel = double.Parse(node.InnerText);
                }
                catch (FormatException)
                {
                    wetherDto.TemperatureFeel = wetherDto.Temperature;
                }
            }

             wetherDto.Location = xml.SelectSingleNode("/response/location/city")?.InnerText;

            foreach (XmlNode node in xml.GetElementsByTagName("weather"))
            {
                wetherDto.Description = node.InnerText;
            }

            foreach (XmlNode node in xml.GetElementsByTagName("pressure_mb"))
            {
                wetherDto.Pressure = double.Parse(node.InnerText);
            }

            foreach (XmlNode node in xml.GetElementsByTagName("wind_kph"))
            {
                wetherDto.Wind = double.Parse(node.InnerText);
            }

            foreach (XmlNode node in xml.GetElementsByTagName("icon_url"))
            {
                wetherDto.Image = node.InnerText;
            }

            return wetherDto;
        }
    }
}
