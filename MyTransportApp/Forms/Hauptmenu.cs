using MyTransportApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class FormHauptmenu : Form
    {
        public FormHauptmenu()
        {
            InitializeComponent();
        }

        private void buttonAbbruch_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Wollen Sie das Programm wirklich beenden?", "Programm Schliessen", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            FormVerbindungenSuchen verbindungenSuchen = new FormVerbindungenSuchen();
            verbindungenSuchen.ShowDialog();
        }

        private void buttonNavigationZurStation_Click(object sender, EventArgs e)
        {
            FormNavigationZurStation navigationZurStation = new FormNavigationZurStation();
            navigationZurStation.ShowDialog();
        }

        private void buttonAbfahrtstafel_Click(object sender, EventArgs e)
        {
            FormAbfahrtstafel abfahrtstafel = new FormAbfahrtstafel();
            abfahrtstafel.ShowDialog();
        }

        private void buttonStationenInDerNähe_Click(object sender, EventArgs e)
        {
            FormStationenInDerNähe stationenInDerNähe = new FormStationenInDerNähe();
            stationenInDerNähe.ShowDialog();
        }
    }
}
