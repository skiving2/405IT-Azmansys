namespace CUESYSv._01
{
    partial class addBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.lbFlightOrigin = new System.Windows.Forms.Label();
            this.tbDepart = new System.Windows.Forms.TextBox();
            this.lbFlightDestination = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.lbSeatCapacity = new System.Windows.Forms.Label();
            this.lbNewBooking = new System.Windows.Forms.Label();
            this.tbSeat = new System.Windows.Forms.TextBox();
            this.lbFlightDeparture = new System.Windows.Forms.Label();
            this.lbEstimate = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.lbCustName = new System.Windows.Forms.Label();
            this.lbTicket = new System.Windows.Forms.Label();
            this.cbTicket = new System.Windows.Forms.ComboBox();
            this.cbCustContact = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btBook = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.lbPaid = new System.Windows.Forms.Label();
            this.dgCustData = new System.Windows.Forms.DataGridView();
            this.dgFlightData = new System.Windows.Forms.DataGridView();
            this.dgBookingData = new System.Windows.Forms.DataGridView();
            this.tbDepTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlightData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(125, 236);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(136, 20);
            this.tbPrice.TabIndex = 7;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.AutoSize = true;
            this.lbDepartureTime.Location = new System.Drawing.Point(356, 245);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(83, 13);
            this.lbDepartureTime.TabIndex = 70;
            this.lbDepartureTime.Text = "Departure Time:";
            // 
            // mcDate
            // 
            this.mcDate.Enabled = false;
            this.mcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcDate.Location = new System.Drawing.Point(457, 68);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 9;
            // 
            // lbFlightOrigin
            // 
            this.lbFlightOrigin.AutoSize = true;
            this.lbFlightOrigin.Location = new System.Drawing.Point(24, 135);
            this.lbFlightOrigin.Name = "lbFlightOrigin";
            this.lbFlightOrigin.Size = new System.Drawing.Size(65, 13);
            this.lbFlightOrigin.TabIndex = 63;
            this.lbFlightOrigin.Text = "Depart from:";
            // 
            // tbDepart
            // 
            this.tbDepart.Location = new System.Drawing.Point(125, 132);
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.ReadOnly = true;
            this.tbDepart.Size = new System.Drawing.Size(136, 20);
            this.tbDepart.TabIndex = 3;
            // 
            // lbFlightDestination
            // 
            this.lbFlightDestination.AutoSize = true;
            this.lbFlightDestination.Location = new System.Drawing.Point(23, 160);
            this.lbFlightDestination.Name = "lbFlightDestination";
            this.lbFlightDestination.Size = new System.Drawing.Size(63, 13);
            this.lbFlightDestination.TabIndex = 64;
            this.lbFlightDestination.Text = "Destination:";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(125, 157);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.ReadOnly = true;
            this.tbDestination.Size = new System.Drawing.Size(136, 20);
            this.tbDestination.TabIndex = 4;
            // 
            // lbSeatCapacity
            // 
            this.lbSeatCapacity.AutoSize = true;
            this.lbSeatCapacity.Location = new System.Drawing.Point(23, 186);
            this.lbSeatCapacity.Name = "lbSeatCapacity";
            this.lbSeatCapacity.Size = new System.Drawing.Size(72, 13);
            this.lbSeatCapacity.TabIndex = 65;
            this.lbSeatCapacity.Text = "Seat Number:";
            // 
            // lbNewBooking
            // 
            this.lbNewBooking.AutoSize = true;
            this.lbNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewBooking.Location = new System.Drawing.Point(260, 9);
            this.lbNewBooking.Name = "lbNewBooking";
            this.lbNewBooking.Size = new System.Drawing.Size(179, 20);
            this.lbNewBooking.TabIndex = 69;
            this.lbNewBooking.Text = "Confirm Booking Details";
            // 
            // tbSeat
            // 
            this.tbSeat.Location = new System.Drawing.Point(125, 183);
            this.tbSeat.MaxLength = 3;
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.Size = new System.Drawing.Size(136, 20);
            this.tbSeat.TabIndex = 5;
            // 
            // lbFlightDeparture
            // 
            this.lbFlightDeparture.AutoSize = true;
            this.lbFlightDeparture.Location = new System.Drawing.Point(356, 68);
            this.lbFlightDeparture.Name = "lbFlightDeparture";
            this.lbFlightDeparture.Size = new System.Drawing.Size(83, 13);
            this.lbFlightDeparture.TabIndex = 66;
            this.lbFlightDeparture.Text = "Departure Date:";
            // 
            // lbEstimate
            // 
            this.lbEstimate.AutoSize = true;
            this.lbEstimate.Location = new System.Drawing.Point(356, 274);
            this.lbEstimate.Name = "lbEstimate";
            this.lbEstimate.Size = new System.Drawing.Size(88, 13);
            this.lbEstimate.TabIndex = 67;
            this.lbEstimate.Text = "Estimated Arrival:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(24, 239);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 68;
            this.lbPrice.Text = "Cost:";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(457, 271);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.ReadOnly = true;
            this.tbDuration.Size = new System.Drawing.Size(136, 20);
            this.tbDuration.TabIndex = 11;
            // 
            // lbCustName
            // 
            this.lbCustName.AutoSize = true;
            this.lbCustName.Location = new System.Drawing.Point(24, 82);
            this.lbCustName.Name = "lbCustName";
            this.lbCustName.Size = new System.Drawing.Size(54, 13);
            this.lbCustName.TabIndex = 77;
            this.lbCustName.Text = "Customer:";
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Location = new System.Drawing.Point(24, 212);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(64, 13);
            this.lbTicket.TabIndex = 78;
            this.lbTicket.Text = "Ticket Type";
            // 
            // cbTicket
            // 
            this.cbTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicket.FormattingEnabled = true;
            this.cbTicket.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Infant"});
            this.cbTicket.Location = new System.Drawing.Point(125, 209);
            this.cbTicket.Name = "cbTicket";
            this.cbTicket.Size = new System.Drawing.Size(136, 21);
            this.cbTicket.TabIndex = 6;
            this.cbTicket.SelectedIndexChanged += new System.EventHandler(this.cbTicket_SelectedIndexChanged);
            // 
            // cbCustContact
            // 
            this.cbCustContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustContact.FormattingEnabled = true;
            this.cbCustContact.Location = new System.Drawing.Point(125, 79);
            this.cbCustContact.Name = "cbCustContact";
            this.cbCustContact.Size = new System.Drawing.Size(136, 21);
            this.cbCustContact.TabIndex = 0;
            this.cbCustContact.SelectedIndexChanged += new System.EventHandler(this.cbCustContact_SelectedIndexChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(125, 106);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(136, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(24, 109);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 82;
            this.lbEmail.Text = "Email:";
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(53, 334);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(75, 23);
            this.btBook.TabIndex = 12;
            this.btBook.Text = "Book";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(53, 334);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 13;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // chkPaid
            // 
            this.chkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaid.Location = new System.Drawing.Point(125, 263);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(14, 15);
            this.chkPaid.TabIndex = 8;
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPaid.Location = new System.Drawing.Point(24, 265);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(34, 13);
            this.lbPaid.TabIndex = 86;
            this.lbPaid.Text = "Paid?";
            // 
            // dgCustData
            // 
            this.dgCustData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustData.Location = new System.Drawing.Point(366, 366);
            this.dgCustData.Name = "dgCustData";
            this.dgCustData.Size = new System.Drawing.Size(105, 80);
            this.dgCustData.TabIndex = 87;
            this.dgCustData.Visible = false;
            // 
            // dgFlightData
            // 
            this.dgFlightData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlightData.Location = new System.Drawing.Point(490, 366);
            this.dgFlightData.Name = "dgFlightData";
            this.dgFlightData.Size = new System.Drawing.Size(105, 80);
            this.dgFlightData.TabIndex = 88;
            this.dgFlightData.Visible = false;
            // 
            // dgBookingData
            // 
            this.dgBookingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookingData.Location = new System.Drawing.Point(612, 366);
            this.dgBookingData.Name = "dgBookingData";
            this.dgBookingData.Size = new System.Drawing.Size(105, 80);
            this.dgBookingData.TabIndex = 89;
            this.dgBookingData.Visible = false;
            // 
            // tbDepTime
            // 
            this.tbDepTime.Location = new System.Drawing.Point(457, 242);
            this.tbDepTime.Name = "tbDepTime";
            this.tbDepTime.ReadOnly = true;
            this.tbDepTime.Size = new System.Drawing.Size(136, 20);
            this.tbDepTime.TabIndex = 10;
            // 
            // addBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 363);
            this.Controls.Add(this.tbDepTime);
            this.Controls.Add(this.dgBookingData);
            this.Controls.Add(this.dgFlightData);
            this.Controls.Add(this.dgCustData);
            this.Controls.Add(this.chkPaid);
            this.Controls.Add(this.lbPaid);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.cbCustContact);
            this.Controls.Add(this.cbTicket);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbCustName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbDepartureTime);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.lbFlightOrigin);
            this.Controls.Add(this.tbDepart);
            this.Controls.Add(this.lbFlightDestination);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.lbSeatCapacity);
            this.Controls.Add(this.lbNewBooking);
            this.Controls.Add(this.tbSeat);
            this.Controls.Add(this.lbFlightDeparture);
            this.Controls.Add(this.lbEstimate);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.btUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addBookings";
            this.Text = "addBookings";
            this.Load += new System.EventHandler(this.addBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlightData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label lbFlightOrigin;
        private System.Windows.Forms.TextBox tbDepart;
        private System.Windows.Forms.Label lbFlightDestination;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label lbSeatCapacity;
        private System.Windows.Forms.Label lbNewBooking;
        private System.Windows.Forms.TextBox tbSeat;
        private System.Windows.Forms.Label lbFlightDeparture;
        private System.Windows.Forms.Label lbEstimate;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label lbCustName;
        private System.Windows.Forms.Label lbTicket;
        private System.Windows.Forms.ComboBox cbTicket;
        private System.Windows.Forms.ComboBox cbCustContact;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.DataGridView dgCustData;
        private System.Windows.Forms.DataGridView dgFlightData;
        private System.Windows.Forms.DataGridView dgBookingData;
        private System.Windows.Forms.TextBox tbDepTime;
    }
}