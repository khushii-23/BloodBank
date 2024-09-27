using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                btnPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                btnPassword.PasswordChar = '*';
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnUsername.Text) && !string.IsNullOrEmpty(btnPassword.Text))
            {
                Int64 Identity;
                if (Int64.TryParse(btnUsername.Text, out Identity))
                {
                    query = "select * from signup where id = " + Identity + " and pass = '" + btnPassword.Text + "'";
                    DataSet ds = fn.getData(query);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dashboard db = new dashboard();
                        db.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dashboard a = new dashboard();
            a.Show();
        }
        private void btnClos_Click_1(object sender, EventArgs e)
        {
            signup log = new signup();
            log.Show();
        }
    }
    
}