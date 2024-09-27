using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace BloodBank
{
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        String query;
        public UpdateDonorDetails()
        {
            InitializeComponent();
            email.TextChanged += email_TextChanged;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DonorID.Text != "")
            {
                // Construct the query to select donor details based on ID
                query = "select * from ndon where id = " + DonorID.Text;

                // Get the dataset containing the donor details
                DataSet ds = fn.getData(query);

                // Check if any records are found
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Display the details in the text boxes
                    DataRow row = ds.Tables[0].Rows[0];
                    txtName.Text = row["name"].ToString();
                    gender.Text = row["gender"].ToString();
                    txtweight.Text = row["weight"].ToString();
                    dob.Text = row["dob"].ToString();
                    mobile.Text = row["mobile"].ToString();
                    gno.Text = row["gaurdian_no"].ToString();
                    email.Text = row["email"].ToString();
                    bg.Text = row["blood_group"].ToString();
                    cty.Text = row["city"].ToString();
                    ad.Text = row["address"].ToString();
                }
                else
                {
                    // Display a message if no record is found
                    MessageBox.Show("No Record Found for the provided Donor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display a message if Donor ID is not provided
                MessageBox.Show("Please enter Donor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DonorID_TextChanged(object sender, EventArgs e)
        {
            if (DonorID.Text == "")
            {
                txtName.Clear();
                gender.SelectedIndex = -1;
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
        private void save_Click_1(object sender, EventArgs e)
        {
            if (mobile.ForeColor == Color.Red)
            {
                MessageBox.Show("Please enter a valid 10-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (email.ForeColor == Color.Red)
            {
                MessageBox.Show("Please enter a valid Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gno.ForeColor == Color.Red)
            {
                MessageBox.Show("Please enter a valid 10-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String query = "insert into ndon (name, gender, weight, dob, mobile, gaurdian_no, email, bloodgroup, city, address) values ('" + txtName.Text + "', '" + gender.Text + "', '" + txtweight.Text + "','" + dob.Text + "', " + mobile.Text + ", '" + gno.Text + "','" + email.Text + "', '" + bg.Text + "','" + cty.Text + "', '" + ad.Text + "'where id =" + DonorID.Text + ")";
            MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DonorID.Clear();
            txtName.Clear();
            gender.SelectedIndex = -1;
            bg.SelectedIndex = -1;
            txtweight.Clear();
            dob.Value = DateTime.Today;
            mobile.Clear();
            gno.Clear();
            email.Clear();
            cty.Clear();
            ad.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            gender.SelectedIndex = -1;
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

        private void mobile_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string number = textBox.Text;

            if (number.Length == 10 && IsNumeric(number))
            {
                textBox.ForeColor = Color.Black;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }
        }
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void gno_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (text.Length == 10 && IsNumer(text))
            {
                textBox.ForeColor = Color.Black;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }
        }
        private bool IsNumer(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text;
            string pattern = @"@gmail\.com$";
            if (Regex.IsMatch(email, pattern))
            {
                textBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBox.ForeColor = System.Drawing.Color.Red;
            }
        }
    }    
}
