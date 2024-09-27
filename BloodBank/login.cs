using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class signup : Form
    {
        function fn = new function();
        String query;
        public signup()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btn1.Text == "Show")
            {
                btn1.Text = "Hide";
                pass.PasswordChar = '\0';
            }
            else
            {
                btn1.Text = "Show";
                pass.PasswordChar = '*';
            }
        }
        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                cpass.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                cpass.PasswordChar = '*';
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {
        //btnSignup.Enabled = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (btnUsername.Text != "" && uid.Text != "" && loc.Text != "" && bnk.Text != "" && pass.Text != "" && cpass.Text != "")
            {
                if (pass.Text == cpass.Text)
                {
                    Int64 userid = Int64.Parse(uid.Text);
                    String uname = btnUsername.Text;
                    String locat = loc.Text;
                    String blood_bank = bnk.Text;
                    String pwd = pass.Text;
                    query = "insert into signup (id, name, location, bank, pass) values (' " + userid + " ' , '" + uname + " ', '" + locat + " ', '" + blood_bank + " ', '" + pwd + "')";
                    fn.setDate(query);
                    MessageBox.Show("Sign Up Successful. Now you can Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match from each other!");
                }
            }
            else
            {
                MessageBox.Show("Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
