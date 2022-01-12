
namespace MyTransportApp.Forms
{
    partial class FormAbfahrtstafel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbfahrtstafel));
            this.labelStation = new System.Windows.Forms.Label();
            this.searchBoxVor = new System.Windows.Forms.ComboBox();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.dataGridViewVerbindung = new System.Windows.Forms.DataGridView();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStation.Location = new System.Drawing.Point(17, 85);
            this.labelStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(138, 48);
            this.labelStation.TabIndex = 0;
            this.labelStation.Text = "Station:";
            // 
            // searchBoxVor
            // 
            this.searchBoxVor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxVor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBoxVor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBoxVor.FormattingEnabled = true;
            this.searchBoxVor.Location = new System.Drawing.Point(207, 97);
            this.searchBoxVor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBoxVor.Name = "searchBoxVor";
            this.searchBoxVor.Size = new System.Drawing.Size(304, 36);
            this.searchBoxVor.TabIndex = 11;
            this.searchBoxVor.TextUpdate += new System.EventHandler(this.SearchBoxVor_TextUpdate);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(991, 15);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(113, 123);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 13;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // dataGridViewVerbindung
            // 
            this.dataGridViewVerbindung.AllowUserToAddRows = false;
            this.dataGridViewVerbindung.AllowUserToDeleteRows = false;
            this.dataGridViewVerbindung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerbindung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nummer,
            this.Endstation,
            this.Abfahrzeit,
            this.Dauer});
            this.dataGridViewVerbindung.Location = new System.Drawing.Point(17, 235);
            this.dataGridViewVerbindung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewVerbindung.Name = "dataGridViewVerbindung";
            this.dataGridViewVerbindung.ReadOnly = true;
            this.dataGridViewVerbindung.RowHeadersWidth = 62;
            this.dataGridViewVerbindung.RowTemplate.Height = 25;
            this.dataGridViewVerbindung.Size = new System.Drawing.Size(951, 407);
            this.dataGridViewVerbindung.TabIndex = 14;
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(584, 77);
            this.buttonVerbindungenSuchen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(339, 77);
            this.buttonVerbindungenSuchen.TabIndex = 15;
            this.buttonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.ButtonVerbindungenSuchen_Click);
            // 
            // Nummer
            // 
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.MinimumWidth = 8;
            this.Nummer.Name = "Nummer";
            this.Nummer.ReadOnly = true;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.MinimumWidth = 8;
            this.Endstation.Name = "Endstation";
            this.Endstation.ReadOnly = true;
            this.Endstation.Width = 250;
            // 
            // Abfahrzeit
            // 
            this.Abfahrzeit.HeaderText = "Abfahrzeit";
            this.Abfahrzeit.MinimumWidth = 8;
            this.Abfahrzeit.Name = "Abfahrzeit";
            this.Abfahrzeit.ReadOnly = true;
            this.Abfahrzeit.Width = 250;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 8;
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            this.Dauer.Width = 200;
            // 
            // FormAbfahrtstafel
            // 
            this.AcceptButton = this.buttonVerbindungenSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 750);
            this.Controls.Add(this.buttonVerbindungenSuchen);
            this.Controls.Add(this.dataGridViewVerbindung);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.searchBoxVor);
            this.Controls.Add(this.labelStation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAbfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.ComboBox searchBoxVor;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.DataGridView dataGridViewVerbindung;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
    }
}