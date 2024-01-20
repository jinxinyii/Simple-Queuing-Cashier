using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueue : Form
    {
        private Timer timer;
        public CashierWindowQueue()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Serving serving = new Serving();
            try
            {
                if (CashierClass.CashierQueue.Count > 0)
                {
                    serving.lblServe.Text = CashierClass.CashierQueue.Peek();
                    CashierClass.CashierQueue.Dequeue();
                    serving.ShowDialog();
                }
                else
                {
                    MessageBox.Show("THE QUEUE IS EMPTY");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"AN ERROR OCCURRED: {ex.Message}");
            }
        }   
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}
