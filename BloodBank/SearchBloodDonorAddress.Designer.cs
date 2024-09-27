namespace BloodBank
{
    partial class SearchBloodDonorAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBloodDonorAddress));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClos = new System.Windows.Forms.Button();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.ndonorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodbankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodbankDataSet = new BloodBank.bloodbankDataSet();
            this.ndonorTableAdapter = new BloodBank.bloodbankDataSetTableAdapters.ndonorTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndonorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH BLOOD DONOR (ADDRESS)";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(365, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addres
            // 
            this.addres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addres.Location = new System.Drawing.Point(545, 103);
            this.addres.Name = "addres";
            this.addres.ShortcutsEnabled = false;
            this.addres.Size = new System.Drawing.Size(306, 34);
            this.addres.TabIndex = 5;
            this.addres.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(183, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 55;
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
            this.btnClos.Location = new System.Drawing.Point(1099, 569);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(117, 50);
            this.btnClos.TabIndex = 54;
            this.btnClos.Text = "Close";
            this.btnClos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // dataGridView11
            // 
            this.dataGridView11.AllowUserToAddRows = false;
            this.dataGridView11.AllowUserToDeleteRows = false;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(12, 173);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.ReadOnly = true;
            this.dataGridView11.RowHeadersWidth = 51;
            this.dataGridView11.RowTemplate.Height = 24;
            this.dataGridView11.Size = new System.Drawing.Size(1306, 346);
            this.dataGridView11.TabIndex = 56;
            // 
            // ndonorBindingSource
            // 
            this.ndonorBindingSource.DataMember = "ndonor";
            this.ndonorBindingSource.DataSource = this.bloodbankDataSetBindingSource;
            // 
            // bloodbankDataSetBindingSource
            // 
            this.bloodbankDataSetBindingSource.DataSource = this.bloodbankDataSet;
            this.bloodbankDataSetBindingSource.Position = 0;
            // 
            // bloodbankDataSet
            // 
            this.bloodbankDataSet.DataSetName = "bloodbankDataSet";
            this.bloodbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ndonorTableAdapter
            // 
            this.ndonorTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SearchBloodDonorAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1342, 677);
            this.Controls.Add(this.dataGridView11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.addres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchBloodDonorAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBloodDonorAddress";
            this.Load += new System.EventHandler(this.SearchBloodDonorAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndonorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.BindingSource bloodbankDataSetBindingSource;
        private bloodbankDataSet bloodbankDataSet;
        private System.Windows.Forms.BindingSource ndonorBindingSource;
        private bloodbankDataSetTableAdapters.ndonorTableAdapter ndonorTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}