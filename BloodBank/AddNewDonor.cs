using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace BloodBank
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        String query;
        public AddNewDonor()
        {
            InitializeComponent();
            email.TextChanged += email_TextChanged;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        } 
        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(id) from ndon";
            DataSet ds = fn.getData(query);

            int count = 0;

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int.TryParse(ds.Tables[0].Rows[0][0].ToString(), out count);
            }

            newid.Text = (count + 1).ToString();
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
        private void save_Click(object sender, EventArgs e)
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
            if (txtName.Text != "" && gender.Text != "" && txtweight.Text != "" && dob.Text != "" && mobile.Text != "" && gno.Text != "" && email.Text != "" && bg.Text != "" && cty.Text != "" && ad.Text != "")
            {
                String donorname = txtName.Text;
                String donorgender = gender.Text;
                String donorweight = txtweight.Text;
                String donordob = dob.Text;
                Int64 donornumber = Int64.Parse(mobile.Text);
                Int64 gaurdianno = Int64.Parse(gno.Text);
                String donormail = email.Text;
                String bgroup = bg.Text;
                String city = cty.Text;
                String address = ad.Text;
                String query = "insert into ndon (name, gender, weight, dob, mobile, gaurdian_no, email, blood_group, city, address) values ('" + donorname + "', '" + donorgender + "', '" + donorweight + "','" + donordob + "', " + donornumber + ", '" + gaurdianno + "','" + donormail + "', '" + bgroup + "','" + city + "', '" + address + "')";
                fn.setDate(query);
                MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK);
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
            else
            {
                MessageBox.Show("Fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
        private void dob_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}