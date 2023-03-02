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
    public partial class frmManageSubscription : Form
    {
        public static NotificationManager manager = new NotificationManager();

        
        public frmManageSubscription()
        {
            InitializeComponent();
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            txtSMS.Enabled = true;
            txtSMS.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if(chkEmail.Checked == true)
            {
                string email = txtEmail.Text;                         
                manager.SubscribeEmail(email);
                txtEmail.Text = "";

             }
            if(chkSMS.Checked == true )
            {
                string mobile = txtSMS.Text;
                manager.MobileSubscriber(mobile);
                txtSMS.Text = "";

            }        


        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            if (chkEmail.Checked == true)
            {
                string email = txtEmail.Text;
                manager.UnsubscribeEmail(email);
                txtEmail.Text = "";
            }
            if (chkSMS.Checked == true)
            {
                string mobile = txtSMS.Text;
                manager.UnsubscribedMobile(mobile);
                txtSMS.Text = "";
            }
        }
    }
}
