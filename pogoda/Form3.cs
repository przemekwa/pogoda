using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pogoda
{
    public partial class Form3 : Form
    {
        RssSourceApi xml = new RssSourceApi();
        public Form3()
        {
            InitializeComponent();
            List<string> ListaRss = new List<string>();
            ListaRss = xml.Read();
            foreach (string r in ListaRss)
            {
                listBox1.Items.Add(r);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            xml.Delete(listBox1.Items[listBox1.SelectedIndex].ToString());
            this.Close();
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
