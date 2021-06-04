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
using System.IO;

namespace LAB4
{
    public partial class ViewSourcePage : Form
    {
        public string url;
        public ViewSourcePage()
        {
            InitializeComponent();
        }

        private void ViewSourcePage_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(url);
            
            // Get the response.
            WebResponse response = request.GetResponse();
            Stream dataStream;
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                HTMLcontent.Text = responseFromServer;
            }
        }
    }
}
