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
    public partial class addCustomer : Form
    {
        dbConn mysqlConn = new dbConn();


        public addCustomer()
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

        private void btCustSave_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.insertCustomer(tbCustContact.Text, tbCustEmail.Text, tbCustTel.Text, tbCustAdd1.Text, tbCustAdd2.Text, tbCustTownCity.Text, tbCustPostcode.Text, tbNationality.Text);
            }
            MessageBox.Show("Customer, " + tbCustContact.Text + " added to database.");
            tbCustContact.Text = tbCustEmail.Text = tbCustTel.Text = tbCustAdd1.Text = tbCustAdd2.Text = tbCustTownCity.Text = tbCustPostcode.Text = "";

            this.Close();//close form upon completion
        }
    }
}
