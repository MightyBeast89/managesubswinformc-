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
    public partial class frmPublishNotification : Form
    {
        NotificationManager manager;
        
        public frmPublishNotification()
        {
            InitializeComponent();
           
            manager = frmManageSubscription.manager;
            manager.Notify += manager.PublishNotification;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            
            string message = txtNotificationContent.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Enter a message to publish");
                return;
            }
            

            manager.Notify.Invoke(message);
            
            txtNotificationContent.Text = "";               
            
        }

        private void btnExitPublish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
