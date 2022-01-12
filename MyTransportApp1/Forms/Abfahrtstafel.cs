using SwissTransport.Core;
using SwissTransport.Models;
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
    public partial class FormAbfahrtstafel : Form
    {
        public FormAbfahrtstafel()
        {
            InitializeComponent();
        }

        private void SearchBoxVor_TextUpdate(object sender, EventArgs e)
        {
            SearchBoxItems(searchBoxVor);
        }

        static void SearchBoxItems(ComboBox boxSearch)
        {
            boxSearch.Items.Clear();
            if (boxSearch.Text != "")
            {
                try
                {
                    ITransport transport = new Transport();
                    Stations stations = transport.GetStations(boxSearch.Text);
                    foreach (Station station in stations.StationList)
                    {
                        boxSearch.Items.Add(station.Name);
                        boxSearch.AutoCompleteCustomSource.Add(station.Name);
                    }
                    boxSearch.SelectionStart = boxSearch.Text.Length;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es wurde keine Station gefunden\n" + ex.Message, "Fehler");
                    boxSearch.Text = "";
                }
            }
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            GetPossibleestinations();
        }
        private void GetPossibleestinations()
        {
            dataGridViewVerbindung.Rows.Clear();
            ITransport transport = new Transport();
            try
            {
                Station station = transport.GetStations(searchBoxVor.Text).StationList.ElementAt(0);
                StationBoardRoot Board = transport.GetStationBoard(station.Name);

                int i = 0;
                foreach (StationBoard bord in Board.Entries)
                {
                    Connection connection = transport.GetConnections(station.Name, bord.To).ConnectionList.ElementAt(0);
                    int index = dataGridViewVerbindung.Rows.Add();

                    if (connection.From.Platform != null)
                    {
                        dataGridViewVerbindung.Rows[index].Cells[0].Value = connection.From.Platform;
                    }

                    dataGridViewVerbindung.Rows[index].Cells[1].Value = connection.To.Station.Name.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[2].Value = connection.From.Departure.Value.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[3].Value = connection.Duration;

                    i++;
                    if (i >= 10)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geben Sie eine Station ein\n" + ex.Message,"Fehler");
            }
        }
    }
}
