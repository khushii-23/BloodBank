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
    public partial class delete : Form
    {
        function fn = new function();
        String query;
        public delete()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DonorID.Text != "")
            {
                query = "select * from ndon where id =" + DonorID.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtgender.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtweight.Text = ds.Tables[0].Rows[0][3].ToString();
                    dob.Text = ds.Tables[0].Rows[0][4].ToString();
                    mobile.Text = ds.Tables[0].Rows[0][5].ToString();
                    gno.Text = ds.Tables[0].Rows[0][6].ToString();
                    email.Text = ds.Tables[0].Rows[0][7].ToString();
                    bg.Text = ds.Tables[0].Rows[0][8].ToString();
                    cty.Text = ds.Tables[0].Rows[0][9].ToString();
                    ad.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DonorID.Clear();
                }
            }
        }

        private void DonorID_TextChanged(object sender, EventArgs e)
        {
            if (DonorID.Text != "")
            {
                txtName.Clear();
                txtgender.SelectedIndex = -1;
                bg.SelectedIndex = -1;
                txtweight.Clear();
                dob.Value = DateTime.Today;
                mobile.Clear();
                gno.Clear();
                email.Clear();
                cty.Clear();
                ad.Clear();
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (DonorID.Text != "")
            {
                if (MessageBox.Show("Are You Sure??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from ndon where id = " + DonorID.Text + "";
                    fn.setDate(query);
                    DonorID.Clear();
                    txtName.Clear();
                    txtgender.SelectedIndex = -1;
                    bg.SelectedIndex = -1;
                    txtweight.Clear();
                    dob.Value = DateTime.Today;
                    mobile.Clear();
                    gno.Clear();
                    email.Clear();
                    cty.Clear();
                    ad.Clear();
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            DonorID.Clear();
            txtName.Clear();
            txtgender.SelectedIndex = -1;
            bg.SelectedIndex = -1;
            txtweight.Clear();
            dob.Value = DateTime.Today;
            mobile.Clear();
            gno.Clear();
            email.Clear();
            cty.Clear();
            ad.Clear();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}