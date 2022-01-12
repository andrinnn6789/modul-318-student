
namespace MyTransportApp.Forms
{
    partial class FormNavigationZurStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationZurStation));
            this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.buttonStationSuchen = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewMap
            // 
            this.webViewMap.CreationProperties = null;
            this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewMap.Location = new System.Drawing.Point(12, 90);
            this.webViewMap.Name = "webViewMap";
            this.webViewMap.Size = new System.Drawing.Size(761, 348);
            this.webViewMap.TabIndex = 0;
            this.webViewMap.ZoomFactor = 1D;
            this.webViewMap.Click += new System.EventHandler(this.ButtonDeinStandortSuchen_Click);
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(12, 38);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(237, 46);
            this.buttonVerbindungenSuchen.TabIndex = 9;
            this.buttonVerbindungenSuchen.Text = "Dein Standort Suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.ButtonDeinStandortSuchen_Click);
            // 
            // buttonStationSuchen
            // 
            this.buttonStationSuchen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStationSuchen.Location = new System.Drawing.Point(255, 38);
            this.buttonStationSuchen.Name = "buttonStationSuchen";
            this.buttonStationSuchen.Size = new System.Drawing.Size(237, 46);
            this.buttonStationSuchen.TabIndex = 10;
            this.buttonStationSuchen.Text = "Nächste Station Suchen";
            this.buttonStationSuchen.UseVisualStyleBackColor = true;
            this.buttonStationSuchen.Click += new System.EventHandler(this.ButtonStationSuchen_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(694, 9);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(79, 74);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 14;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // FormNavigationZurStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonStationSuchen);
            this.Controls.Add(this.buttonVerbindungenSuchen);
            this.Controls.Add(this.webViewMap);
            this.Name = "FormNavigationZurStation";
            this.Text = "NavigationZurStation";
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.Button buttonStationSuchen;
        private System.Windows.Forms.PictureBox buttonHome;
    }
}