using MyTransportApp.Klassen;
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
    public partial class FormNavigationZurStation : Form
    {
        readonly string _yourLocation = IpAufruf.GetUserLocationyByIp("213.55.184.219");
        readonly string _yourcoordinates = IpAufruf.GetUserCoordinatesByIp("213.55.184.219");

        public FormNavigationZurStation()
        {
            InitializeComponent();
            webViewMap.Source = new Uri("https://maps.google.com");
        }

        private void ButtonDeinStandortSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder query = new();
                query.Append("http://maps.google.com/maps?q=");
                query.Append(_yourcoordinates);
                webViewMap.Source = new Uri(query.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonStationSuchen_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            Station station = transport.GetStations(_yourLocation).StationList.ElementAt(0);

            try
            {
                StringBuilder query = new();
                query.Append("http://maps.google.com/maps?q=");
                if (station.Coordinate.XCoordinate.ToString() != string.Empty)
                {
                    query.Append(station.Coordinate.XCoordinate.ToString() + "," + "+");
                }
                if (station.Coordinate.YCoordinate.ToString() != string.Empty)
                {
                    query.Append(station.Coordinate.YCoordinate.ToString());
                }
                webViewMap.Source = new Uri(query.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
