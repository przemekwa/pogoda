using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace pogoda
{
    class rss
    {
        public string strona = "";
        List<wiadomosc> Lista = new List<wiadomosc>();

        XmlDocument xml = new XmlDocument();
 
        public rss(string adres)
        {
            strona = adres;
           
        }

        public List<wiadomosc> PobierzWiadomosci()
        {
            Xml();

                string nazwa = "";


                XmlNodeList nodelist2 = xml.GetElementsByTagName("title");

                foreach (XmlNode node in nodelist2)
                {
                    nazwa = node.InnerText;
                    break;
                }




                XmlNodeList nodelist = xml.GetElementsByTagName("item");




                foreach (XmlNode node in nodelist)
                {
                    string tytul = node.SelectSingleNode("title").InnerText;
                    string tekst = node.SelectSingleNode("description").InnerText;
                    tekst = UsunObrazek(tekst);
                    string data = node.SelectSingleNode("pubDate").InnerText;
                    wiadomosc a = new wiadomosc(tytul, tekst, data, nazwa);
                    Lista.Add(a);
                }


            
           

            return Lista;
        }

        string UsunObrazek(string t)
        {
            t = t.Substring(t.IndexOf(">") + 1);
            return t.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ").Replace("  ","");

        }




        string sprawdzWersje()
        {
            string wersja = "" ;
            XmlNodeList nodelist2 = xml.GetElementsByTagName("rss");

            foreach (XmlNode node in nodelist2)
            {
                wersja = node.Attributes["version"].InnerText;
                break;
            }


            return wersja;
        }

        private void Xml()
        {
            try
            {
                xml.Load(strona);
            }
            catch (ArgumentNullException)
            {
                xml.Load("http://rss.gazeta.pl/pub/rss/wiadomosci.xml");
                MessageBox.Show("Błąd w adresie xml-a. Zostanie wczytany rss gazeta.pl", "Poważny", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            catch (XmlException)
            {
                xml.Load("http://rss.gazeta.pl/pub/rss/wiadomosci.xml");
            }

            
        }


    }
}
