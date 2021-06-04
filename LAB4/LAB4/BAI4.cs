using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;

namespace LAB4
{
    public partial class BAI4 : Form
    {
        public string URL;
        public BAI4()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            URL = LocationBar.Text.Trim();
            if (String.IsNullOrWhiteSpace(URL) || URL.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                LocationBar.Focus();
                return;
            }
            NavigateToURL(URL);
        }

        private void NavigateToURL(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url += "http://";
            }

            try
            {
                myBrowser.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void viewSource_Click(object sender, EventArgs e)
        {
            ViewSourcePage vsp = new ViewSourcePage();
            vsp.url = URL;
            vsp.Show();
        }

        private void downPage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
