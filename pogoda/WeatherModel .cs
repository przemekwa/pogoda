using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace pogoda
{
    public class WeatherModel
    {
        private readonly string key;

        private readonly XmlDocument xml;
        private readonly WeatherDto weatherDto;

        public WeatherModel(string key)
        {
            this.key = key;
            this.xml = new XmlDocument();
            weatherDto = new WeatherDto();
        }

        public WeatherDto Get()
        {
            var wetherDto = new WeatherDto();
            
            xml.Load("http://api.wunderground.com/api/" + key + "/geolookup/conditions/conditions/lang:PL/q/Poland/Poznan.xml");

            XmlNodeList nodelist = xml.GetElementsByTagName("temp_c");
            foreach (XmlNode node in nodelist)
            {
                wetherDto.temperatura = double.Parse(node.InnerText);
            }

            nodelist = xml.GetElementsByTagName("windchill_c");
            foreach (XmlNode node in nodelist)
            {
                try
                {
                    wetherDto.temperatura_odczuwalna = double.Parse(node.InnerText);
                }
                catch (FormatException)
                { 

                    wetherDto.temperatura_odczuwalna = wetherDto.temperatura;
                }

            }

            XmlNode city = xml.SelectSingleNode("/response/location/city");

            wetherDto.lokalizacja = (city.InnerText);
            

            nodelist = xml.GetElementsByTagName("weather");
            foreach (XmlNode node in nodelist)
            {
                wetherDto.opis = (node.InnerText).ToString();
            }

            nodelist = xml.GetElementsByTagName("pressure_mb");
            foreach (XmlNode node in nodelist)
            {
                wetherDto.cisnienie = double.Parse(node.InnerText);
            }

            nodelist = xml.GetElementsByTagName("wind_kph");
            foreach (XmlNode node in nodelist)
            {
                wetherDto.wiatr= double.Parse(node.InnerText);
            }

            nodelist = xml.GetElementsByTagName("icon_url");
            foreach (XmlNode node in nodelist)
            {
                wetherDto.obrazek = (node.InnerText).ToString();
            }

            return wetherDto;
        }
    }
}
