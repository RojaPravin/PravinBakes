using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace PravinBakes
{
    
    public partial class AddProducts : Form

    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void lbl_ProductName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CategoryName_Click(object sender, EventArgs e)
        {

        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Exit ?", "Confirmation Message", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Exclamation);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(pravin);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addproducts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@Product_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_ProductName.Text.Trim();
                SqlParameter p2 = new SqlParameter("@Category_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = txt_CategoryName.Text.Trim();
                SqlParameter p3 = new SqlParameter("@Cost", SqlDbType.Float);
                cmd.Parameters.Add(p3).Value = txt_Cost.Text.Trim();
                SqlParameter p4 = new SqlParameter("@Quantity", SqlDbType.Int);
                cmd.Parameters.Add(p4).Value = txt_Quantity.Text.Trim();
                SqlParameter p5 = new SqlParameter("@ExpiryDate", SqlDbType.DateTime);
                cmd.Parameters.Add(p5).Value = dateTimePicker1.Value.ToString();
                SqlParameter p6 = new SqlParameter("@ProductImage", SqlDbType.VarChar);
                cmd.Parameters.Add(p6).Value = "Images/" + txt_ProductName.Text + ".png";

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Image img = new Bitmap(txt_ProductImage.Text);
                    img.Save("Images/" + txt_ProductName.Text + ".png", ImageFormat.Png);
                    MessageBox.Show("Added Successfully");
                    txt_ProductName.Clear();
                    txt_CategoryName.Clear();
                    txt_Cost.Clear();
                    txt_Quantity.Clear();
                    dateTimePicker1.ResetText();

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

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "(*.jpg ; *.jpeg ; *.png ) | *.jpg ; *.jpeg ; *.png |All Files(*.*)|*.*";
            o.ShowDialog();
            txt_ProductImage.Text = o.FileName;
            pictureBox1.Image = Image.FromFile(o.FileName);



        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
