using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Increasing : Form
    {
        function fn = new function();
        String query;
        public Increasing()
        {
            InitializeComponent();
        }
        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Increasing_Load(object sender, EventArgs e)
        {
            query = "select blood_group, quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
           if (units.Text != "" && bloodgroup.Text != "")
            {
                query = "update stock set quantity = quantity + " + units.Text + " where blood_group = '" + bloodgroup.Text + "'";
                fn.setDate(query);
                Increasing_Load(this, null);
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
