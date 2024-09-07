using auto_subscribe_youtube.Logic;
using auto_subscribe_youtube.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_subscribe_youtube
{
    public partial class Main : Form
    {
        string _channelsPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Resources\\";
        Json_Services JsonServices = new Json_Services();
        public Main()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            dataGridView1.Columns["cl_Channel"].Width = 100;
            dataGridView1.Columns["cl_Link"].Width = 300;
            List<Youtube> youtubes = JsonServices.ReadFile(_channelsPath + "channels.json");
            dataGridView1.DataSource = youtubes;
        }
    }
}
