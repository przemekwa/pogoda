using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace pogoda
{
    class pogoda
    {
        string key = "";

        XmlDocument xml = new XmlDocument();

        public double temperatura { get; set; }
        public double temperatura_odczuwalna { get; set; }
        public double wiatr { get; set; }
        public double cisnienie { get; set; }
        public string opis { get; set; }
        public string obrazek { get; set; }
        public string lokalizacja { get; set; }

        public pogoda(string a)
        {
            key = a;
        }

        private void start()
        {
            xml.Load("http://api.wunderground.com/api/"+key+"/geolookup/conditions/conditions/lang:PL/q/Poland/Poznan.xml");
           
        }

        public void pobierzPogode()
        {
            start();

            XmlNodeList nodelist = xml.GetElementsByTagName("temp_c");
            foreach (XmlNode node in nodelist)
            {
             temperatura = double.Parse(node.InnerText);
            }

            nodelist = xml.GetElementsByTagName("windchill_c");
            foreach (XmlNode node in nodelist)
            {
                try
                {
                    temperatura_odczuwalna = double.Parse(node.InnerText);
                }
                catch (FormatException)
                {
                    temperatura_odczuwalna = temperatura;
                }

            }

            XmlNode city = xml.SelectSingleNode("/response/location/city");

            lokalizacja = (city.InnerText);
            

            nodelist = xml.GetElementsByTagName("weather");
            foreach (XmlNode node in nodelist)
            {
                opis = (node.InnerText).ToString();
            }

            nodelist = xml.GetElementsByTagName("pressure_mb");
            foreach (XmlNode node in nodelist)
            {
                cisnienie = double.Parse(node.InnerText);
            }

            nodelist = xml.GetElementsByTagName("wind_kph");
            foreach (XmlNode node in nodelist)
            {
                wiatr= double.Parse(node.InnerText);
            }

            nodelist = xml.GetElementsByTagName("icon_url");
            foreach (XmlNode node in nodelist)
            {
                obrazek = (node.InnerText).ToString();
            }
        }
    }
}
