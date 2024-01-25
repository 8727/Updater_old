using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            if (!startIp)
            {
                send = $"Incorrect Start address: {Start_IP.Text}";
            };
            if ((!startIp) & (!stopIp))
            {
                send += "\n";
            }
            if (!stopIp)
            {
                send += $"Incorrect Stop address: {Stop_IP.Text}";
            }
            if ((!startIp) | (!stopIp))
            {
                MessageBox.Show(send, "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
/*            panel1.Controls.Clear();
            panel1.Controls.Add(this.LabelInfo);
            LabelInfo.Text = "Search...";*/

            //panel1.Controls.Clear();
            //panel1.Controls.Add(this.LabelInfo);
            //LabelInfo.Text = "Not found.";

            panel1.Controls.Clear();


            Console.Write("No! ");




            panel1.Controls.Add(this.listView1);





            

            Scan_IP.Search();

            //LabelSearch.TabIndex = 1;


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
