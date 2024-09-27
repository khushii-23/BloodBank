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

namespace BloodBank
{
    public partial class SearchBloodDonorAddress : Form
    {
        function fn = new function();
        public SearchBloodDonorAddress()
        {
            InitializeComponent();
        }
        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SearchBloodDonorAddress_Load(object sender, EventArgs e)
        {
            String query = "Select * from ndon";
            DataSet ds = fn.getData(query);
            dataGridView11.DataSource = ds.Tables[0];          
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            if (addres.Text != "")
            {
                String query = "select * from ndon where city Like '" + addres.Text + "%' or address Like '" + addres.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView11.DataSource = ds.Tables[0];
            }
            else
            {
                String query = "select * from ndon";
                DataSet ds = fn.getData(query);
                dataGridView11.DataSource= ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView11.Width, this.dataGridView11.Height);
            dataGridView11.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView11.Width, this.dataGridView11.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
    

