﻿
namespace pogoda
{
    using System.Collections.Generic;
    using System.Xml;
    using System.Linq;

    public class RssParser
    {
        public string Url { get; set; }

        public RssParser(string url)
        {
            this.Url = url;
        }

        public IEnumerable<Message> GetMessages()
        {
            var xml = new XmlDocument();

            xml.Load(Url);

            return xml.GetElementsByTagName("item").Cast<XmlNode>().Select(node => new Message
            {
                tytul = node.SelectSingleNode("title")?.InnerText,
                tekst = RemoveImage(node.SelectSingleNode("description")?.InnerText),
                data = node.SelectSingleNode("pubDate")?.InnerText,
                NazwaRSS = xml.GetElementsByTagName("title").Cast<XmlNode>().FirstOrDefault()?.InnerText
            });
        }

        private string RemoveImage(string innerText)
        {
            if (innerText == null)
            {
                return string.Empty;
            }

            innerText = innerText.Substring(innerText.IndexOf(">") + 1);

            return innerText.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ").Replace("  ", "");
        }
    }
}
