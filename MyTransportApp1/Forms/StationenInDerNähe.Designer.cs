
namespace MyTransportApp.Forms
{
    partial class FormStationenInDerNähe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStationenInDerNähe));
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.buttonTakeMeHome = new System.Windows.Forms.Button();
            this.buttonsucheNachStation = new System.Windows.Forms.Button();
            this.dataGridViewVerbindung = new System.Windows.Forms.DataGridView();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNaheStation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stationskoordinaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaheStation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(694, 9);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(79, 74);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 13;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // buttonTakeMeHome
            // 
            this.buttonTakeMeHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTakeMeHome.Location = new System.Drawing.Point(70, 48);
            this.buttonTakeMeHome.Name = "buttonTakeMeHome";
            this.buttonTakeMeHome.Size = new System.Drawing.Size(202, 35);
            this.buttonTakeMeHome.TabIndex = 15;
            this.buttonTakeMeHome.Text = "Take Me Home";
            this.buttonTakeMeHome.UseVisualStyleBackColor = true;
            this.buttonTakeMeHome.Click += new System.EventHandler(this.ButtonTakeMeHome_Click);
            // 
            // buttonsucheNachStation
            // 
            this.buttonsucheNachStation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsucheNachStation.Location = new System.Drawing.Point(307, 48);
            this.buttonsucheNachStation.Name = "buttonsucheNachStation";
            this.buttonsucheNachStation.Size = new System.Drawing.Size(202, 35);
            this.buttonsucheNachStation.TabIndex = 16;
            this.buttonsucheNachStation.Text = "Suche nach Station";
            this.buttonsucheNachStation.UseVisualStyleBackColor = true;
            this.buttonsucheNachStation.Click += new System.EventHandler(this.ButtonsucheNachStation_Click);
            // 
            // dataGridViewVerbindung
            // 
            this.dataGridViewVerbindung.AllowUserToAddRows = false;
            this.dataGridViewVerbindung.AllowUserToDeleteRows = false;
            this.dataGridViewVerbindung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerbindung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nummer,
            this.Abfahrtsstation,
            this.Endstation,
            this.Abfahrzeit,
            this.Dauer,
            this.Verspätung});
            this.dataGridViewVerbindung.Location = new System.Drawing.Point(12, 263);
            this.dataGridViewVerbindung.Name = "dataGridViewVerbindung";
            this.dataGridViewVerbindung.ReadOnly = true;
            this.dataGridViewVerbindung.RowHeadersWidth = 62;
            this.dataGridViewVerbindung.RowTemplate.Height = 25;
            this.dataGridViewVerbindung.Size = new System.Drawing.Size(729, 175);
            this.dataGridViewVerbindung.TabIndex = 17;
            // 
            // Nummer
            // 
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.MinimumWidth = 8;
            this.Nummer.Name = "Nummer";
            this.Nummer.ReadOnly = true;
            this.Nummer.Width = 150;
            // 
            // Abfahrtsstation
            // 
            this.Abfahrtsstation.HeaderText = "Abfahrtsstation";
            this.Abfahrtsstation.MinimumWidth = 8;
            this.Abfahrtsstation.Name = "Abfahrtsstation";
            this.Abfahrtsstation.ReadOnly = true;
            this.Abfahrtsstation.Width = 150;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.MinimumWidth = 8;
            this.Endstation.Name = "Endstation";
            this.Endstation.ReadOnly = true;
            this.Endstation.Width = 150;
            // 
            // Abfahrzeit
            // 
            this.Abfahrzeit.HeaderText = "Abfahrzeit";
            this.Abfahrzeit.MinimumWidth = 8;
            this.Abfahrzeit.Name = "Abfahrzeit";
            this.Abfahrzeit.ReadOnly = true;
            this.Abfahrzeit.Width = 225;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 8;
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            this.Dauer.Width = 150;
            // 
            // Verspätung
            // 
            this.Verspätung.HeaderText = "Verspätung";
            this.Verspätung.MinimumWidth = 8;
            this.Verspätung.Name = "Verspätung";
            this.Verspätung.ReadOnly = true;
            this.Verspätung.Width = 150;
            // 
            // dataGridViewNaheStation
            // 
            this.dataGridViewNaheStation.AllowUserToAddRows = false;
            this.dataGridViewNaheStation.AllowUserToDeleteRows = false;
            this.dataGridViewNaheStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNaheStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Stationskoordinaten});
            this.dataGridViewNaheStation.Location = new System.Drawing.Point(12, 164);
            this.dataGridViewNaheStation.Name = "dataGridViewNaheStation";
            this.dataGridViewNaheStation.ReadOnly = true;
            this.dataGridViewNaheStation.RowHeadersWidth = 62;
            this.dataGridViewNaheStation.RowTemplate.Height = 25;
            this.dataGridViewNaheStation.Size = new System.Drawing.Size(729, 74);
            this.dataGridViewNaheStation.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Dein Standort";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Deine Koordinaten";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Stationsname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // Stationskoordinaten
            // 
            this.Stationskoordinaten.HeaderText = "Stationskoordinaten";
            this.Stationskoordinaten.Name = "Stationskoordinaten";
            this.Stationskoordinaten.ReadOnly = true;
            this.Stationskoordinaten.Width = 150;
            // 
            // FormStationenInDerNähe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.dataGridViewNaheStation);
            this.Controls.Add(this.dataGridViewVerbindung);
            this.Controls.Add(this.buttonsucheNachStation);
            this.Controls.Add(this.buttonTakeMeHome);
            this.Controls.Add(this.buttonHome);
            this.Name = "FormStationenInDerNähe";
            this.Text = "Stationen in der Nähe";
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaheStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.Button buttonTakeMeHome;
        private System.Windows.Forms.Button buttonsucheNachStation;
        private System.Windows.Forms.DataGridView dataGridViewVerbindung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
        private System.Windows.Forms.DataGridView dataGridViewNaheStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stationskoordinaten;
    }
}