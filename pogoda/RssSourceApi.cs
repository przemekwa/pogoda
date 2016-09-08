
namespace pogoda
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Xml;
    using System.IO;

    public class RssSourceApi
    {
        private const string FILE_NAME = "rss.xml";

        public void CreateFile()
        {
           if (File.Exists(FILE_NAME))
           {
               return;
           }

           var newXml = new XmlTextWriter(FILE_NAME, null);

           newXml.WriteStartDocument();
           newXml.WriteComment("Nazwa pliku " + FILE_NAME);
           newXml.WriteStartElement("RSS");
           newXml.WriteAttributeString("data", DateTime.Now.ToString(CultureInfo.InvariantCulture).Substring(0, 10));
           newXml.WriteAttributeString("godzina", DateTime.Now.ToString(CultureInfo.InvariantCulture).Substring(11));
           newXml.WriteEndElement();

           newXml.Close();
        }
       
        public void Add(string rssSource)
        {
            var xml = new XmlDocument();

            xml.Load(FILE_NAME);

            var xmlNode = xml.CreateElement("zrodlo");

            xmlNode.InnerText = rssSource;

            var xmlAttribute = xml.CreateAttribute("dataDodania");

            xmlAttribute.Value = DateTime.Now.ToString(CultureInfo.InvariantCulture).Substring(0, 10);
            xmlNode.Attributes?.Append(xmlAttribute);
            xml.DocumentElement?.AppendChild(xmlNode);

            xml.Save(FILE_NAME);
        }
        
        public List<string> Read()
        {
            var xml = new XmlDocument();

            xml.Load(FILE_NAME);

            var xmlNodeList = xml.SelectNodes("/RSS/zrodlo");

            return (from XmlNode n in xmlNodeList select n.InnerText).ToList();
        }
       
        public void Delete(string nazwa)
        {
            var xml = new XmlDocument();

            xml.Load(FILE_NAME);

            var xmlNode = xml.SelectSingleNode("/RSS/zrodlo[. =\"" + nazwa + "\" ]");

            xmlNode?.ParentNode?.RemoveChild(xmlNode);
            
            xml.Save(FILE_NAME);
        }
    }
}
