
namespace MyTransportApp.Forms
{
    partial class FormHauptmenu
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
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.labelHauptmenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNavigationZurStation = new System.Windows.Forms.Button();
            this.buttonAbfahrtstafel = new System.Windows.Forms.Button();
            this.buttonStationenInDerNähe = new System.Windows.Forms.Button();
            this.buttonAbbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(117, 175);
            this.buttonVerbindungenSuchen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(397, 70);
            this.buttonVerbindungenSuchen.TabIndex = 0;
            this.buttonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.ButtonVerbindungenSuchen_Click);
            // 
            // labelHauptmenu
            // 
            this.labelHauptmenu.AutoSize = true;
            this.labelHauptmenu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHauptmenu.Location = new System.Drawing.Point(26, 43);
            this.labelHauptmenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHauptmenu.Name = "labelHauptmenu";
            this.labelHauptmenu.Size = new System.Drawing.Size(624, 65);
            this.labelHauptmenu.TabIndex = 1;
            this.labelHauptmenu.Text = "Was möchten Sie machen?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 13);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonNavigationZurStation
            // 
            this.buttonNavigationZurStation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNavigationZurStation.Location = new System.Drawing.Point(117, 255);
            this.buttonNavigationZurStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNavigationZurStation.Name = "buttonNavigationZurStation";
            this.buttonNavigationZurStation.Size = new System.Drawing.Size(397, 70);
            this.buttonNavigationZurStation.TabIndex = 3;
            this.buttonNavigationZurStation.Text = "Navigation zur Station";
            this.buttonNavigationZurStation.UseVisualStyleBackColor = true;
            this.buttonNavigationZurStation.Click += new System.EventHandler(this.ButtonNavigationZurStation_Click);
            // 
            // buttonAbfahrtstafel
            // 
            this.buttonAbfahrtstafel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAbfahrtstafel.Location = new System.Drawing.Point(117, 335);
            this.buttonAbfahrtstafel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAbfahrtstafel.Name = "buttonAbfahrtstafel";
            this.buttonAbfahrtstafel.Size = new System.Drawing.Size(397, 70);
            this.buttonAbfahrtstafel.TabIndex = 5;
            this.buttonAbfahrtstafel.Text = "Abfahrtstafel";
            this.buttonAbfahrtstafel.UseVisualStyleBackColor = true;
            this.buttonAbfahrtstafel.Click += new System.EventHandler(this.ButtonAbfahrtstafel_Click);
            // 
            // buttonStationenInDerNähe
            // 
            this.buttonStationenInDerNähe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStationenInDerNähe.Location = new System.Drawing.Point(117, 415);
            this.buttonStationenInDerNähe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStationenInDerNähe.Name = "buttonStationenInDerNähe";
            this.buttonStationenInDerNähe.Size = new System.Drawing.Size(397, 70);
            this.buttonStationenInDerNähe.TabIndex = 6;
            this.buttonStationenInDerNähe.Text = "Stationen in der Nähe";
            this.buttonStationenInDerNähe.UseVisualStyleBackColor = true;
            this.buttonStationenInDerNähe.Click += new System.EventHandler(this.ButtonStationenInDerNähe_Click);
            // 
            // buttonAbbruch
            // 
            this.buttonAbbruch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAbbruch.Location = new System.Drawing.Point(457, 510);
            this.buttonAbbruch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAbbruch.Name = "buttonAbbruch";
            this.buttonAbbruch.Size = new System.Drawing.Size(171, 70);
            this.buttonAbbruch.TabIndex = 7;
            this.buttonAbbruch.Text = "Abbrechen";
            this.buttonAbbruch.UseVisualStyleBackColor = true;
            this.buttonAbbruch.Click += new System.EventHandler(this.ButtonAbbruch_Click);
            // 
            // FormHauptmenu
            // 
            this.AcceptButton = this.buttonVerbindungenSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAbbruch;
            this.ClientSize = new System.Drawing.Size(651, 633);
            this.Controls.Add(this.buttonAbbruch);
            this.Controls.Add(this.buttonStationenInDerNähe);
            this.Controls.Add(this.buttonAbfahrtstafel);
            this.Controls.Add(this.buttonNavigationZurStation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelHauptmenu);
            this.Controls.Add(this.buttonVerbindungenSuchen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHauptmenu";
            this.Text = "Haupmenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHauptmenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.Label labelHauptmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNavigationZurStation;
        private System.Windows.Forms.Button buttonAbfahrtstafel;
        private System.Windows.Forms.Button buttonStationenInDerNähe;
        private System.Windows.Forms.Button buttonAbbruch;
    }
}