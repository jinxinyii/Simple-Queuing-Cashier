using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class Serving : Form
    {
        public Serving()
        {
            InitializeComponent();
            timer2 = new Timer();
            timer2.Interval = (10 * 1000);
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
