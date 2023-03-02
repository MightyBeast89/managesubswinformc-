using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301207576_Ariola__Lab2
{
    public class NotificationManager
    {
        public delegate void SendNotification(string message);
        public SendNotification Notify;

        private List<EmailSubscriber> emailsubscribers = new List<EmailSubscriber>();
        private List<MobileSubscriber> mobilesubscribers = new List<MobileSubscriber>();
        
        
        public void PublishNotification(string message)
        {            
            
            foreach (var subscriber in emailsubscribers)
            {
                Console.WriteLine("Notification sent to " + subscriber.Email + " with the following message " + message);
                //MessageBox.Show(subscriber.Email);
            }
            foreach (var psubscriber in mobilesubscribers)
            {
                Console.WriteLine("Notification sent to " + psubscriber.MobileNumber + " with the following message " + message);
            }
            MessageBox.Show("Notification sent to all");
        }

        public void SubscribeEmail(string email)
        {
            //Notify += PublishNotification;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Enter a valid email address");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid Email Address");
                return;
            }
            
            if (!IsDuplicate(email))
            {
                emailsubscribers.Add(new EmailSubscriber(email));
                MessageBox.Show("Email successfully subscribe to receive notification");
                
            }
            else
            {
                MessageBox.Show("Email already subscribed");
                return;
            }            
            
        }
        //method for mobile subscriber
        public void MobileSubscriber(string mobile)
        {
            //Notify += PublishNotification;
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Enter Mobile Number");
                return;
            }
            if (!IsValidPhoneNumber(mobile))
            {
                MessageBox.Show("Invalid Phone Number format");
                return;
            }
            if (!IsDuplicatePhoneNumber(mobile))
            {
                mobilesubscribers.Add(new MobileSubscriber(mobile));
                MessageBox.Show("Phone Number successfully subscribe to receive notification");
                
            }
            else
            {
                MessageBox.Show("Phone Number already subscribed");
                return;
            }
        }

        bool IsValidPhoneNumber(string phoneNumber)
        {
            try
            {
                return Regex.IsMatch(phoneNumber, @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");
            }
            catch (Exception e)
            {
                return false;
            }

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsDuplicate(string email)
        {
            return emailsubscribers.Exists(s => s.Email == email);
        }

        private bool IsDuplicatePhoneNumber(string mobile)
        {
            return mobilesubscribers.Exists(s => s.MobileNumber == mobile);
        }

        public void UnsubscribeEmail(string email)
        {
            //Notify -= PublishNotification;
            EmailSubscriber esubscriber = emailsubscribers.Find(s => s.Email == email);

            if (esubscriber != null)
            {
                emailsubscribers.Remove(esubscriber);
                MessageBox.Show("Unsubscribed " + email + " from receiving notification");
            }
            else
            {
                MessageBox.Show("Email not found");
            }
            
        }
        
        public void UnsubscribedMobile(string mobile)
        {
            //Notify -= PublishNotification;
            MobileSubscriber msubscriber = mobilesubscribers.Find(s => s.MobileNumber == mobile);
            
            if(msubscriber != null)
            {
                mobilesubscribers.Remove(msubscriber);
                MessageBox.Show("Unsubscribed " + mobile + " from receiving notification");
            }
        }
        
    }
}
