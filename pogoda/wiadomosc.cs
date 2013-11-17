using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pogoda
{
    class wiadomosc
    {
        public string tytul { get; set; }
        public string tekst { get; set; }
        public string data { get; set; }
        public string NazwaRSS { get; set; }


        public wiadomosc(string title, string text,string DataPublikacji,string Nazwa)
        {
            tytul = title;
            tekst = text;
            data = DataPublikacji;
            NazwaRSS = Nazwa;
        }

    }
}
