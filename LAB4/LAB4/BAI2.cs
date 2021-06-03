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
    public partial class BAI2 : Form
    {
        public BAI2()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // Create a request using a URL that can receive a post.
            if (string.IsNullOrWhiteSpace(dataBox.Text))
            {
                MessageBox.Show("Please enter data before requesting server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WebRequest request = WebRequest.Create(URL.Text);
            request.Credentials = CredentialCache.DefaultCredentials;
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // convert data to a byte array.
            byte[] bytesSend = Encoding.UTF8.GetBytes(dataBox.Text);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = bytesSend.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(bytesSend, 0, bytesSend.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
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