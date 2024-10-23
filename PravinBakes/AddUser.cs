using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PravinBakes
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(pravin);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddUser1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string key = "b14ca5898a4e4133bbce2ea2315a1916";
                SqlParameter p1 = new SqlParameter("@Emp_Id", SqlDbType.Int);
                cmd.Parameters.Add(p1).Value = txt_EmpId.Text.Trim();
                SqlParameter p2 = new SqlParameter("@UserName", SqlDbType.VarChar);
                string EncrypUname = EncryptString(key, txt_UserName.Text);
                cmd.Parameters.Add(p2).Value = EncrypUname;
                SqlParameter p3 = new SqlParameter("@Password", SqlDbType.VarChar);
                string EncrypPwd = EncryptString(key, txt_Pwd.Text);
                cmd.Parameters.Add(p3).Value = EncrypPwd;
                SqlParameter p4 = new SqlParameter("@MobileNumber", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = txt_Mbno.Text.Trim();
                SqlParameter p5 = new SqlParameter("@DOB", SqlDbType.DateTime);
                cmd.Parameters.Add(p5).Value = dateTimePicker1.Value.ToString();
                
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                   
                    MessageBox.Show("Added Successfully");
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
            DialogResult check = MessageBox.Show("Are you sure you want to Exit ?", "Confirmation Message", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
