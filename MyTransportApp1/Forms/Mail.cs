using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp.Forms
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
            textBoxBodyPart.Text = GetInformations();
        }
        public Connection ToMailConnection { get; set; }

        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            try
            {

                string addMail = textBoxToSendTo.Text;
                string subject = textBoxToSubject.Text;
                string body = textBoxBodyPart.Text;

                MailMessage mail = new();
                SmtpClient SmtpServer = new("smtp.gmail.com");

                mail.From = new MailAddress("a.porti1705@gmail.com");
                mail.To.Add(addMail);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("a.porti1705@gmail.com", "1234test");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail gesendet");

                textBoxToSendTo.Text = "";
                textBoxToSubject.Text = "";
                textBoxBodyPart.Text = "";

                this.Close();
            }
            catch (Exception ex)
            {
                if (textBoxToSendTo.Text == "")
                {
                    MessageBox.Show("Geben Sie eine E-Mailadresse ein: " + ex.Message);
                }
                else if (textBoxToSubject.Text == "")
                {
                    MessageBox.Show("Geben Sie ein Betreff ein: " + ex.Message);
                }
            }
        }
        string GetInformations()
        {
            string infos;
            TimeSpan? duration;
            string efektivduration = "";
            string departureTime = "";
            string arrivalTime = "";
            string delay = "";

            string titel = Convert.ToString(this.ToMailConnection.From.Station.Name) + " --> " + Convert.ToString(this.ToMailConnection.To.Station.Name);
            if (ToMailConnection.From.Departure.HasValue)
            {
                departureTime = "Abfahrt: \t" + ToMailConnection.From.Departure.Value.ToString("dd.MM.yyyy HH:mm");
            }
            if (ToMailConnection.To.Arrival.HasValue)
            {
                arrivalTime = "Ankunft: \t" + ToMailConnection.To.Arrival.Value.ToString("dd.MM.yyyy HH: mm");
            }

            duration = ToMailConnection.To.Arrival - ToMailConnection.From.Departure;

            if (duration.HasValue)
            {
                efektivduration = "Länge: \t" + duration.Value.ToString(@"hh\:mm");
            }

            if (ToMailConnection.From.Delay > 0)
            {
                delay = "Verspätung: \t" + "+ " + Convert.ToString(ToMailConnection.From.Delay) + " Min";
            }

            infos = "\n\n\n" + titel + "\n" + departureTime + "\n" + arrivalTime + "\n" + efektivduration + "\n" + delay;

            return infos;
        }
    }
}
