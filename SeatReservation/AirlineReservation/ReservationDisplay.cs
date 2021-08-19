using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AirlineReservation
{
    public partial class ReservationDisplay : Form
    {
        public ReservationDisplay()
        {
            InitializeComponent();
        }

        private Flight.Class selectedClass = Flight.Class.First;
        private FlightStore flights;
        private PictureBox[] seatChart;
        Flight selectedFlight;
        private int selectedSeat;

        private void flightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = flightComboBox.SelectedIndex;

            if (index < 0 || index >= 3)
                return;
            selectedFlight = flights[index];
            selectedSeat = selectedFlight.AssignSeat(selectedClass);

            displayTextBox.Text = "Is seat " + (selectedSeat + 1) + " OK?";
        }

        private void firstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedClass = Flight.Class.First;
        }

        private void economyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedClass = Flight.Class.economy;
        }

        private void ReservationDisplay_Load_1(object sender, EventArgs e)
        {
            flights = new FlightStore(new string[]{"E123","E234","E345"});
            seatChart = new PictureBox[10] { seat1, seat2, seat3, seat4, seat5, seat6, seat7, seat8, seat9, seat10 };
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            selectedFlight.SelectSeat(selectedSeat);

            displayTextBox.Text = "Thank you for your business!";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
