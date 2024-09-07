using System;
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
        public Main()
        {
            InitializeComponent();
            dataGridView1.Columns["cl_Channel"].Width = 100;
            dataGridView1.Columns["cl_Link"].Width = 300;
        }
    }
}
