
namespace _301207576_Ariola__Lab2
{
    partial class frmPublishNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNotifContent = new System.Windows.Forms.Label();
            this.txtNotificationContent = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnExitPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotifContent
            // 
            this.lblNotifContent.AutoSize = true;
            this.lblNotifContent.Location = new System.Drawing.Point(71, 71);
            this.lblNotifContent.Name = "lblNotifContent";
            this.lblNotifContent.Size = new System.Drawing.Size(131, 17);
            this.lblNotifContent.TabIndex = 0;
            this.lblNotifContent.Text = "Notification Content";
            // 
            // txtNotificationContent
            // 
            this.txtNotificationContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotificationContent.Location = new System.Drawing.Point(236, 66);
            this.txtNotificationContent.Name = "txtNotificationContent";
            this.txtNotificationContent.Size = new System.Drawing.Size(289, 22);
            this.txtNotificationContent.TabIndex = 1;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(74, 139);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(136, 51);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnExitPublish
            // 
            this.btnExitPublish.Location = new System.Drawing.Point(389, 139);
            this.btnExitPublish.Name = "btnExitPublish";
            this.btnExitPublish.Size = new System.Drawing.Size(136, 51);
            this.btnExitPublish.TabIndex = 3;
            this.btnExitPublish.Text = "Exit";
            this.btnExitPublish.UseVisualStyleBackColor = true;
            this.btnExitPublish.Click += new System.EventHandler(this.btnExitPublish_Click);
            // 
            // frmPublishNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 256);
            this.Controls.Add(this.btnExitPublish);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtNotificationContent);
            this.Controls.Add(this.lblNotifContent);
            this.Name = "frmPublishNotification";
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotifContent;
        private System.Windows.Forms.TextBox txtNotificationContent;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnExitPublish;
    }
}