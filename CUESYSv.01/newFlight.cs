using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public partial class newFlight : Form
    {
        dbConn mysqlConn = new dbConn();
        decimal flightBasePrice = 0;
        public newFlight()
        {
            InitializeComponent();
            dbConfig();
            mysqlConn.connect();
        }
        public bool dbConfig()
        {
            try
            {
                mysqlConn.varConfigServer = "skiving2.cucstudents.org";
                mysqlConn.varConfigDatabase = "skiving2_CUEsys";
                mysqlConn.varConfigUser = "skiving2_admin";
                mysqlConn.varConfigPass = "BTpasword12_";
                return true;
            }
            catch { return false; }
        }

        private void btFlightSave_Click(object sender, EventArgs e)
        {
            bool blankInput = true;

            //loop through all textbox controls to check for blank fields before continuing
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        blankInput = true;
                    }
                    else
                    {
                        blankInput = false;
                    }
                }
            }
            if (blankInput == false)
            {

                string varDateTime = mcDate.SelectionRange.Start.ToString("yyyy-MM-dd") + " " + dtDepTime.Text;
                int seatsAvailable = Convert.ToInt32(tbCapacity.Text);

                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.insertFlight(tbOrigin.Text, tbDestination.Text, seatsAvailable, 0, varDateTime, tbDuration.Text, tbPrice.Text, tbChild.Text, tbInfant.Text);
                }
                MessageBox.Show("Flight added to database.");
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }

        }
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbPrice.Text != "" & tbPrice.Text != ".") //does not set prices until a numeric value is entered
            {
                //converts price textbox to a decimal data type and rounds to two decimal places.
                flightBasePrice = Math.Round(Convert.ToDecimal(tbPrice.Text), 2);
                //Automatically updates the child and infant prices at a fixed rate based on adult price and rounds to two decimal places.
                tbChild.Text = Math.Round(Decimal.Multiply(flightBasePrice, Convert.ToDecimal(0.8)), 2).ToString();
                tbInfant.Text = Math.Round(Decimal.Multiply(flightBasePrice, Convert.ToDecimal(0.7)), 2).ToString();
            }
            else
            {
                tbChild.Text = "";
                tbInfant.Text = "";
            }

        }

        private void newFlight_Load(object sender, EventArgs e)
        {
            DateTime today = mcDate.TodayDate;
            mcDate.MinDate = today;
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restricts user input to control keys, numeric and decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Ensure that user can only enter one '.' for decimal value
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            //Rounds price automatically when user leaves the price textbox
            tbPrice.Text = flightBasePrice.ToString();
        }

        private void tbCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restricts user input to numeric and control keys only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
