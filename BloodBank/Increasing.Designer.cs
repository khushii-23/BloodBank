namespace BloodBank
{
    partial class Increasing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Increasing));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bloodgroup = new System.Windows.Forms.ComboBox();
            this.units = new System.Windows.Forms.ComboBox();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(650, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 71;
            this.label3.Text = "Units";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(207, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 44);
            this.label4.TabIndex = 66;
            this.label4.Text = "Blood Group";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bloodgroup
            // 
            this.bloodgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bloodgroup.FormattingEnabled = true;
            this.bloodgroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "O-",
            "AB-",
            "B-",
            "A-"});
            this.bloodgroup.Location = new System.Drawing.Point(431, 96);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(131, 37);
            this.bloodgroup.TabIndex = 72;
            // 
            // units
            // 
            this.units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.units.FormattingEnabled = true;
            this.units.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.units.Location = new System.Drawing.Point(747, 93);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(141, 37);
            this.units.TabIndex = 73;
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.Red;
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIncrease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncrease.Location = new System.Drawing.Point(954, 90);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(133, 56);
            this.btnIncrease.TabIndex = 81;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 357);
            this.dataGridView1.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 79;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClos
            // 
            this.btnClos.BackColor = System.Drawing.Color.Transparent;
            this.btnClos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClos.Image = ((System.Drawing.Image)(resources.GetObject("btnClos.Image")));
            this.btnClos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClos.Location = new System.Drawing.Point(1055, 567);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(117, 50);
            this.btnClos.TabIndex = 78;
            this.btnClos.Text = "Close";
            this.btnClos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(500, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 39);
            this.label2.TabIndex = 75;
            this.label2.Text = "STOCK (INCREASE)";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Increasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1342, 677);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.units);
            this.Controls.Add(this.bloodgroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Increasing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Increasing";
            this.Load += new System.EventHandler(this.Increasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bloodgroup;
        private System.Windows.Forms.ComboBox units;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}