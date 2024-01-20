using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CashierWindowQueue cwq = new CashierWindowQueue();
            cwq.Show();
        }
    }
}
