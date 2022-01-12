
namespace MyTransportApp.Forms
{
    partial class FormVerbindungenSuchen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerbindungenSuchen));
            this.buttonChange = new System.Windows.Forms.PictureBox();
            this.labelAbfahrtsstation = new System.Windows.Forms.Label();
            this.labelEndstation = new System.Windows.Forms.Label();
            this.dataGridViewVerbindung = new System.Windows.Forms.DataGridView();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBoxVor = new System.Windows.Forms.ComboBox();
            this.searchBoxNach = new System.Windows.Forms.ComboBox();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.buttonMail = new System.Windows.Forms.PictureBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelZeit = new System.Windows.Forms.Label();
            this.buttonJetzt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindung)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMail)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.Image = ((System.Drawing.Image)(resources.GetObject("buttonChange.Image")));
            this.buttonChange.Location = new System.Drawing.Point(222, 11);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(79, 74);
            this.buttonChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonChange.TabIndex = 0;
            this.buttonChange.TabStop = false;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // labelAbfahrtsstation
            // 
            this.labelAbfahrtsstation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAbfahrtsstation.Location = new System.Drawing.Point(12, 9);
            this.labelAbfahrtsstation.Name = "labelAbfahrtsstation";
            this.labelAbfahrtsstation.Size = new System.Drawing.Size(184, 34);
            this.labelAbfahrtsstation.TabIndex = 3;
            this.labelAbfahrtsstation.Text = "Abfahrtsstation";
            this.labelAbfahrtsstation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEndstation
            // 
            this.labelEndstation.AutoSize = true;
            this.labelEndstation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndstation.Location = new System.Drawing.Point(329, 11);
            this.labelEndstation.Name = "labelEndstation";
            this.labelEndstation.Size = new System.Drawing.Size(126, 32);
            this.labelEndstation.TabIndex = 5;
            this.labelEndstation.Text = "Endstation";
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
            this.dataGridViewVerbindung.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewVerbindung.Name = "dataGridViewVerbindung";
            this.dataGridViewVerbindung.ReadOnly = true;
            this.dataGridViewVerbindung.RowHeadersWidth = 62;
            this.dataGridViewVerbindung.RowTemplate.Height = 25;
            this.dataGridViewVerbindung.Size = new System.Drawing.Size(761, 244);
            this.dataGridViewVerbindung.TabIndex = 6;
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
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(536, 122);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(237, 46);
            this.buttonVerbindungenSuchen.TabIndex = 8;
            this.buttonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.ButtonVerbindungenSuchen_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // searchBoxVor
            // 
            this.searchBoxVor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxVor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBoxVor.FormattingEnabled = true;
            this.searchBoxVor.Location = new System.Drawing.Point(12, 52);
            this.searchBoxVor.Name = "searchBoxVor";
            this.searchBoxVor.Size = new System.Drawing.Size(175, 23);
            this.searchBoxVor.TabIndex = 10;
            this.searchBoxVor.TextUpdate += new System.EventHandler(this.SearchBoxVor_TextUpdate);
            // 
            // searchBoxNach
            // 
            this.searchBoxNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBoxNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBoxNach.FormattingEnabled = true;
            this.searchBoxNach.Location = new System.Drawing.Point(329, 52);
            this.searchBoxNach.Name = "searchBoxNach";
            this.searchBoxNach.Size = new System.Drawing.Size(175, 23);
            this.searchBoxNach.TabIndex = 11;
            this.searchBoxNach.TextUpdate += new System.EventHandler(this.SearchBoxNach_TextUpdate);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(694, 9);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(79, 74);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 12;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // buttonMail
            // 
            this.buttonMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMail.Image = ((System.Drawing.Image)(resources.GetObject("buttonMail.Image")));
            this.buttonMail.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMail.InitialImage")));
            this.buttonMail.Location = new System.Drawing.Point(579, 9);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(79, 74);
            this.buttonMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMail.TabIndex = 13;
            this.buttonMail.TabStop = false;
            this.buttonMail.Click += new System.EventHandler(this.ButtonMail_Click);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "dd-MM-yyyy/ HH:mm";
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTime.Location = new System.Drawing.Point(135, 147);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(197, 23);
            this.dateTimePickerTime.TabIndex = 15;
            this.dateTimePickerTime.ValueChanged += new System.EventHandler(this.DateTimePickerTime_ValueChanged);
            // 
            // labelZeit
            // 
            this.labelZeit.AutoSize = true;
            this.labelZeit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZeit.Location = new System.Drawing.Point(12, 145);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(48, 25);
            this.labelZeit.TabIndex = 17;
            this.labelZeit.Text = "Zeit:";
            // 
            // buttonJetzt
            // 
            this.buttonJetzt.Location = new System.Drawing.Point(357, 145);
            this.buttonJetzt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJetzt.Name = "buttonJetzt";
            this.buttonJetzt.Size = new System.Drawing.Size(95, 20);
            this.buttonJetzt.TabIndex = 18;
            this.buttonJetzt.Text = "Jetzt";
            this.buttonJetzt.UseVisualStyleBackColor = true;
            this.buttonJetzt.Click += new System.EventHandler(this.ButtonJetzt_Click);
            // 
            // FormVerbindungenSuchen
            // 
            this.AcceptButton = this.buttonVerbindungenSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.buttonJetzt);
            this.Controls.Add(this.labelZeit);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.buttonMail);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.searchBoxNach);
            this.Controls.Add(this.searchBoxVor);
            this.Controls.Add(this.buttonVerbindungenSuchen);
            this.Controls.Add(this.dataGridViewVerbindung);
            this.Controls.Add(this.labelEndstation);
            this.Controls.Add(this.labelAbfahrtsstation);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormVerbindungenSuchen";
            this.Text = "Verbindungen Suchen";
            ((System.ComponentModel.ISupportInitialize)(this.buttonChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindung)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonChange;
        private System.Windows.Forms.Label labelAbfahrtsstation;
        private System.Windows.Forms.Label labelEndstation;
        private System.Windows.Forms.DataGridView dataGridViewVerbindung;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox searchBoxVor;
        private System.Windows.Forms.ComboBox searchBoxNach;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.PictureBox buttonMail;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label labelZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
        private System.Windows.Forms.Button buttonJetzt;
    }
}