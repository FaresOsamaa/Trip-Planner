using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripPlanner
{
    public partial class Plan_A : Form
    {
        public Plan_A()
        {
            InitializeComponent();
        }

        public void Plan_A_Load(object sender, EventArgs e)
        {

        }

        public void listBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var selectedItemAirLine in listBoxAirlines.SelectedItems)      //loop to identify the user's Airline choice
            {
                Console.WriteLine(selectedItemAirLine);
            }
        }
        public void listBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var selectedItemHotel in listBoxHotel.SelectedItems)       //loop to identify the user's Hotel choice
            {
                Console.WriteLine(selectedItemHotel);
            }
        }

        public void buttonNext_Click(object sender, EventArgs e)
        {
            string selectedItemHotel = listBoxHotel.SelectedItem.ToString();
            string selectedItemAirLine = listBoxAirlines.SelectedItem.ToString();
            int dateArrival = int.Parse(Convert.ToString(dateTimePickerArrival.Value.Day));
            int dateDeparture = int.Parse(Convert.ToString(dateTimePickerDepature.Value.Day));
            int dateNumber = dateArrival - dateDeparture;

            USA usa = new USA(selectedItemHotel, selectedItemAirLine,dateNumber);

            double total_price = usa.TotalPrice();
            double hotal_price = usa.HotelPrices();
            double air_plane = usa.AirPlanePrices();

            CheckOut checkOut = new CheckOut(hotal_price, air_plane, total_price);
            checkOut.Show();
            this.Hide();

            Console.WriteLine("Total Price: " + total_price + "\nHotal Price: " + hotal_price + "\nAirplan Price: " + air_plane);         
        }

        public void buttonBack_Click(object sender, EventArgs e)
        {
            Trips plan = new Trips();
            plan.Show();
            this.Hide();
        }

        public void dateTimePickerArrival_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerArrival.TabIndex = 0;

            Console.WriteLine("\n" + dateTimePickerArrival);
        }

        public void dateTimePickerDepature_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerDepature.TabIndex = 0;

            Console.WriteLine("\n" + dateTimePickerDepature);
        }
    }
}
