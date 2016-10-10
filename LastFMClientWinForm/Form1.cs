using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastFMClientWinForm.ServiceReference1;

namespace LastFMClientWinForm
{
    public partial class Form1 : Form
    {
        LastFMServiceClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new LastFMServiceClient("BasicHttpBinding_ILastFMService");
            string[] tags = client.GetTopTags();
            client.Close();
            comboBox1Tags.Items.AddRange(tags);
            comboBox1Tags.FormattingEnabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        private void comboBox1Tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1Tracks.Clear();
            client = new LastFMServiceClient("BasicHttpBinding_ILastFMService");
            string[] topTracks = client.GetTopTracks(comboBox1Tags.SelectedItem.ToString());
            client.Close();

            foreach (var eachTrack in topTracks)
            {
                textBox1Tracks.AppendText(eachTrack + "\r\n");
            }
            textBox1Tracks.SelectionStart = 0;
            textBox1Tracks.ScrollToCaret();
        }
    }
}
