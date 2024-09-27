using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private void cancel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure , U completed your work??", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor ad = new AddNewDonor();
            ad.Show();
        }
        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails up = new UpdateDonorDetails();
            up.Show();
        }
        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorAddress add = new SearchBloodDonorAddress();
            add.Show();
        }
        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails all = new UpdateDonorDetails();
            all.Show();
        }
        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Increasing increas = new Increasing();
            increas.Show();
        }
        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bloodGroup a = new bloodGroup();
            a.Show();
        }
        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decreasing decreas = new Decreasing();
            decreas.Show();
        }
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails stockdet = new StockDetails();
            stockdet.Show();
        }
        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.Show();
        }
        private void donorsDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails all = new AllDonorDetails();
            all.Show();
        }
    }
}