using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalcalEnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source =RAYSOFT; Initial Catalog = Sharpner; Persist Security Info=True;User ID = sa; Password=RaySmartSoft");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {


                Con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO MBills (Payments) VALUES(@Payments)", Con);


                cmd.Parameters.AddWithValue("@Payments", gunaTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment SuccessFully Added");
                gunaTextBox1.Clear();


            }

            catch
            {

                // MessageBox.Show(ex.Message, "Alert");

                MessageBox.Show("User Adding Failed! Add Valid Inputs", "Failed");

            }

            finally
            {
                Con.Close();
                

            }
        }
    }
}
