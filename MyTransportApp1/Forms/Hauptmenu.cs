using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp.Forms
{
    public partial class FormHauptmenu : Form
    {
        public FormHauptmenu()
        {
            InitializeComponent();
        }

        private void ButtonAbbruch_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void ButtonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            FormVerbindungenSuchen verbindungenSuchen = new();
            verbindungenSuchen.ShowDialog();
        }

        private void ButtonNavigationZurStation_Click(object sender, EventArgs e)
        {
            FormNavigationZurStation navigationZurStation = new();
            navigationZurStation.ShowDialog();
        }

        private void ButtonAbfahrtstafel_Click(object sender, EventArgs e)
        {
            FormAbfahrtstafel abfahrtstafel = new();
            abfahrtstafel.ShowDialog();
        }

        private void ButtonStationenInDerNähe_Click(object sender, EventArgs e)
        {
            FormStationenInDerNähe stationenInDerNähe = new();
            stationenInDerNähe.ShowDialog();
        }

        private void FormHauptmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Wollen Sie das Programm wirklich beenden?", "Programm Schliessen", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        
    }
}
