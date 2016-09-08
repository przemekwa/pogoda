using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace pogoda
{
    public class RssApi
    {
        private const string FILE_NAME = "rss.xml";

        XmlDocument plik = new XmlDocument();

        XmlNode node;

        XmlNodeList nodes;

        XmlAttribute atrybut;

       public void CreateFile()
        {
            if (!File.Exists(FILE_NAME))
            {
                var nowy_xml = new XmlTextWriter(FILE_NAME, null);
                nowy_xml.WriteStartDocument();
                nowy_xml.WriteComment("Nazwa pliku " + FILE_NAME);
                nowy_xml.WriteStartElement("RSS");
                nowy_xml.WriteAttributeString("data", System.DateTime.Now.ToString().Substring(0, 10));
                nowy_xml.WriteAttributeString("godzina", System.DateTime.Now.ToString().Substring(11));
                nowy_xml.WriteEndElement();
                nowy_xml.Close();
            }
        }
       
        public void Add(string zrodlo)
        {
            plik.Load(FILE_NAME);
                   
            node = plik.CreateElement("zrodlo");
            node.InnerText =zrodlo;
            atrybut = plik.CreateAttribute("dataDodania");
            atrybut.Value = System.DateTime.Now.ToString().Substring(0, 10);
            node.Attributes.Append(atrybut);
            plik.DocumentElement.AppendChild(node);
            plik.Save(FILE_NAME);
               
        }
        
        public List<string> Read()
        {
            plik.Load(FILE_NAME);

            nodes = plik.SelectNodes("/RSS/zrodlo");

            return (from XmlNode n in nodes select n.InnerText).ToList();
        }
       
        public void Delete(string nazwa)
        {
            plik.Load(FILE_NAME);

            node = plik.SelectSingleNode("/RSS/zrodlo[. =\"" + nazwa + "\" ]");

            node?.ParentNode?.RemoveChild(node);
            
            plik.Save(FILE_NAME);
        }
    }
}
