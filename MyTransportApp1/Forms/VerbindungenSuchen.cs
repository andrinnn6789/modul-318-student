using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp.Forms
{
    public partial class FormVerbindungenSuchen : Form
    {
        public FormVerbindungenSuchen()
        {
            InitializeComponent();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            string textVor = "";
            string textNach = "";
            if (searchBoxVor.SelectedItem != null)
            {
                textVor = searchBoxVor.SelectedItem.ToString();
            }
            if (searchBoxNach.SelectedItem != null)
            {
                textNach = searchBoxNach.SelectedItem.ToString();
            }
            searchBoxVor.Text = textNach;
            searchBoxVor.Items.Add(textNach);
            searchBoxVor.AutoCompleteCustomSource.Add(textNach);
            searchBoxNach.Text = textVor;
            searchBoxNach.Items.Add(textVor);
            searchBoxNach.AutoCompleteCustomSource.Add(textVor);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBoxVor_TextUpdate(object sender, EventArgs e)
        {
            SearchBoxItems(searchBoxVor);
        }

        private void SearchBoxNach_TextUpdate(object sender, EventArgs e)
        {
            SearchBoxItems(searchBoxNach);
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

        private void ButtonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            dataGridViewVerbindung.Rows.Clear();
            try
            {
                ITransport transport = new Transport();
                var connections = transport.GetConnections(searchBoxVor.Text, searchBoxNach.Text, dateTimePickerTime.Value);
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
                MessageBox.Show("Geben Sie Ihre Verbindungen ein\n" + ex.Message,"Fehler");
            }
        }

        private void DateTimePickerTime_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerTime.Value < DateTime.Now)
            {
                MessageBox.Show("Geben Sie ein aktuelles Datum ein! Ihr Datum liegt in der Vergangenheit", "Fehler");
                dateTimePickerTime.Value = DateTime.Now + new TimeSpan(0,0,0,10);
            }
        }

        private void ButtonJetzt_Click(object sender, EventArgs e)
        {
            dateTimePickerTime.Value = DateTime.Now + new TimeSpan(0, 0, 0, 10);
        }

        private void ButtonMail_Click(object sender, EventArgs e)
        {
            /*try
            {
                ITransport transport = new Transport();
                Connection connection = transport.GetConnections(searchBoxVor.Text, searchBoxNach.Text, dateTimePickerTime.Value).ConnectionList.ElementAt(0);
                Mail mail = new Mail();
                mail.toMailConnection = connection;
                mail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geben Sie Ihre Verbindungen ein\n" + ex.Message, "Fehler");
            }*/
            MessageBox.Show("Noch nicht fertig Implementiert");
        }
    }

}
