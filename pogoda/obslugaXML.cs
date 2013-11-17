using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace pogoda
{
    class obslugaXML
    {

        string nazwaPliku;

        XmlDocument plik = new XmlDocument();

        XmlNode node;

        XmlNodeList nodes;

        XmlAttribute atrybut;


        public obslugaXML()
        {
            nazwaPliku = "rss.xml";
        }

        public void StworzXMLa()
        {

            if (!CzyIstniejePlik())
            {
                XmlTextWriter nowy_xml = new XmlTextWriter(nazwaPliku, null);
                nowy_xml.WriteStartDocument();
                nowy_xml.WriteComment("Nazwa pliku " + nazwaPliku);
                nowy_xml.WriteStartElement("RSS");
                nowy_xml.WriteAttributeString("data", System.DateTime.Now.ToString().Substring(0, 10));
                nowy_xml.WriteAttributeString("godzina", System.DateTime.Now.ToString().Substring(11));
                nowy_xml.WriteEndElement();
                nowy_xml.Close();
            }
        }
       
        public void Dodaj(string zrodlo)
        {
            plik.Load(nazwaPliku);
                   
            node = plik.CreateElement("zrodlo");
            node.InnerText =zrodlo;
            atrybut = plik.CreateAttribute("dataDodania");
            atrybut.Value = System.DateTime.Now.ToString().Substring(0, 10);
            node.Attributes.Append(atrybut);
            plik.DocumentElement.AppendChild(node);
            plik.Save(nazwaPliku);
               
        }
        
        public List<string> Odczytaj()
        {
            List<string> l = new List<string>();

            plik.Load(nazwaPliku);
            nodes = plik.SelectNodes("/RSS/zrodlo");

            foreach (XmlNode n in nodes)
            {
               l.Add(n.InnerText);
            }
            return l;
        }
       
        public void Usun(string nazwa)
        {
            plik.Load(nazwaPliku);

            node = plik.SelectSingleNode("/RSS/zrodlo[. =\"" + nazwa + "\" ]");
            node.ParentNode.RemoveChild(node);
            
            plik.Save(nazwaPliku);
        }

        bool CzyIstniejePlik()
        {
            string[] files = Directory.GetFiles(".", nazwaPliku);

            if (files.Length == 0)
            {
                return false;
            }

            return true;
        }


    }
}
