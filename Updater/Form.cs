using System;
using System.IO;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Updater
{
    public partial class Ui : Form
    {
        public Ui()
        {
            InitializeComponent();


        }

        void Ui_Load(object sender, EventArgs e)
        {
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;

            foreach (string s in sAll.AllKeys)
                Stop_IP.Text = ("Key: " + s + " Value: " + sAll.Get(s));

            //Start_IP.Text = sAll.Get("Key0");
            //Stop_IP.Text = "192.168.88.19";

        }

        void Search_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            bool startIp = regex.IsMatch(Start_IP.Text);
            bool stopIp = regex.IsMatch(Stop_IP.Text);
            string send = "";
            if(!startIp)
            {
                send = $"Incorrect Start address: {Start_IP.Text}";
            };
            if((!startIp) & (!stopIp))
            {
                send += "\n";
            }
            if(!stopIp)
            {
                send += $"Incorrect Stop address: {Stop_IP.Text}";
            }
            if ((!startIp) | (!stopIp))
            {
                MessageBox.Show(send, "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Scan_IP.Search();


        }

        void Save_Click(object sender, EventArgs e)
        {

        }

        void Select_Click(object sender, EventArgs e)
        {

        }

        void Update_Click(object sender, EventArgs e)
        {

        }
    }
}
