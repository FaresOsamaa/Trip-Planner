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
    public partial class Trips : Form
    {
        public Trips()
        {
            InitializeComponent();
        }

        private void Plans_Load(object sender, EventArgs e)
        {

        }

        private void buttonUSA_Click(object sender, EventArgs e)
        {
            Plan_A plan = new Plan_A();
            plan.Show();
            this.Hide();
        }

        private void buttonJapan_Click(object sender, EventArgs e)
        {
            Plan_B plan = new Plan_B();
            plan.Show();
            this.Hide();
        }

        private void buttonFrance_Click(object sender, EventArgs e)
        {
            Plan_C plan = new Plan_C();
            plan.Show();
            this.Hide();
        }
    }
}
