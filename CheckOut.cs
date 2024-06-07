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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        
        double HotelPrices;
        double AirPlanePrice;
        double TotalPrice;

        public CheckOut(double HotelPrices, double AirPlanePrice, double TotalPrice)
        {
            this.HotelPrices = HotelPrices;
            this.AirPlanePrice = AirPlanePrice;
            this.TotalPrice = TotalPrice;

            InitializeComponent();
        } 

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void ConfrimBtn_Click(object sender, EventArgs e)
        {
            string message = "Your trip is booked successfully!";
            string title = "Trip";
            MessageBox.Show(message, title);
            this.Close();
        }

        private void labelHotelPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void labelAirplanPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            labelHotelPrice.Text = Convert.ToString(HotelPrices);
            labelAirplanPrice.Text = Convert.ToString(AirPlanePrice);
            labelTotalPrice.Text = Convert.ToString(TotalPrice);
        }
    }
}
