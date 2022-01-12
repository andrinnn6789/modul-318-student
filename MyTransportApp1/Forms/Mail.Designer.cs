namespace MyTransportApp.Forms
{
    partial class Mail
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
            this.textBoxToSendTo = new System.Windows.Forms.TextBox();
            this.textBoxToSubject = new System.Windows.Forms.TextBox();
            this.textBoxBodyPart = new System.Windows.Forms.TextBox();
            this.labelToSendTo = new System.Windows.Forms.Label();
            this.labelToSubject = new System.Windows.Forms.Label();
            this.labelBodyPart = new System.Windows.Forms.Label();
            this.buttonsucheNachStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxToSendTo
            // 
            this.textBoxToSendTo.Location = new System.Drawing.Point(100, 47);
            this.textBoxToSendTo.Name = "textBoxToSendTo";
            this.textBoxToSendTo.Size = new System.Drawing.Size(291, 23);
            this.textBoxToSendTo.TabIndex = 0;
            // 
            // textBoxToSubject
            // 
            this.textBoxToSubject.Location = new System.Drawing.Point(100, 76);
            this.textBoxToSubject.Name = "textBoxToSubject";
            this.textBoxToSubject.Size = new System.Drawing.Size(291, 23);
            this.textBoxToSubject.TabIndex = 1;
            // 
            // textBoxBodyPart
            // 
            this.textBoxBodyPart.Location = new System.Drawing.Point(100, 105);
            this.textBoxBodyPart.Multiline = true;
            this.textBoxBodyPart.Name = "textBoxBodyPart";
            this.textBoxBodyPart.Size = new System.Drawing.Size(291, 135);
            this.textBoxBodyPart.TabIndex = 2;
            // 
            // labelToSendTo
            // 
            this.labelToSendTo.AutoSize = true;
            this.labelToSendTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelToSendTo.Location = new System.Drawing.Point(12, 45);
            this.labelToSendTo.Name = "labelToSendTo";
            this.labelToSendTo.Size = new System.Drawing.Size(62, 21);
            this.labelToSendTo.TabIndex = 3;
            this.labelToSendTo.Text = "To Mail:";
            // 
            // labelToSubject
            // 
            this.labelToSubject.AutoSize = true;
            this.labelToSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelToSubject.Location = new System.Drawing.Point(12, 74);
            this.labelToSubject.Name = "labelToSubject";
            this.labelToSubject.Size = new System.Drawing.Size(76, 21);
            this.labelToSubject.TabIndex = 4;
            this.labelToSubject.Text = "Mail Titel:";
            // 
            // labelBodyPart
            // 
            this.labelBodyPart.AutoSize = true;
            this.labelBodyPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBodyPart.Location = new System.Drawing.Point(12, 105);
            this.labelBodyPart.Name = "labelBodyPart";
            this.labelBodyPart.Size = new System.Drawing.Size(82, 21);
            this.labelBodyPart.TabIndex = 5;
            this.labelBodyPart.Text = "Mail Body:";
            // 
            // buttonsucheNachStation
            // 
            this.buttonsucheNachStation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonsucheNachStation.Location = new System.Drawing.Point(429, 47);
            this.buttonsucheNachStation.Name = "buttonsucheNachStation";
            this.buttonsucheNachStation.Size = new System.Drawing.Size(123, 79);
            this.buttonsucheNachStation.TabIndex = 17;
            this.buttonsucheNachStation.Text = "Send";
            this.buttonsucheNachStation.UseVisualStyleBackColor = true;
            this.buttonsucheNachStation.Click += new System.EventHandler(this.ButtonSendMail_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 280);
            this.Controls.Add(this.buttonsucheNachStation);
            this.Controls.Add(this.labelBodyPart);
            this.Controls.Add(this.labelToSubject);
            this.Controls.Add(this.labelToSendTo);
            this.Controls.Add(this.textBoxBodyPart);
            this.Controls.Add(this.textBoxToSubject);
            this.Controls.Add(this.textBoxToSendTo);
            this.Name = "Mail";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxToSendTo;
        private System.Windows.Forms.TextBox textBoxToSubject;
        private System.Windows.Forms.TextBox textBoxBodyPart;
        private System.Windows.Forms.Label labelToSendTo;
        private System.Windows.Forms.Label labelToSubject;
        private System.Windows.Forms.Label labelBodyPart;
        private System.Windows.Forms.Button buttonsucheNachStation;
    }
}