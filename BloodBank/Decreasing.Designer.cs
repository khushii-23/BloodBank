namespace BloodBank
{
    partial class Decreasing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decreasing));
            this.btndecrease = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.ComboBox();
            this.blood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndecrease
            // 
            this.btndecrease.BackColor = System.Drawing.Color.Red;
            this.btndecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btndecrease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndecrease.Location = new System.Drawing.Point(954, 90);
            this.btndecrease.Name = "btndecrease";
            this.btndecrease.Size = new System.Drawing.Size(142, 58);
            this.btndecrease.TabIndex = 90;
            this.btndecrease.Text = "Decrease";
            this.btndecrease.UseVisualStyleBackColor = false;
            this.btndecrease.Click += new System.EventHandler(this.btndecrease_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 358);
            this.dataGridView1.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(137, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 88;
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
            this.btnClos.Location = new System.Drawing.Point(1051, 570);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(117, 50);
            this.btnClos.TabIndex = 87;
            this.btnClos.Text = "Close";
            this.btnClos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(457, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 39);
            this.label2.TabIndex = 86;
            this.label2.Text = "STOCK (DECREASE)";
            // 
            // units
            // 
            this.units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.units.FormattingEnabled = true;
            this.units.Items.AddRange(new object[] {
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "-7",
            "-8",
            "-9",
            "-10",
            "-11",
            "-12",
            "-13",
            "-14",
            "-15"});
            this.units.Location = new System.Drawing.Point(747, 102);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(144, 33);
            this.units.TabIndex = 85;
            // 
            // blood
            // 
            this.blood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.blood.FormattingEnabled = true;
            this.blood.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "O-",
            "AB-",
            "B-",
            "A-"});
            this.blood.Location = new System.Drawing.Point(431, 105);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(164, 33);
            this.blood.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(650, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 37);
            this.label3.TabIndex = 83;
            this.label3.Text = "Units";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(212, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 49);
            this.label4.TabIndex = 82;
            this.label4.Text = "Blood Group";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Decreasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1342, 677);
            this.Controls.Add(this.btndecrease);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.units);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Decreasing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decreasing";
            this.Load += new System.EventHandler(this.Decreasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndecrease;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox units;
        private System.Windows.Forms.ComboBox blood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}