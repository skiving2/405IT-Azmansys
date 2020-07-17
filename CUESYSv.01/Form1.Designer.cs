namespace CUESYSv._01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPass = new System.Windows.Forms.Label();
            this.lbCueSys = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.panClock = new System.Windows.Forms.Panel();
            this.lbClockSeconds = new System.Windows.Forms.Label();
            this.lbClockDate = new System.Windows.Forms.Label();
            this.lbClockTime = new System.Windows.Forms.Label();
            this.timeClock = new System.Windows.Forms.Timer(this.components);
            this.dgRoomBookingsSummary = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDevLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.lbCustContact = new System.Windows.Forms.Label();
            this.tbCustContact = new System.Windows.Forms.TextBox();
            this.tbCustEmail = new System.Windows.Forms.TextBox();
            this.lbCustEmail = new System.Windows.Forms.Label();
            this.tbCustTel = new System.Windows.Forms.TextBox();
            this.lbCustTel = new System.Windows.Forms.Label();
            this.tbCustTownCity = new System.Windows.Forms.TextBox();
            this.lbCustTownCity = new System.Windows.Forms.Label();
            this.tbCustAdd2 = new System.Windows.Forms.TextBox();
            this.lbCustAdd2 = new System.Windows.Forms.Label();
            this.tbCustAdd1 = new System.Windows.Forms.TextBox();
            this.lbCustAdd1 = new System.Windows.Forms.Label();
            this.tbCustPostcode = new System.Windows.Forms.TextBox();
            this.lbCustPostcode = new System.Windows.Forms.Label();
            this.lbCustTitle = new System.Windows.Forms.Label();
            this.btCustSave = new System.Windows.Forms.Button();
            this.btCustUpdate = new System.Windows.Forms.Button();
            this.btCustDelete = new System.Windows.Forms.Button();
            this.btBook = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lbBookingInfo = new System.Windows.Forms.Label();
            this.panAddCust = new System.Windows.Forms.Panel();
            this.lblAddCust = new System.Windows.Forms.Label();
            this.panBookingCalendar = new System.Windows.Forms.Panel();
            this.lblBookingCalendar = new System.Windows.Forms.Label();
            this.panLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panAddBooking = new System.Windows.Forms.Panel();
            this.btBookingCont = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbOrigin = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.dgFlightQuery = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.panViewData = new System.Windows.Forms.Panel();
            this.btDeleteRecord = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomBookingsSummary)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.panAddCust.SuspendLayout();
            this.panBookingCalendar.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.panAddBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlightQuery)).BeginInit();
            this.panViewData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(341, 130);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // tbUserPass
            // 
            this.tbUserPass.Location = new System.Drawing.Point(341, 165);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.PasswordChar = '*';
            this.tbUserPass.Size = new System.Drawing.Size(100, 20);
            this.tbUserPass.TabIndex = 1;
            this.tbUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserPass_KeyDown);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(272, 136);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Username";
            // 
            // lbUserPass
            // 
            this.lbUserPass.AutoSize = true;
            this.lbUserPass.Location = new System.Drawing.Point(275, 171);
            this.lbUserPass.Name = "lbUserPass";
            this.lbUserPass.Size = new System.Drawing.Size(53, 13);
            this.lbUserPass.TabIndex = 3;
            this.lbUserPass.Text = "Password";
            // 
            // lbCueSys
            // 
            this.lbCueSys.AutoSize = true;
            this.lbCueSys.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCueSys.Location = new System.Drawing.Point(267, 24);
            this.lbCueSys.Name = "lbCueSys";
            this.lbCueSys.Size = new System.Drawing.Size(277, 75);
            this.lbCueSys.TabIndex = 4;
            this.lbCueSys.Text = "CUE SYS";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(355, 258);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panClock
            // 
            this.panClock.BackColor = System.Drawing.SystemColors.Control;
            this.panClock.Controls.Add(this.lbClockSeconds);
            this.panClock.Controls.Add(this.lbClockDate);
            this.panClock.Controls.Add(this.lbClockTime);
            this.panClock.Location = new System.Drawing.Point(646, 9);
            this.panClock.Name = "panClock";
            this.panClock.Size = new System.Drawing.Size(142, 55);
            this.panClock.TabIndex = 6;
            // 
            // lbClockSeconds
            // 
            this.lbClockSeconds.AutoSize = true;
            this.lbClockSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lbClockSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockSeconds.Location = new System.Drawing.Point(122, 23);
            this.lbClockSeconds.Name = "lbClockSeconds";
            this.lbClockSeconds.Size = new System.Drawing.Size(0, 9);
            this.lbClockSeconds.TabIndex = 0;
            // 
            // lbClockDate
            // 
            this.lbClockDate.AutoSize = true;
            this.lbClockDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockDate.Location = new System.Drawing.Point(142, 0);
            this.lbClockDate.Name = "lbClockDate";
            this.lbClockDate.Size = new System.Drawing.Size(0, 16);
            this.lbClockDate.TabIndex = 2;
            // 
            // lbClockTime
            // 
            this.lbClockTime.AutoSize = true;
            this.lbClockTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockTime.Location = new System.Drawing.Point(65, 23);
            this.lbClockTime.Name = "lbClockTime";
            this.lbClockTime.Size = new System.Drawing.Size(0, 29);
            this.lbClockTime.TabIndex = 1;
            // 
            // timeClock
            // 
            this.timeClock.Enabled = true;
            this.timeClock.Interval = 1000;
            this.timeClock.Tick += new System.EventHandler(this.timeClock_Tick);
            // 
            // dgRoomBookingsSummary
            // 
            this.dgRoomBookingsSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomBookingsSummary.Location = new System.Drawing.Point(12, 65);
            this.dgRoomBookingsSummary.Name = "dgRoomBookingsSummary";
            this.dgRoomBookingsSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoomBookingsSummary.Size = new System.Drawing.Size(776, 351);
            this.dgRoomBookingsSummary.TabIndex = 7;
            this.dgRoomBookingsSummary.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRoomBookingsSummary_CellMouseDoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.flightsToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDevLogsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewDevLogsToolStripMenuItem
            // 
            this.viewDevLogsToolStripMenuItem.Enabled = false;
            this.viewDevLogsToolStripMenuItem.Name = "viewDevLogsToolStripMenuItem";
            this.viewDevLogsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewDevLogsToolStripMenuItem.Text = "View DevLogs";
            this.viewDevLogsToolStripMenuItem.Click += new System.EventHandler(this.viewDevLogsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Enabled = false;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customerToolStripMenuItem.Text = "Customers";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createCustomerToolStripMenuItem.Text = "Create Customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.createCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightToolStripMenuItem,
            this.viewFlightsToolStripMenuItem});
            this.flightsToolStripMenuItem.Enabled = false;
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // addFlightToolStripMenuItem
            // 
            this.addFlightToolStripMenuItem.Name = "addFlightToolStripMenuItem";
            this.addFlightToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.addFlightToolStripMenuItem.Text = "Add Flight";
            this.addFlightToolStripMenuItem.Click += new System.EventHandler(this.addFlightToolStripMenuItem_Click);
            // 
            // viewFlightsToolStripMenuItem
            // 
            this.viewFlightsToolStripMenuItem.Name = "viewFlightsToolStripMenuItem";
            this.viewFlightsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewFlightsToolStripMenuItem.Text = "View Flights";
            this.viewFlightsToolStripMenuItem.Click += new System.EventHandler(this.viewFlightsToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookRoomToolStripMenuItem,
            this.viewBookingsToolStripMenuItem});
            this.roomsToolStripMenuItem.Enabled = false;
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.roomsToolStripMenuItem.Text = "Bookings";
            // 
            // bookRoomToolStripMenuItem
            // 
            this.bookRoomToolStripMenuItem.Name = "bookRoomToolStripMenuItem";
            this.bookRoomToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookRoomToolStripMenuItem.Text = "Book Flights";
            this.bookRoomToolStripMenuItem.Click += new System.EventHandler(this.bookRoomToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewBookingsToolStripMenuItem_Click);
            // 
            // cbBuilding
            // 
            this.cbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Location = new System.Drawing.Point(256, 119);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(121, 21);
            this.cbBuilding.TabIndex = 12;
            this.cbBuilding.SelectedIndexChanged += new System.EventHandler(this.cbBuilding_SelectedIndexChanged);
            // 
            // lbCustContact
            // 
            this.lbCustContact.AutoSize = true;
            this.lbCustContact.Location = new System.Drawing.Point(300, 74);
            this.lbCustContact.Name = "lbCustContact";
            this.lbCustContact.Size = new System.Drawing.Size(91, 13);
            this.lbCustContact.TabIndex = 13;
            this.lbCustContact.Text = "Customer Contact";
            this.lbCustContact.Click += new System.EventHandler(this.lbCustContact_Click);
            // 
            // tbCustContact
            // 
            this.tbCustContact.Location = new System.Drawing.Point(404, 71);
            this.tbCustContact.Name = "tbCustContact";
            this.tbCustContact.Size = new System.Drawing.Size(100, 20);
            this.tbCustContact.TabIndex = 14;
            this.tbCustContact.TextChanged += new System.EventHandler(this.tbCustContact_TextChanged);
            // 
            // tbCustEmail
            // 
            this.tbCustEmail.Location = new System.Drawing.Point(404, 96);
            this.tbCustEmail.Name = "tbCustEmail";
            this.tbCustEmail.Size = new System.Drawing.Size(100, 20);
            this.tbCustEmail.TabIndex = 16;
            this.tbCustEmail.TextChanged += new System.EventHandler(this.tbCustEmail_TextChanged);
            // 
            // lbCustEmail
            // 
            this.lbCustEmail.AutoSize = true;
            this.lbCustEmail.Location = new System.Drawing.Point(300, 99);
            this.lbCustEmail.Name = "lbCustEmail";
            this.lbCustEmail.Size = new System.Drawing.Size(72, 13);
            this.lbCustEmail.TabIndex = 15;
            this.lbCustEmail.Text = "Contact Email";
            this.lbCustEmail.Click += new System.EventHandler(this.lbCustEmail_Click);
            // 
            // tbCustTel
            // 
            this.tbCustTel.Location = new System.Drawing.Point(404, 122);
            this.tbCustTel.Name = "tbCustTel";
            this.tbCustTel.Size = new System.Drawing.Size(100, 20);
            this.tbCustTel.TabIndex = 18;
            this.tbCustTel.TextChanged += new System.EventHandler(this.tbCustTel_TextChanged);
            // 
            // lbCustTel
            // 
            this.lbCustTel.AutoSize = true;
            this.lbCustTel.Location = new System.Drawing.Point(300, 125);
            this.lbCustTel.Name = "lbCustTel";
            this.lbCustTel.Size = new System.Drawing.Size(98, 13);
            this.lbCustTel.TabIndex = 17;
            this.lbCustTel.Text = "Contact Telephone";
            this.lbCustTel.Click += new System.EventHandler(this.lbCustTel_Click);
            // 
            // tbCustTownCity
            // 
            this.tbCustTownCity.Location = new System.Drawing.Point(404, 199);
            this.tbCustTownCity.Name = "tbCustTownCity";
            this.tbCustTownCity.Size = new System.Drawing.Size(100, 20);
            this.tbCustTownCity.TabIndex = 24;
            this.tbCustTownCity.TextChanged += new System.EventHandler(this.tbCustTownCity_TextChanged);
            // 
            // lbCustTownCity
            // 
            this.lbCustTownCity.AutoSize = true;
            this.lbCustTownCity.Location = new System.Drawing.Point(300, 202);
            this.lbCustTownCity.Name = "lbCustTownCity";
            this.lbCustTownCity.Size = new System.Drawing.Size(62, 13);
            this.lbCustTownCity.TabIndex = 23;
            this.lbCustTownCity.Text = "Town / City";
            this.lbCustTownCity.Click += new System.EventHandler(this.lbCustTownCity_Click);
            // 
            // tbCustAdd2
            // 
            this.tbCustAdd2.Location = new System.Drawing.Point(404, 173);
            this.tbCustAdd2.Name = "tbCustAdd2";
            this.tbCustAdd2.Size = new System.Drawing.Size(100, 20);
            this.tbCustAdd2.TabIndex = 22;
            this.tbCustAdd2.TextChanged += new System.EventHandler(this.tbCustAdd2_TextChanged);
            // 
            // lbCustAdd2
            // 
            this.lbCustAdd2.AutoSize = true;
            this.lbCustAdd2.Location = new System.Drawing.Point(300, 176);
            this.lbCustAdd2.Name = "lbCustAdd2";
            this.lbCustAdd2.Size = new System.Drawing.Size(77, 13);
            this.lbCustAdd2.TabIndex = 21;
            this.lbCustAdd2.Text = "Address Line 2";
            this.lbCustAdd2.Click += new System.EventHandler(this.lbCustAdd2_Click);
            // 
            // tbCustAdd1
            // 
            this.tbCustAdd1.Location = new System.Drawing.Point(404, 148);
            this.tbCustAdd1.Name = "tbCustAdd1";
            this.tbCustAdd1.Size = new System.Drawing.Size(100, 20);
            this.tbCustAdd1.TabIndex = 20;
            this.tbCustAdd1.TextChanged += new System.EventHandler(this.tbCustAdd1_TextChanged);
            // 
            // lbCustAdd1
            // 
            this.lbCustAdd1.AutoSize = true;
            this.lbCustAdd1.Location = new System.Drawing.Point(300, 151);
            this.lbCustAdd1.Name = "lbCustAdd1";
            this.lbCustAdd1.Size = new System.Drawing.Size(77, 13);
            this.lbCustAdd1.TabIndex = 19;
            this.lbCustAdd1.Text = "Address Line 1";
            this.lbCustAdd1.Click += new System.EventHandler(this.lbCustAdd1_Click);
            // 
            // tbCustPostcode
            // 
            this.tbCustPostcode.Location = new System.Drawing.Point(404, 225);
            this.tbCustPostcode.Name = "tbCustPostcode";
            this.tbCustPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbCustPostcode.TabIndex = 26;
            this.tbCustPostcode.TextChanged += new System.EventHandler(this.tbCustPostcode_TextChanged);
            // 
            // lbCustPostcode
            // 
            this.lbCustPostcode.AutoSize = true;
            this.lbCustPostcode.Location = new System.Drawing.Point(300, 228);
            this.lbCustPostcode.Name = "lbCustPostcode";
            this.lbCustPostcode.Size = new System.Drawing.Size(52, 13);
            this.lbCustPostcode.TabIndex = 25;
            this.lbCustPostcode.Text = "Postcode";
            this.lbCustPostcode.Click += new System.EventHandler(this.lbCustPostcode_Click);
            // 
            // lbCustTitle
            // 
            this.lbCustTitle.AutoSize = true;
            this.lbCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustTitle.Location = new System.Drawing.Point(335, 43);
            this.lbCustTitle.Name = "lbCustTitle";
            this.lbCustTitle.Size = new System.Drawing.Size(0, 20);
            this.lbCustTitle.TabIndex = 27;
            this.lbCustTitle.Click += new System.EventHandler(this.lbCustTitle_Click);
            // 
            // btCustSave
            // 
            this.btCustSave.Location = new System.Drawing.Point(404, 253);
            this.btCustSave.Name = "btCustSave";
            this.btCustSave.Size = new System.Drawing.Size(100, 23);
            this.btCustSave.TabIndex = 28;
            this.btCustSave.Text = "Save";
            this.btCustSave.UseVisualStyleBackColor = true;
            this.btCustSave.Click += new System.EventHandler(this.btCustSave_Click);
            // 
            // btCustUpdate
            // 
            this.btCustUpdate.Location = new System.Drawing.Point(298, 282);
            this.btCustUpdate.Name = "btCustUpdate";
            this.btCustUpdate.Size = new System.Drawing.Size(100, 23);
            this.btCustUpdate.TabIndex = 29;
            this.btCustUpdate.Text = "Update";
            this.btCustUpdate.UseVisualStyleBackColor = true;
            this.btCustUpdate.Click += new System.EventHandler(this.btCustUpdate_Click);
            // 
            // btCustDelete
            // 
            this.btCustDelete.Location = new System.Drawing.Point(404, 282);
            this.btCustDelete.Name = "btCustDelete";
            this.btCustDelete.Size = new System.Drawing.Size(100, 23);
            this.btCustDelete.TabIndex = 30;
            this.btCustDelete.Text = "Delete";
            this.btCustDelete.UseVisualStyleBackColor = true;
            this.btCustDelete.Click += new System.EventHandler(this.btCustDelete_Click);
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(501, 354);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(75, 23);
            this.btBook.TabIndex = 43;
            this.btBook.Text = "BOOK";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(349, 283);
            this.tbTime.Mask = "00:00";
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(40, 20);
            this.tbTime.TabIndex = 42;
            this.tbTime.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cost       £";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Paid (Y/N)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Customer";
            // 
            // mcDate
            // 
            this.mcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcDate.Location = new System.Drawing.Point(349, 111);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 36;
            // 
            // cbPaid
            // 
            this.cbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaid.Location = new System.Drawing.Point(356, 354);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(25, 25);
            this.cbPaid.TabIndex = 35;
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(349, 71);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(227, 29);
            this.tbCustomer.TabIndex = 34;
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(349, 309);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(227, 29);
            this.tbCost.TabIndex = 33;
            // 
            // lbBookingInfo
            // 
            this.lbBookingInfo.AutoSize = true;
            this.lbBookingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingInfo.Location = new System.Drawing.Point(352, 37);
            this.lbBookingInfo.Name = "lbBookingInfo";
            this.lbBookingInfo.Size = new System.Drawing.Size(133, 25);
            this.lbBookingInfo.TabIndex = 32;
            this.lbBookingInfo.Text = "xxxxxxxxxxx";
            // 
            // panAddCust
            // 
            this.panAddCust.Controls.Add(this.lblAddCust);
            this.panAddCust.Controls.Add(this.lbCustContact);
            this.panAddCust.Controls.Add(this.tbCustContact);
            this.panAddCust.Controls.Add(this.btCustDelete);
            this.panAddCust.Controls.Add(this.lbCustEmail);
            this.panAddCust.Controls.Add(this.tbCustEmail);
            this.panAddCust.Controls.Add(this.btCustSave);
            this.panAddCust.Controls.Add(this.lbCustTel);
            this.panAddCust.Controls.Add(this.lbCustTitle);
            this.panAddCust.Controls.Add(this.tbCustTel);
            this.panAddCust.Controls.Add(this.tbCustPostcode);
            this.panAddCust.Controls.Add(this.lbCustAdd1);
            this.panAddCust.Controls.Add(this.lbCustPostcode);
            this.panAddCust.Controls.Add(this.tbCustAdd1);
            this.panAddCust.Controls.Add(this.tbCustTownCity);
            this.panAddCust.Controls.Add(this.lbCustAdd2);
            this.panAddCust.Controls.Add(this.lbCustTownCity);
            this.panAddCust.Controls.Add(this.tbCustAdd2);
            this.panAddCust.Controls.Add(this.btCustUpdate);
            this.panAddCust.Location = new System.Drawing.Point(0, 392);
            this.panAddCust.Name = "panAddCust";
            this.panAddCust.Size = new System.Drawing.Size(99, 46);
            this.panAddCust.TabIndex = 44;
            // 
            // lblAddCust
            // 
            this.lblAddCust.AutoSize = true;
            this.lblAddCust.Location = new System.Drawing.Point(12, 8);
            this.lblAddCust.Name = "lblAddCust";
            this.lblAddCust.Size = new System.Drawing.Size(65, 13);
            this.lblAddCust.TabIndex = 45;
            this.lblAddCust.Text = "panAddCust";
            this.lblAddCust.Visible = false;
            // 
            // panBookingCalendar
            // 
            this.panBookingCalendar.Controls.Add(this.lblBookingCalendar);
            this.panBookingCalendar.Controls.Add(this.lbBookingInfo);
            this.panBookingCalendar.Controls.Add(this.tbCost);
            this.panBookingCalendar.Controls.Add(this.btBook);
            this.panBookingCalendar.Controls.Add(this.tbCustomer);
            this.panBookingCalendar.Controls.Add(this.tbTime);
            this.panBookingCalendar.Controls.Add(this.cbPaid);
            this.panBookingCalendar.Controls.Add(this.label5);
            this.panBookingCalendar.Controls.Add(this.mcDate);
            this.panBookingCalendar.Controls.Add(this.label4);
            this.panBookingCalendar.Controls.Add(this.label1);
            this.panBookingCalendar.Controls.Add(this.label3);
            this.panBookingCalendar.Controls.Add(this.label2);
            this.panBookingCalendar.Location = new System.Drawing.Point(667, 392);
            this.panBookingCalendar.Name = "panBookingCalendar";
            this.panBookingCalendar.Size = new System.Drawing.Size(121, 46);
            this.panBookingCalendar.TabIndex = 45;
            // 
            // lblBookingCalendar
            // 
            this.lblBookingCalendar.AutoSize = true;
            this.lblBookingCalendar.Location = new System.Drawing.Point(3, 6);
            this.lblBookingCalendar.Name = "lblBookingCalendar";
            this.lblBookingCalendar.Size = new System.Drawing.Size(106, 13);
            this.lblBookingCalendar.TabIndex = 44;
            this.lblBookingCalendar.Text = "panBookingCalendar";
            this.lblBookingCalendar.Visible = false;
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.lblLogin);
            this.panLogin.Controls.Add(this.lbUserName);
            this.panLogin.Controls.Add(this.tbUserName);
            this.panLogin.Controls.Add(this.tbUserPass);
            this.panLogin.Controls.Add(this.lbUserPass);
            this.panLogin.Controls.Add(this.btLogin);
            this.panLogin.Location = new System.Drawing.Point(346, 392);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(110, 46);
            this.panLogin.TabIndex = 46;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(3, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 13);
            this.lblLogin.TabIndex = 46;
            this.lblLogin.Text = "panLogin";
            this.lblLogin.Visible = false;
            // 
            // panAddBooking
            // 
            this.panAddBooking.Controls.Add(this.btBookingCont);
            this.panAddBooking.Controls.Add(this.label8);
            this.panAddBooking.Controls.Add(this.lbOrigin);
            this.panAddBooking.Controls.Add(this.lbDestination);
            this.panAddBooking.Controls.Add(this.dgFlightQuery);
            this.panAddBooking.Controls.Add(this.label6);
            this.panAddBooking.Controls.Add(this.cbBuilding);
            this.panAddBooking.Controls.Add(this.cbFloor);
            this.panAddBooking.Location = new System.Drawing.Point(510, 392);
            this.panAddBooking.Name = "panAddBooking";
            this.panAddBooking.Size = new System.Drawing.Size(116, 46);
            this.panAddBooking.TabIndex = 47;
            // 
            // btBookingCont
            // 
            this.btBookingCont.Location = new System.Drawing.Point(346, 211);
            this.btBookingCont.Name = "btBookingCont";
            this.btBookingCont.Size = new System.Drawing.Size(75, 23);
            this.btBookingCont.TabIndex = 52;
            this.btBookingCont.Text = "Continue";
            this.btBookingCont.UseVisualStyleBackColor = true;
            this.btBookingCont.Click += new System.EventHandler(this.btBookingCont_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(335, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Select a Flight";
            // 
            // lbOrigin
            // 
            this.lbOrigin.AutoSize = true;
            this.lbOrigin.Location = new System.Drawing.Point(423, 103);
            this.lbOrigin.Name = "lbOrigin";
            this.lbOrigin.Size = new System.Drawing.Size(34, 13);
            this.lbOrigin.TabIndex = 50;
            this.lbOrigin.Text = "Origin";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(256, 103);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(60, 13);
            this.lbDestination.TabIndex = 49;
            this.lbDestination.Text = "Destination";
            // 
            // dgFlightQuery
            // 
            this.dgFlightQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlightQuery.Location = new System.Drawing.Point(545, 261);
            this.dgFlightQuery.Name = "dgFlightQuery";
            this.dgFlightQuery.Size = new System.Drawing.Size(240, 150);
            this.dgFlightQuery.TabIndex = 48;
            this.dgFlightQuery.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "panAddBooking";
            this.label6.Visible = false;
            // 
            // cbFloor
            // 
            this.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Location = new System.Drawing.Point(404, 119);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(121, 21);
            this.cbFloor.TabIndex = 11;
            this.cbFloor.SelectedIndexChanged += new System.EventHandler(this.cbFloor_SelectedIndexChanged);
            // 
            // panViewData
            // 
            this.panViewData.Controls.Add(this.btDeleteRecord);
            this.panViewData.Controls.Add(this.btUpdate);
            this.panViewData.Controls.Add(this.label7);
            this.panViewData.Controls.Add(this.dgRoomBookingsSummary);
            this.panViewData.Location = new System.Drawing.Point(176, 392);
            this.panViewData.Name = "panViewData";
            this.panViewData.Size = new System.Drawing.Size(126, 46);
            this.panViewData.TabIndex = 48;
            // 
            // btDeleteRecord
            // 
            this.btDeleteRecord.Location = new System.Drawing.Point(469, 17);
            this.btDeleteRecord.Name = "btDeleteRecord";
            this.btDeleteRecord.Size = new System.Drawing.Size(75, 23);
            this.btDeleteRecord.TabIndex = 48;
            this.btDeleteRecord.Text = "Delete";
            this.btDeleteRecord.UseVisualStyleBackColor = true;
            this.btDeleteRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(551, 17);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 47;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "panViewData";
            this.label7.Visible = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWelcome.Location = new System.Drawing.Point(147, 125);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(526, 34);
            this.lbWelcome.TabIndex = 47;
            this.lbWelcome.Text = "Welcome, please select an option from the tool strip to manage bookings.";
            this.lbWelcome.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panClock);
            this.Controls.Add(this.panViewData);
            this.Controls.Add(this.panAddBooking);
            this.Controls.Add(this.panBookingCalendar);
            this.Controls.Add(this.panAddCust);
            this.Controls.Add(this.lbCueSys);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Azmansys v1.0 - BT Airlines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panClock.ResumeLayout(false);
            this.panClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomBookingsSummary)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panAddCust.ResumeLayout(false);
            this.panAddCust.PerformLayout();
            this.panBookingCalendar.ResumeLayout(false);
            this.panBookingCalendar.PerformLayout();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panAddBooking.ResumeLayout(false);
            this.panAddBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlightQuery)).EndInit();
            this.panViewData.ResumeLayout(false);
            this.panViewData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserPass;
        private System.Windows.Forms.Label lbCueSys;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panClock;
        private System.Windows.Forms.Label lbClockSeconds;
        private System.Windows.Forms.Label lbClockDate;
        private System.Windows.Forms.Label lbClockTime;
        private System.Windows.Forms.Timer timeClock;
        private System.Windows.Forms.DataGridView dgRoomBookingsSummary;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDevLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookRoomToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.Label lbCustContact;
        private System.Windows.Forms.TextBox tbCustContact;
        private System.Windows.Forms.TextBox tbCustEmail;
        private System.Windows.Forms.Label lbCustEmail;
        private System.Windows.Forms.TextBox tbCustTel;
        private System.Windows.Forms.Label lbCustTel;
        private System.Windows.Forms.TextBox tbCustTownCity;
        private System.Windows.Forms.Label lbCustTownCity;
        private System.Windows.Forms.TextBox tbCustAdd2;
        private System.Windows.Forms.Label lbCustAdd2;
        private System.Windows.Forms.TextBox tbCustAdd1;
        private System.Windows.Forms.Label lbCustAdd1;
        private System.Windows.Forms.TextBox tbCustPostcode;
        private System.Windows.Forms.Label lbCustPostcode;
        private System.Windows.Forms.Label lbCustTitle;
        private System.Windows.Forms.Button btCustSave;
        private System.Windows.Forms.Button btCustUpdate;
        private System.Windows.Forms.Button btCustDelete;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.MaskedTextBox tbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lbBookingInfo;
        private System.Windows.Forms.Panel panAddCust;
        private System.Windows.Forms.Panel panBookingCalendar;
        private System.Windows.Forms.Label lblBookingCalendar;
        private System.Windows.Forms.Label lblAddCust;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panAddBooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panViewData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFlightsToolStripMenuItem;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.DataGridView dgFlightQuery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Button btBookingCont;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btDeleteRecord;
    }
}

