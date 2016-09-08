using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace pogoda
{
    public partial class Form1 : Form
    {
        public Thread trd;
        List<Message> ListaWiadomosci = new List<Message>();
        List<string> ListaRSS = new List<string>();
        RssApi xml = new RssApi();
        int MAX_ADRESY_RSS = 0;
        int AKTUALNY_ADRES_RSS = 0;
        


        public Form1()
        {
            

            InitializeComponent();
            xml.CreateFile();
            timer1.Start();
            ListaRSS = xml.Read();

            MAX_ADRESY_RSS = ListaRSS.Count;



            foreach (var adres in ListaRSS)
            {
                contextMenuStrip1.Items.Add(adres);
            }

           DawajDane(ListaRSS.ElementAt(PodajNastepnyNumeradresuRSS()));
            
            watki();
   
        }
      
   
        private void DawajDane(string adres)
        {
            var weatherModel = new WeatherApi("94cac1b2a3993022");
            
            var weatherDto = weatherModel.Get();

            label1.Text = weatherDto.Description;
            label2.Text = weatherDto.Temperature + "°C";
            label3.Text = weatherDto.TemperatureFeel + "°C";
            label4.Text = weatherDto.Pressure + "hPa";
            label6.Text = weatherDto.Location;
            pictureBox1.Load(weatherDto.Image);

            var seriwisRSS = new Rss(adres);

            ListaWiadomosci = seriwisRSS.PobierzWiadomosci(); 
        }
        private void watki()
        {

            this.Text = ListaWiadomosci.ElementAt(AKTUALNY_ADRES_RSS).NazwaRSS;
                var t = "";
                for (var i=0;i<8;i++)
                {
                    t = t + " || " + (ListaWiadomosci.ElementAt(i).tekst);
                }
                label5.Text = t;


              
                var b = new ThreadStart(delegate { PrzesuwanyTekst("                          " + t); });
                trd = new Thread(b);
                trd.Start();

        }

   
        private delegate void Delegacja();
        public void PrzesuwanyTekst(string t)
        {
            for (var i = 0; i < ((t.Length *9)); i++)
                {
                    if (label5.InvokeRequired)
                    {
                        try
                        {
                            label5.Invoke((Delegacja)delegate { label5.Location = new System.Drawing.Point(279 - i, 25); });
                            Thread.Sleep(10);
                        }
                        catch (InvalidOperationException)
                        {
                        }
                    }
                    else
                    {
                        label5.Location = new System.Drawing.Point(279 - i, 66);
                        Thread.Sleep(10);
                    }
            }
         
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == (char)113)
                {
                    trd.Abort();
                    DawajDane(ListaRSS.ElementAt(PodajPoprzedniNumeradresuRSS()));
                    watki();

                }
                if (e.KeyChar == (char)119)
                {
                    trd.Abort();
                    DawajDane(ListaRSS.ElementAt(PodajNastepnyNumeradresuRSS()));
                    watki();
                }
           

           
            
        }

        private int PodajNastepnyNumeradresuRSS()
        {
            if (AKTUALNY_ADRES_RSS < MAX_ADRESY_RSS-1) 
            {
                AKTUALNY_ADRES_RSS++;
                return AKTUALNY_ADRES_RSS;
            }
            else
            {
                return AKTUALNY_ADRES_RSS = 0;
            }
            

        }
        private int PodajPoprzedniNumeradresuRSS()
        {
            if (AKTUALNY_ADRES_RSS < (MAX_ADRESY_RSS-1) && AKTUALNY_ADRES_RSS > 0)
            {
                AKTUALNY_ADRES_RSS--;
                return AKTUALNY_ADRES_RSS;
            }
            else
            {
                return AKTUALNY_ADRES_RSS = 0;
            }


        }
        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new dodaj().Show();
        }
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
          
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var a =  e.ClickedItem;

            if (a.Text != "Dodaj RSS" && a.Text != "Usuń RSS")
            { 
                trd.Abort();
                DawajDane(e.ClickedItem.Text);
                watki();
            }
        }


       

        private void dodajToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var nowyRss = new Form2();
            nowyRss.Show();
        }

        private void usuńRSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usunRss = new Form3();
            usunRss.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            trd.Abort();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ListaRSS = xml.Read();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1_KeyPress(this,new KeyPressEventArgs((char)119));

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

     
     

    















       
    }
}
