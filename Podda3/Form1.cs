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

namespace Podda3
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DateTime DaNow = DateTime.Today; //new DateTime(2024,03,19);  
            DateTime LaDate = new DateTime(2024, 09, 01);
            TimeSpan ToEnd = LaDate - DaNow;
            int TotDays = (int)ToEnd.TotalDays;
            Daylbl.Text = TotDays.ToString();


            if (TotDays < 0)
            {

                int ZAmount = 0;
                DAmount.Text = ZAmount.ToString();
            }
        }


        public int Rem2 { get; set; }

        public void Months()
        {
            DateTime DaNow2 = DateTime.Today;
            DateTime Coursend = new DateTime(2024, 09, 01);
            TimeSpan Remo = Coursend - DaNow2;
            double Remonths = (double)Remo.Days / 30;
            double RoundRem = Math.Round(Remonths, 2);
            Rem2 = (int)Remo.Days;


            MoLabel.Text = RoundRem.ToString();
            MoLabel.ForeColor = Color.Blue;
           
        }



        SqlConnection Con = new SqlConnection(@"Data Source =.; Initial Catalog = Sharpner; Persist Security Info=True;User ID = sa; Password=RaySmartSoft");


        public void Gaana()
        {

            //SELECT 7000 - SUM(Payments) FROM MBills
            string query = "sp_ReducePay;";
            SqlCommand cmd = new SqlCommand(query, Con);
            try
            {
                Con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dtc = new DataTable();
                if (rdr.Read())
                {

                    int TAmount = rdr.GetInt32(0);
                    DAmount.Text = TAmount.ToString();
                    ifMinus();

                }


            }

            catch
            {


            }

            finally
            {
                Con.Close();
                Application.DoEvents();


            }


        }




        public void ifMinus()
        {
            //SELECT SUM(Amount) + sum(Profits) - sum(Payments) FROM MBills
            string query = "sp_IfMinus;";
            SqlCommand cmd = new SqlCommand(query, Con);
            try
            {
                Con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dtc = new DataTable();
                if (rdr.Read())
                {

                    int AfterProf = rdr.GetInt32(0);
                    podilabel1.Text = AfterProf.ToString();

                    Movetext();
                }

            }


            finally
            {
                Con.Close();
            }

        }



        public void Movetext()
        {


            int Lokuvalue = int.Parse(DAmount.Text);

            if (Lokuvalue < 0)
            {



                DAmount.Text = podilabel1.Text;
                podilabel1.Text = Lokuvalue.ToString();
                podilabel1.ForeColor = Color.Red;
                int Movevalue = int.Parse(DAmount.Text);
                Application.DoEvents();



            }


        }


        public void Monthlydatsp()
        {
                int checkdate = int.Parse(Daylbl.Text);
            string query = "sp_Monthlymove;";
                SqlCommand cmd = new SqlCommand(query, Con);

            try
            {
                if (checkdate < 0)
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                }
            } 




            catch (Exception ex)
            {
                
                     MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                
                Con.Close();
            }

        }
    


        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Daylbl_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Addbtn_Click(object sender, EventArgs e)
        {


          

        }
   


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            Gaana();
            ifMinus();
            Movetext();
            Months();
            Application.DoEvents();
            Monthlydatsp();

        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Con.Open();

                SqlCommand cmd = new SqlCommand("sp_Addpay", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (!string.IsNullOrEmpty(textBox1.Text))
                {

                    if (textBox1.Text != "0")
                    {
                        cmd.Parameters.AddWithValue("@Payments", textBox1.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment Added Succesfully!");
                    }
                    else
                    {
                        MessageBox.Show("Payment Failed 0 nam baha");
                    }
                }

                else
                {
                    MessageBox.Show("Payment Failed Empty nam baha");

                }

            }


            //My previous code without entering procedure the direct insert into command
            /*  Con.Open();

             SqlCommand cmd = new SqlCommand("INSERT INTO MBills (Payments) VALUES(@Payments)", Con);
              cmd.Parameters.AddWithValue("@Payments", textBox1.Text);
              cmd.ExecuteNonQuery();
              MessageBox.Show("Payment SuccessFully Added");
              textBox1.Clear();
              Movetext();


          }*/
         
           catch
            {

                // MessageBox.Show(ex.Message, "Alert");

               // MessageBox.Show("User Adding Failed! Add Valid Inputs", "Failed");
                
            }

            finally
            {
                Con.Close();
                Gaana();
                Refresh();
                Movetext();
                textBox1.Clear();
                Movetext();

            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void podilabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

     

        public void Day_Click(object sender, EventArgs e)
        {

            MoLabel.Text = Rem2.ToString();
         

        }

    }
}