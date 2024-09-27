using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BloodBank
{
    
    public partial class Decreasing : Form
    {
        function fn = new function();
        String query;
        public Decreasing()
        {
            InitializeComponent();
        }

        private void btnClos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Decreasing_Load(object sender, EventArgs e)
        {
            query = " select blood_group, quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btndecrease_Click(object sender, EventArgs e)
        {
            if(units.Text != "" && blood.Text != "")
            {
                query = "update stock set quantity = quantity" + units.Text + " where blood_group = '" + blood.Text + "'";
                fn.setDate(query);
                Decreasing_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please fill Both !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
