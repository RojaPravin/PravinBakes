using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PravinBakes
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        private string name;

        public string Name1
        { 
            get { return name; } 
            set { name = value; } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbox_biscuits.Visible = false;
            gBox_Chips.Visible = false;
            gBox_Chocolates.Visible = true;
            gBox_Drinks.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Hide&seek";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Biscuits_Click(object sender, EventArgs e)
        {
            gbox_biscuits.Visible = true;
            gBox_Chips.Visible = false;
            gBox_Chocolates.Visible = false;
            gBox_Drinks.Visible = false;
        }

        private void btn_Chips_Click(object sender, EventArgs e)
        {
            gbox_biscuits.Visible = false;
            gBox_Chips.Visible = true;
            gBox_Chocolates.Visible = false;
            gBox_Drinks.Visible = false;
        }

        private void btn_Drinks_Click(object sender, EventArgs e)
        {
            gbox_biscuits.Visible = false;
            gBox_Chips.Visible = false;
            gBox_Chocolates.Visible = false;
            gBox_Drinks.Visible = true;
        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Exit ?", "Confirmation Message", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_ProductName.Clear();
            txt_Cost.Clear();
            cmb_Quantity.ResetText();

        }

        private void btn_Sevenup_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "7Up";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
              
        }

        private void btn_Fanta_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Fanta";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Slice_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Slice";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Bovonto_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Bovonto";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Dairy_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "DairyMilk";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Kitkat_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Kitkat";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_FiveStar_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "FiveStar";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Milky_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Milkybar";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Cheetos_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Cheetos";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Doritos_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Doritos";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Lays_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Lays";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Kurkure_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Kurkure";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_MilkBikis_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Milkbikis";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Fifty_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Fifty50";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void btn_Goodday_Click(object sender, EventArgs e)
        {
            txt_ProductName.Text = "Goodday";
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchCost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txt_Cost.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_ProductId.Text = ds.Tables[0].Rows[0][1].ToString();
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_addbill", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@Billed_by", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_Billedby.Text.Trim();
            SqlParameter p2 = new SqlParameter("@CustomerId", SqlDbType.Int);
            cmd.Parameters.Add(p2).Value = txt_CustomerID.Text.Trim();
            SqlParameter p3 = new SqlParameter("@TotalAmount", SqlDbType.Float);
            cmd.Parameters.Add(p3).Value = txt_Total.Text.Trim();
            SqlParameter p4 = new SqlParameter("@CashorOnline", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = cmb_CashOnline.SelectedItem.ToString();
            
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            MessageBox.Show(i.ToString());

            txt_BillNumber.Text = i.ToString();
            
            foreach (DataGridViewRow dv in dataGridView1.Rows)
            {
                string productName = Convert.ToString(dv.Cells[0].Value);
                int quantity = Convert.ToInt32(Convert.ToString(dv.Cells[1].Value));
                int amount = Convert.ToInt32(Convert.ToString(dv.Cells[2].Value));
                int productId = Convert.ToInt32(Convert.ToString(dv.Cells[3].Value));

                con.Open();

                SqlCommand cmd1 = new SqlCommand("sp_addbillProduct", con);
                cmd1.CommandType = CommandType.StoredProcedure;

                SqlParameter p11 = new SqlParameter("@Billid", SqlDbType.Int);
                cmd1.Parameters.Add(p11).Value = txt_BillNumber.Text;
                SqlParameter p12 = new SqlParameter("@ProductId", SqlDbType.Int);
                cmd1.Parameters.Add(p12).Value = productId.ToString();
                SqlParameter p13 = new SqlParameter("@Quantity", SqlDbType.Int);
                cmd1.Parameters.Add(p13).Value = quantity.ToString();
                SqlParameter p14 = new SqlParameter("@Amount", SqlDbType.Float);
                cmd1.Parameters.Add(p14).Value = amount.ToString();

                int i1 = cmd1.ExecuteNonQuery();
                if (i1 > 0)
                {
                    MessageBox.Show("The Product is added in the bill");

                }
                else
                { 
                    MessageBox.Show("Failure !!!"); 
                }
                con.Close();    

            }
        }

        private void cmb_CashOnline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            string productName = txt_ProductName.Text.Trim();
            int quantity = Convert.ToInt32(cmb_Quantity.SelectedItem.ToString());
            int cost = Convert.ToInt32(txt_Cost.Text.Trim());
            int finalCost = cost * quantity;
            int productId = Convert.ToInt32(txt_ProductId.Text.Trim());
 
            dataGridView1.Rows.Add(productName, quantity,  finalCost, productId);
            int totalAmount = 0;
            foreach (DataGridViewRow dv in dataGridView1.Rows)
            {
                try
                {
                    MessageBox.Show("Entered");
                    totalAmount = totalAmount + Convert.ToInt32(Convert.ToString(dv.Cells[2].Value));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(totalAmount.ToString());

                }
                txt_Amount.Text = totalAmount.ToString();
                txt_Gst.Text = ((totalAmount * 18)/100).ToString();
                txt_Total.Text = (totalAmount + (totalAmount * 18) / 100).ToString();
            }
        }

        private void txt_Billedby_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            txt_Billedby.Text = Name1;
        }

        private void txt_BillNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CusId_Click(object sender, EventArgs e)
        {
            try
            {
                string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(pravin);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fetch_CustomerId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                

                SqlParameter p1 = new SqlParameter("@Mobile_Number", SqlDbType.VarChar);
                
                cmd.Parameters.Add(p1).Value = txt_MbNo.Text;
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txt_CustomerID.Text = ds.Tables[0].Rows[0][0].ToString();
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mobile number is invalid or No Customer,pls add the customer details");
                txt_CustomerID.Clear();
            }
        }
    }
}
