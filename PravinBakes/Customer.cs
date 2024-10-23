using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PravinBakes
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            try
            {
                string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(pravin);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addCustomers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@Cust_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_CusName.Text.Trim();
                SqlParameter p2 = new SqlParameter("@Mobile_Number", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = txt_MbNo.Text.Trim();
                SqlParameter p3 = new SqlParameter("@Address", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = txt_Address.Text.Trim();
                

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                   
                    MessageBox.Show("Added Successfully");
                    txt_CusName.Clear();
                    txt_MbNo.Clear();
                    txt_Address.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Failed !!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
