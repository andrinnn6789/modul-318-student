using MyTransportApp.Klassen;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MyTransportApp.Forms
{
    public partial class FormStationenInDerNähe : Form
    {
        readonly string _location1 = IpAufruf.GetUserLocationyByIp("77.109.148.210"); //Verwende die Statische IP-Adresse von Genf, da meine zu wenig Informationen enthält
        readonly string _coordinates1 = IpAufruf.GetUserCoordinatesByIp("77.109.148.210");
        readonly string _location2 = IpAufruf.GetUserLocationyByIp("213.55.184.219"); //Verwende die Statische IP-Adresse von Zürich, zum Überprüfen, dass eine andere IP-Adresse auch funktioniert
        readonly string _coordinates2 = IpAufruf.GetUserCoordinatesByIp("213.55.184.219");
        readonly string _home = "Rothenburg";

        public FormStationenInDerNähe()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonsucheNachStation_Click(object sender, EventArgs e)
        {
            dataGridViewVerbindung.Rows.Clear();
            dataGridViewNaheStation.Rows.Clear();
            ITransport transport = new Transport();
            try
            {
                Station station = transport.GetStations(_location1).StationList.ElementAt(0);
                StationBoardRoot Board = transport.GetStationBoard(station.Name);
                NaheStationenGridErstellen(station,_location1,_coordinates2);

                int i = 0;
                foreach (StationBoard bord in Board.Entries)
                {
                    Connection connection = transport.GetConnections(station.Name, bord.To).ConnectionList.ElementAt(0);
                    int index = dataGridViewVerbindung.Rows.Add();

                    if (connection.From.Platform != null)
                    {
                        dataGridViewVerbindung.Rows[index].Cells[0].Value = connection.From.Platform;
                    }
                    dataGridViewVerbindung.Rows[index].Cells[1].Value = connection.From.Station.Name.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[2].Value = connection.To.Station.Name.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[3].Value = connection.From.Departure.Value.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[4].Value = connection.Duration;

                    if (connection.From.Delay == null)
                    {
                        connection.From.Delay = 0;
                    }
                    dataGridViewVerbindung.Rows[index].Cells[5].Value = connection.From.Delay.ToString() + " Min";

                    i++;
                    if (i >= 4)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geben Sie eine Station ein\n" + ex.Message, "Fehler");
            }

        }

        private void ButtonTakeMeHome_Click(object sender, EventArgs e)
        {
            dataGridViewVerbindung.Rows.Clear();
            dataGridViewNaheStation.Rows.Clear();
            try
            {
                ITransport transport = new Transport();

                Station station = transport.GetStations(_location2).StationList.ElementAt(0);
                NaheStationenGridErstellen(station,_location2,_coordinates2);
                StationBoardRoot Board = transport.GetStationBoard(station.Name);
                var connections = transport.GetConnections(_location2, _home);

                foreach (Connection connection in connections.ConnectionList)
                {
                    int index = dataGridViewVerbindung.Rows.Add();
                    if (connection.From.Platform != null)
                    {
                        dataGridViewVerbindung.Rows[index].Cells[0].Value = connection.From.Platform;
                    }
                    dataGridViewVerbindung.Rows[index].Cells[1].Value = connection.From.Station.Name.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[2].Value = connection.To.Station.Name.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[3].Value = connection.From.Departure.Value.ToString();

                    dataGridViewVerbindung.Rows[index].Cells[4].Value = connection.Duration;

                    if (connection.From.Delay == null)
                    {
                        connection.From.Delay = 0;
                    }
                    dataGridViewVerbindung.Rows[index].Cells[5].Value = connection.From.Delay.ToString() + " Min";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geben Sie Ihre Verbindungen ein\n" + ex.Message, "Fehler");
            }
        }
        private void NaheStationenGridErstellen(Station station, string location, string coordinates)
        {
            int indexL = dataGridViewNaheStation.Rows.Add();
            dataGridViewNaheStation.Rows[indexL].Cells[0].Value = location;

            dataGridViewNaheStation.Rows[indexL].Cells[1].Value = coordinates;

            dataGridViewNaheStation.Rows[indexL].Cells[2].Value = station.Name;

            dataGridViewNaheStation.Rows[indexL].Cells[3].Value = station.Coordinate.XCoordinate.ToString() + ", " + station.Coordinate.YCoordinate.ToString();
        }
    }
}