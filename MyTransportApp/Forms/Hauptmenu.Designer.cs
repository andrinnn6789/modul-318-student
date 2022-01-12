
namespace MyTransportApp
{
    partial class FormHauptmenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHauptseiteTitel = new System.Windows.Forms.Label();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.buttonNavigationZurStation = new System.Windows.Forms.Button();
            this.buttonAbfahrtstafel = new System.Windows.Forms.Button();
            this.buttonStationenInDerNähe = new System.Windows.Forms.Button();
            this.buttonAbbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHauptseiteTitel
            // 
            this.labelHauptseiteTitel.AutoSize = true;
            this.labelHauptseiteTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHauptseiteTitel.Location = new System.Drawing.Point(42, 35);
            this.labelHauptseiteTitel.Name = "labelHauptseiteTitel";
            this.labelHauptseiteTitel.Size = new System.Drawing.Size(397, 37);
            this.labelHauptseiteTitel.TabIndex = 0;
            this.labelHauptseiteTitel.Text = "Was wollen Sie machen?";
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(83, 105);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(313, 43);
            this.buttonVerbindungenSuchen.TabIndex = 1;
            this.buttonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.buttonVerbindungenSuchen_Click);
            // 
            // buttonNavigationZurStation
            // 
            this.buttonNavigationZurStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavigationZurStation.Location = new System.Drawing.Point(83, 164);
            this.buttonNavigationZurStation.Name = "buttonNavigationZurStation";
            this.buttonNavigationZurStation.Size = new System.Drawing.Size(313, 43);
            this.buttonNavigationZurStation.TabIndex = 2;
            this.buttonNavigationZurStation.Text = "Navigation zur Station";
            this.buttonNavigationZurStation.UseVisualStyleBackColor = true;
            this.buttonNavigationZurStation.Click += new System.EventHandler(this.buttonNavigationZurStation_Click);
            // 
            // buttonAbfahrtstafel
            // 
            this.buttonAbfahrtstafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbfahrtstafel.Location = new System.Drawing.Point(83, 223);
            this.buttonAbfahrtstafel.Name = "buttonAbfahrtstafel";
            this.buttonAbfahrtstafel.Size = new System.Drawing.Size(313, 43);
            this.buttonAbfahrtstafel.TabIndex = 3;
            this.buttonAbfahrtstafel.Text = "Abfahrtstafel";
            this.buttonAbfahrtstafel.UseVisualStyleBackColor = true;
            this.buttonAbfahrtstafel.Click += new System.EventHandler(this.buttonAbfahrtstafel_Click);
            // 
            // buttonStationenInDerNähe
            // 
            this.buttonStationenInDerNähe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStationenInDerNähe.Location = new System.Drawing.Point(83, 283);
            this.buttonStationenInDerNähe.Name = "buttonStationenInDerNähe";
            this.buttonStationenInDerNähe.Size = new System.Drawing.Size(313, 43);
            this.buttonStationenInDerNähe.TabIndex = 4;
            this.buttonStationenInDerNähe.Text = "Stationen in der Nähe";
            this.buttonStationenInDerNähe.UseVisualStyleBackColor = true;
            this.buttonStationenInDerNähe.Click += new System.EventHandler(this.buttonStationenInDerNähe_Click);
            // 
            // buttonAbbruch
            // 
            this.buttonAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbbruch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbbruch.Location = new System.Drawing.Point(358, 332);
            this.buttonAbbruch.Name = "buttonAbbruch";
            this.buttonAbbruch.Size = new System.Drawing.Size(113, 33);
            this.buttonAbbruch.TabIndex = 5;
            this.buttonAbbruch.Text = "Abbruch";
            this.buttonAbbruch.UseVisualStyleBackColor = true;
            this.buttonAbbruch.Click += new System.EventHandler(this.buttonAbbruch_Click);
            // 
            // FormHauptmenu
            // 
            this.AcceptButton = this.buttonVerbindungenSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAbbruch;
            this.ClientSize = new System.Drawing.Size(483, 377);
            this.Controls.Add(this.buttonAbbruch);
            this.Controls.Add(this.buttonStationenInDerNähe);
            this.Controls.Add(this.buttonAbfahrtstafel);
            this.Controls.Add(this.buttonNavigationZurStation);
            this.Controls.Add(this.buttonVerbindungenSuchen);
            this.Controls.Add(this.labelHauptseiteTitel);
            this.Name = "FormHauptmenu";
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHauptseiteTitel;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.Button buttonNavigationZurStation;
        private System.Windows.Forms.Button buttonAbfahrtstafel;
        private System.Windows.Forms.Button buttonStationenInDerNähe;
        private System.Windows.Forms.Button buttonAbbruch;
    }
}

