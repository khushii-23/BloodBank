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
    public partial class AllDonorDetails : Form
    {
        public AllDonorDetails()
        {
            InitializeComponent();
        }
        string ConnectionString = "Data Source=HARI\\SQLEXPRESS;database = bloodbank; Integrated Security=True";
        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private DataTable tb()
        {
            string query = "select * from ndon";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        private void AllDonorDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodbankDataSet1.ndon' table. You can move, or remove it, as needed.
            this.ndonTableAdapter.Fill(this.bloodbankDataSet1.ndon);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
    }

