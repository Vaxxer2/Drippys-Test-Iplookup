using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ytlookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string geoip = wc.DownloadString("https://ipinfo.io/" + textBox1.Text);
            richTextBox1.Text = geoip;
        }
    }
}
