using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pogoda
{
    class Message
    {
        public string tytul { get; set; }
        public string tekst { get; set; }
        public string data { get; set; }
        public string NazwaRSS { get; set; }


        public Message(string title, string text,string DataPublikacji,string Nazwa)
        {
            tytul = title;
            tekst = text;
            data = DataPublikacji;
            NazwaRSS = Nazwa;
        }

    }
}
