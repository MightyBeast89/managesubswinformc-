using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301207576_Ariola__Lab2
{
    public partial class frmNotificationManager : Form
    {
        public frmNotificationManager()
        {
            InitializeComponent();
        }

        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            frmManageSubscription formManageSubs = new frmManageSubscription();
            formManageSubs.ShowDialog();
            btnPublishNotification.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            frmPublishNotification formPubNotification = new frmPublishNotification();
            formPubNotification.Show();
        }
    }
}
