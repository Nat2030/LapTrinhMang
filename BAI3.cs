using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Menu
{
    public partial class BAI3 : Form
    {
        public BAI3()
        {
            InitializeComponent();
        }

        WebResponse response;

        private void Downloadbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Getrequest();
                Downloadfile();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }                   
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Browse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }          
        }

        private void Getrequest()
        {
            WebRequest request = WebRequest.Create(Urltext.Text);
            response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string data = reader.ReadToEnd();
            Showtext.Text = data;
        }

        private void Downloadfile()
        {
            WebClient myClient = new WebClient();
            Stream read = myClient.OpenRead(Urltext.Text);
            try
            {
                myClient.DownloadFile(Urltext.Text, Pathtext.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Browse()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
            Pathtext.Text = di.FullName;
        }
    }
}