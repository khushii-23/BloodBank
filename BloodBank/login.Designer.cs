namespace BloodBank
{
    partial class signup
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.LinkLabel();
            this.Signin = new System.Windows.Forms.Button();
            this.bnk = new System.Windows.Forms.ComboBox();
            this.loc = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHideShow = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.cpass = new System.Windows.Forms.TextBox();
            this.btnUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.Location = new System.Drawing.Point(90, 157);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 41);
            label2.TabIndex = 1;
            label2.Text = " Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label6.Location = new System.Drawing.Point(78, 230);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(165, 41);
            label6.TabIndex = 90;
            label6.Text = "Admin Id ";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label7.Location = new System.Drawing.Point(78, 297);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(165, 41);
            label7.TabIndex = 92;
            label7.Text = "Location";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label8.Location = new System.Drawing.Point(78, 362);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(165, 41);
            label8.TabIndex = 95;
            label8.Text = "Blood Bank";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.Signin);
            this.panel1.Controls.Add(this.bnk);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(this.loc);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.uid);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnClos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnHideShow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.cpass);
            this.panel1.Controls.Add(this.btnUsername);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(189, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 796);
            this.panel1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn1.Location = new System.Drawing.Point(511, 426);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 26);
            this.btn1.TabIndex = 98;
            this.btn1.TabStop = true;
            this.btn1.Text = "Show";
            this.btn1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Signin
            // 
            this.Signin.BackColor = System.Drawing.Color.Transparent;
            this.Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Signin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signin.Location = new System.Drawing.Point(427, 703);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(125, 40);
            this.Signin.TabIndex = 97;
            this.Signin.Text = "Sign In";
            this.Signin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Signin.UseVisualStyleBackColor = false;
            this.Signin.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnk
            // 
            this.bnk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bnk.DropDownWidth = 390;
            this.bnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bnk.FormattingEnabled = true;
            this.bnk.Items.AddRange(new object[] {
            "Ashtavinayak Blood Bank",
            "Dr.Jondhale Nitysewa Blood Bank",
            "Pravara Medical Trust Blood Bank",
            "Rotary Blood Bank, Rahuri Charitable Trust, Rahuri",
            "Sanjeevani Blood Centre, Kopergaon, Ahmednagar",
            "Shri Sainath Blood Bank",
            "Adarsh Sanskaar Mandal Sanchalit, Dr. Hedgewar Rakta Pedhi, Akola",
            "Dattaji Bhale Blood Bank",
            "MGM Medical College and Hospital Blood Bank",
            "General Hospital Blood Bank",
            "Saibai Mote General Hospital Blood Bank",
            "Civil Hospital,General Hospital Blood Bank",
            "Civil Hospital Blood Bank",
            "Civil Hospital and GMC Blood Bank",
            "Godavari Foundation’s Dr.Ulhas Patil Medical College Blood Bank",
            "Indian Red Cross Society Blood Bank",
            "Jeevanshri Blood Bank",
            "Madhavrao Golwalkar Swayamsevi Blood Bank",
            "Noor Hospital Blood Bank",
            "Acharya Shree Tulsi Blood Bank",
            "Dr. D.Y Patil Hospital Blood Bank, Kadamwadi",
            "Jeevandhara blood bank, rajarampuri",
            "Late Balasaheb Datey Lions Blood Bank",
            "Sanjeevan Blood Bank",
            "IRCS Dr.Bhalchandra Blood Bank",
            "IRCS Nagappa Ambarkhan Blood Bank",
            "Ashirwad Blood Bank",
            "Asian Heart Institute Blood Bank",
            "Bombay Hospital Blood Bank",
            "Borivali Blood Bank (Doshi Memorial Charitable Trust)",
            "Dr. L. H. Hiranandani Hospital, Blood Bank",
            "Fortis Hospital Blood Bank",
            "K.J.Somaiya Medical College Blood Bank",
            "L.T.M.G., Municipal Hospital Blood Bank",
            "Lilavati Hospital Blood Bank",
            "Manas Serological Institute Blood Bank",
            "Meenatai Thackeray (Prabhodhan) Blood Bank",
            "Ms. Sion Blood bank",
            "P.D. Hinduja Hospital And Medical Research, Blood Bank",
            "Pallavi Blood Bank",
            "Rajwadi Hospital Blood Bank",
            "Saraswati Vidyaprasarak Foundation, Navjivan Blood Bank & Lab.",
            "Sir. J.J. Group Hospital Blood Bank",
            "Suburban Hi-tech Blood Bank",
            "Dattatreya Blood Bank",
            "Jeevan Jyoti Blood Bank & Component",
            "Model Blood Bank GMCH",
            "Sewa Blood Bank",
            "Dr.Shankarrao Chavan Medical College Blood Bank",
            "Gurugobind singhji Blood Bank",
            "Omkar Bahuuddesshiya Sevabhavi Sanstha’s, Sawami Vivekanad Blood Bank",
            "Arpan Blood Bank & Blood Component Laboratory & Research Centre",
            "Janakalyan Blood Bank",
            "Late. Dr. G.M. Bhavsar Charitable Trust’s, Malegaon Blood Bank",
            "Sanjeevani Blood Bank",
            "Shrikrishna Blood Bank",
            "P.Cottage Hospital Blood Bank Jawhar",
            "Civil Surgeon, District General Hospital Blood Bank",
            "Adhar Blood Bank",
            "Grant Medical Foundation, A.H. Wadia Trust Blood Bank",
            "IRCS Late Manikbai Chandulal Saraf Blood Bank",
            "Jupiter Life Line Hospital Blood Bank",
            "Sadhu Vaswani Mission Medical Complex, Inlaks & Budharani Hospital Blood Bank",
            "Civil Surgeon, District Blood Bank",
            "Janakalyan Blood Bank",
            "Miraj Serological Institute Blood Bank",
            "Smt. Anila Kantilal Kothari Blood Bank & dept. of hemato Oncology",
            "Vasantdada Patil Blood Bank & Haematology Research Centre",
            "Civil Surgeon, Sarva Samanya Hospital Blood Bank",
            "Krishna Hospital Blood Bank",
            "Mauli Blood Bank",
            "Akshay Blood Bank",
            "Dr.Hedgewar Blood Bank",
            "IMA Charitable Trust, S.M.S Mohite Patil Blood Bank",
            "S.C.S.M General Hospital Blood Bank",
            "CSM Hospital Blood Bank",
            "Jupiter Hospital Blood Bank",
            "Lokmanya TSSIA Blood Bank",
            "Mahatma Gandhi Blood Bank, operated by TASK, Naupada",
            "Mira Bhayandar Muncipal Corporation Rajeev Gandhi Blood Bank",
            "Civil Hopital Blood Bank"});
            this.bnk.Location = new System.Drawing.Point(292, 362);
            this.bnk.Name = "bnk";
            this.bnk.Size = new System.Drawing.Size(286, 37);
            this.bnk.TabIndex = 96;
            // 
            // loc
            // 
            this.loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loc.DropDownWidth = 300;
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loc.FormattingEnabled = true;
            this.loc.ItemHeight = 29;
            this.loc.Items.AddRange(new object[] {
            "Ahmednagar",
            "Akola",
            "Aurangabad",
            "Bhandara",
            "Buldhana",
            "Chandrapur",
            "Hingoli",
            "Jalgaon",
            "Jalna",
            "Kolhapur",
            "Latur",
            "Mumbai",
            "Nagpur",
            "Nanded",
            "Nashik",
            "Osmanabad",
            "Palghar",
            "Parbhani",
            "Pune",
            "Raigad",
            "Sangli",
            "Satara",
            "Solapur",
            "Thane",
            "Washim"});
            this.loc.Location = new System.Drawing.Point(288, 297);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(290, 37);
            this.loc.TabIndex = 94;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pass.Location = new System.Drawing.Point(292, 421);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(286, 34);
            this.pass.TabIndex = 93;
            // 
            // uid
            // 
            this.uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uid.Location = new System.Drawing.Point(283, 233);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(295, 34);
            this.uid.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(90, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 40);
            this.label4.TabIndex = 89;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClos
            // 
            this.btnClos.BackColor = System.Drawing.Color.Transparent;
            this.btnClos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClos.Location = new System.Drawing.Point(1016, 715);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(125, 40);
            this.btnClos.TabIndex = 88;
            this.btnClos.Text = "Sign In";
            this.btnClos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClos.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(263, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Register Here";
            // 
            // btnHideShow
            // 
            this.btnHideShow.AutoSize = true;
            this.btnHideShow.BackColor = System.Drawing.Color.White;
            this.btnHideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnHideShow.Location = new System.Drawing.Point(511, 498);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(67, 26);
            this.btnHideShow.TabIndex = 9;
            this.btnHideShow.TabStop = true;
            this.btnHideShow.Text = "Show";
            this.btnHideShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHideShow_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(148, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Already have account? ";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Red;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(292, 603);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(142, 64);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // cpass
            // 
            this.cpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cpass.Location = new System.Drawing.Point(292, 493);
            this.cpass.Name = "cpass";
            this.cpass.PasswordChar = '*';
            this.cpass.Size = new System.Drawing.Size(286, 34);
            this.cpass.TabIndex = 3;
            // 
            // btnUsername
            // 
            this.btnUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUsername.Location = new System.Drawing.Point(283, 157);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(295, 34);
            this.btnUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(62, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1686, 952);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "signup";
            this.Text = "signup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel btnHideShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.TextBox btnUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox loc;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.ComboBox bnk;
        private System.Windows.Forms.Button Signin;
        private System.Windows.Forms.LinkLabel btn1;
    }
}