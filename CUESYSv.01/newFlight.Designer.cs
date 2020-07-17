namespace CUESYSv._01
{
    partial class newFlight
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
            this.lbFlightOrigin = new System.Windows.Forms.Label();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.btFlightDelete = new System.Windows.Forms.Button();
            this.lbFlightDestination = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.btFlightSave = new System.Windows.Forms.Button();
            this.lbSeatCapacity = new System.Windows.Forms.Label();
            this.lbCustTitle = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.lbFlightDeparture = new System.Windows.Forms.Label();
            this.lbFlightDuration = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.btFlightUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChild = new System.Windows.Forms.TextBox();
            this.tbInfant = new System.Windows.Forms.TextBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.lbChild = new System.Windows.Forms.Label();
            this.lbInfant = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.dtDepTime = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFlightOrigin
            // 
            this.lbFlightOrigin.AutoSize = true;
            this.lbFlightOrigin.Location = new System.Drawing.Point(31, 37);
            this.lbFlightOrigin.Name = "lbFlightOrigin";
            this.lbFlightOrigin.Size = new System.Drawing.Size(37, 13);
            this.lbFlightOrigin.TabIndex = 31;
            this.lbFlightOrigin.Text = "Origin:";
            // 
            // tbOrigin
            // 
            this.tbOrigin.Location = new System.Drawing.Point(132, 37);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbOrigin.TabIndex = 1;
            // 
            // btFlightDelete
            // 
            this.btFlightDelete.Location = new System.Drawing.Point(379, 326);
            this.btFlightDelete.Name = "btFlightDelete";
            this.btFlightDelete.Size = new System.Drawing.Size(100, 23);
            this.btFlightDelete.TabIndex = 48;
            this.btFlightDelete.Text = "Delete";
            this.btFlightDelete.UseVisualStyleBackColor = true;
            this.btFlightDelete.Visible = false;
            // 
            // lbFlightDestination
            // 
            this.lbFlightDestination.AutoSize = true;
            this.lbFlightDestination.Location = new System.Drawing.Point(31, 65);
            this.lbFlightDestination.Name = "lbFlightDestination";
            this.lbFlightDestination.Size = new System.Drawing.Size(63, 13);
            this.lbFlightDestination.TabIndex = 33;
            this.lbFlightDestination.Text = "Destination:";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(132, 62);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(100, 20);
            this.tbDestination.TabIndex = 2;
            // 
            // btFlightSave
            // 
            this.btFlightSave.Location = new System.Drawing.Point(273, 326);
            this.btFlightSave.Name = "btFlightSave";
            this.btFlightSave.Size = new System.Drawing.Size(100, 23);
            this.btFlightSave.TabIndex = 8;
            this.btFlightSave.Text = "Save";
            this.btFlightSave.UseVisualStyleBackColor = true;
            this.btFlightSave.Click += new System.EventHandler(this.btFlightSave_Click);
            // 
            // lbSeatCapacity
            // 
            this.lbSeatCapacity.AutoSize = true;
            this.lbSeatCapacity.Location = new System.Drawing.Point(30, 91);
            this.lbSeatCapacity.Name = "lbSeatCapacity";
            this.lbSeatCapacity.Size = new System.Drawing.Size(76, 13);
            this.lbSeatCapacity.TabIndex = 35;
            this.lbSeatCapacity.Text = "Seat Capacity:";
            // 
            // lbCustTitle
            // 
            this.lbCustTitle.AutoSize = true;
            this.lbCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustTitle.Location = new System.Drawing.Point(119, 9);
            this.lbCustTitle.Name = "lbCustTitle";
            this.lbCustTitle.Size = new System.Drawing.Size(148, 20);
            this.lbCustTitle.TabIndex = 45;
            this.lbCustTitle.Text = "Create a New Flight";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(132, 88);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(100, 20);
            this.tbCapacity.TabIndex = 3;
            this.tbCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCapacity_KeyPress);
            // 
            // lbFlightDeparture
            // 
            this.lbFlightDeparture.AutoSize = true;
            this.lbFlightDeparture.Location = new System.Drawing.Point(259, 37);
            this.lbFlightDeparture.Name = "lbFlightDeparture";
            this.lbFlightDeparture.Size = new System.Drawing.Size(83, 13);
            this.lbFlightDeparture.TabIndex = 37;
            this.lbFlightDeparture.Text = "Departure Date:";
            // 
            // lbFlightDuration
            // 
            this.lbFlightDuration.AutoSize = true;
            this.lbFlightDuration.Location = new System.Drawing.Point(259, 236);
            this.lbFlightDuration.Name = "lbFlightDuration";
            this.lbFlightDuration.Size = new System.Drawing.Size(87, 13);
            this.lbFlightDuration.TabIndex = 39;
            this.lbFlightDuration.Text = "Duration (Hours):";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(30, 182);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(76, 13);
            this.lbPrice.TabIndex = 41;
            this.lbPrice.Text = "Adult Price (£):";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(360, 233);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(100, 20);
            this.tbDuration.TabIndex = 6;
            this.tbDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // btFlightUpdate
            // 
            this.btFlightUpdate.Location = new System.Drawing.Point(167, 326);
            this.btFlightUpdate.Name = "btFlightUpdate";
            this.btFlightUpdate.Size = new System.Drawing.Size(100, 23);
            this.btFlightUpdate.TabIndex = 47;
            this.btFlightUpdate.Text = "Update";
            this.btFlightUpdate.UseVisualStyleBackColor = true;
            this.btFlightUpdate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Departure Time:";
            // 
            // tbChild
            // 
            this.tbChild.Location = new System.Drawing.Point(132, 205);
            this.tbChild.Name = "tbChild";
            this.tbChild.ReadOnly = true;
            this.tbChild.Size = new System.Drawing.Size(100, 20);
            this.tbChild.TabIndex = 51;
            this.tbChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbInfant
            // 
            this.tbInfant.Location = new System.Drawing.Point(132, 231);
            this.tbInfant.Name = "tbInfant";
            this.tbInfant.ReadOnly = true;
            this.tbInfant.Size = new System.Drawing.Size(100, 20);
            this.tbInfant.TabIndex = 52;
            this.tbInfant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbChild
            // 
            this.lbChild.AutoSize = true;
            this.lbChild.Location = new System.Drawing.Point(30, 208);
            this.lbChild.Name = "lbChild";
            this.lbChild.Size = new System.Drawing.Size(75, 13);
            this.lbChild.TabIndex = 54;
            this.lbChild.Text = "Child Price (£):";
            // 
            // lbInfant
            // 
            this.lbInfant.AutoSize = true;
            this.lbInfant.Location = new System.Drawing.Point(31, 234);
            this.lbInfant.Name = "lbInfant";
            this.lbInfant.Size = new System.Drawing.Size(79, 13);
            this.lbInfant.TabIndex = 55;
            this.lbInfant.Text = "Infant Price (£):";
            // 
            // mcDate
            // 
            this.mcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcDate.Location = new System.Drawing.Point(360, 37);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 4;
            // 
            // dtDepTime
            // 
            this.dtDepTime.CustomFormat = "HH:mm ";
            this.dtDepTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepTime.Location = new System.Drawing.Point(360, 208);
            this.dtDepTime.Name = "dtDepTime";
            this.dtDepTime.ShowUpDown = true;
            this.dtDepTime.Size = new System.Drawing.Size(100, 20);
            this.dtDepTime.TabIndex = 5;
            this.dtDepTime.Value = new System.DateTime(2020, 7, 9, 9, 0, 0, 0);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(132, 179);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 56;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            this.tbPrice.Leave += new System.EventHandler(this.tbPrice_Leave);
            // 
            // newFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 384);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.dtDepTime);
            this.Controls.Add(this.lbInfant);
            this.Controls.Add(this.lbChild);
            this.Controls.Add(this.tbInfant);
            this.Controls.Add(this.tbChild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.lbFlightOrigin);
            this.Controls.Add(this.tbOrigin);
            this.Controls.Add(this.btFlightDelete);
            this.Controls.Add(this.lbFlightDestination);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.btFlightSave);
            this.Controls.Add(this.lbSeatCapacity);
            this.Controls.Add(this.lbCustTitle);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.lbFlightDeparture);
            this.Controls.Add(this.lbFlightDuration);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.btFlightUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "newFlight";
            this.Text = "Add New Flight - BT Airlines";
            this.Load += new System.EventHandler(this.newFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFlightOrigin;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.Button btFlightDelete;
        private System.Windows.Forms.Label lbFlightDestination;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btFlightSave;
        private System.Windows.Forms.Label lbSeatCapacity;
        private System.Windows.Forms.Label lbCustTitle;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label lbFlightDeparture;
        private System.Windows.Forms.Label lbFlightDuration;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Button btFlightUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChild;
        private System.Windows.Forms.TextBox tbInfant;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label lbChild;
        private System.Windows.Forms.Label lbInfant;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.DateTimePicker dtDepTime;
        private System.Windows.Forms.TextBox tbPrice;
    }
}