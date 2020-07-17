using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public partial class addBookings : Form
    {
        dbConn mysqlConn = new dbConn();

        public addBookings()
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

        private void addBookings_Load(object sender, EventArgs e)
        {
            if (Form1.updateMode == true)
            {

                cbCustContact.Enabled = false;
                btUpdate.Visible = true;
                btBook.Visible = false;

                dgBookingData.DataSource = mysqlConn.qry("SELECT * FROM `tblbookings` WHERE id='" + Form1.bookingIndex + "'").Tables[0]; //load bookings data grid
                string customer = dgBookingData.Rows[0].Cells[1].Value.ToString(); //set customer name for the following query
                dgCustData.DataSource = mysqlConn.qry("SELECT * FROM `tblcustomer` WHERE custContact='" + customer + "'").Tables[0]; //load customer datagrid
                cbCustContact.Items.Add(customer);

                cbCustContact.SelectedIndex = 0;
                tbEmail.Text = dgCustData.Rows[0].Cells[2].Value.ToString();
                tbDepart.Text = dgBookingData.Rows[0].Cells[2].Value.ToString();
                tbDestination.Text = dgBookingData.Rows[0].Cells[3].Value.ToString();
                tbSeat.Text = dgBookingData.Rows[0].Cells[4].Value.ToString();
                tbPrice.Text = dgBookingData.Rows[0].Cells[6].Value.ToString();

                DateTime departEdit = Convert.ToDateTime(dgBookingData.Rows[0].Cells[5].Value.ToString());
                tbDepTime.Text = departEdit.ToShortTimeString();
                tbDuration.Text = departEdit.AddHours(Convert.ToDouble(dgBookingData.Rows[0].Cells[6].Value.ToString())).ToShortTimeString();
                mcDate.TodayDate = departEdit;
                if (dgBookingData.Rows[0].Cells[7].Value.ToString() == "Y")
                {
                    chkPaid.Checked = true;
                }

                else
                {
                    chkPaid.Checked = false;
                }


            }

            else
            {
                tbDepart.Text = Form1.flightOrigin;
                tbDestination.Text = Form1.flightDestination;
                int flightIndex = Convert.ToInt32(Form1.flightId);
                if (mysqlConn.connOpen() == true)
                {

                    dgCustData.DataSource = mysqlConn.qry("SELECT * FROM `tblcustomer` WHERE id <> 'NULL'").Tables[0]; //load customer datagrid
                    dgFlightData.DataSource = mysqlConn.qry("SELECT * FROM `tblflights` WHERE id ='" + flightIndex.ToString() + "'").Tables[0]; //load flights data grid



                    foreach (DataGridViewRow custContactRow in dgCustData.Rows) //loop through each row in the datagridview control
                    {
                        string tbleVal;

                        if (custContactRow.Cells[1].Value != null) //ensure that the value is not null
                        {
                            tbleVal = custContactRow.Cells[1].Value.ToString(); //sets string value to the specified cell value which is the customer name
                            cbCustContact.Items.Add(tbleVal); //adds that string value to the combobox
                        }

                    }


                }
                //fill in remaining controls once the tables have been loaded
                cbTicket.SelectedIndex = 0;
                DateTime depart = Convert.ToDateTime(dgFlightData.Rows[0].Cells[5].Value.ToString());
                tbDepTime.Text = depart.ToShortTimeString();
                tbDuration.Text = depart.AddHours(Convert.ToDouble(dgFlightData.Rows[0].Cells[6].Value.ToString())).ToShortTimeString();
                mcDate.TodayDate = depart;
            }
        }

        private void cbCustContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Form1.updateMode == false)
            {
                int cbIndex = cbCustContact.SelectedIndex;
                tbEmail.Text = dgCustData.Rows[cbIndex].Cells[2].Value.ToString();
            }

        }

        private void cbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Form1.updateMode == false)
            {
                tbPrice.Text = dgFlightData.Rows[0].Cells[(7 + cbTicket.SelectedIndex)].Value.ToString();
            }
        }

        private void btBook_Click(object sender, EventArgs e)
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
            if (blankInput == false) //if all fields have been filled in
            {
                string varDateTime = mcDate.SelectionRange.Start.ToString("yyyy-MM-dd") + " " + tbDepTime.Text + ":00"; ;
                string varPaid;
                if (chkPaid.Checked == true) { varPaid = "Y"; }
                else { varPaid = "N"; }
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.insertBooking(cbCustContact.Text, tbDepart.Text, tbDestination.Text, tbSeat.Text, varDateTime, tbPrice.Text, varPaid);
                }


                MessageBox.Show("Booking successfully added to database.");
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string varPaid;
            string varDateTime = mcDate.SelectionRange.Start.ToString("yyyy-MM-dd") + " " + tbDepTime.Text + ":00"; ;
            if (chkPaid.Checked == true) { varPaid = "Y"; }
            else { varPaid = "N"; }
            mysqlConn.updateBooking(Form1.bookingIndex, cbCustContact.Text, tbDepart.Text, tbDestination.Text, tbSeat.Text, varDateTime, tbPrice.Text, varPaid);
            MessageBox.Show("Updated Booking");
            this.Close();
        }
    }

}


