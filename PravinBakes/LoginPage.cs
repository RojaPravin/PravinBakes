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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Uname_Click(object sender, EventArgs e)
        {

        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout ?","Confirmation Message",MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }

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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(pravin);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LoginUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string key = "b14ca5898a4e4133bbce2ea2315a1916";

                SqlParameter p1 = new SqlParameter("@UserName", SqlDbType.VarChar);
                string EncrypUname = EncryptString(key, txt_Uname.Text);
                cmd.Parameters.Add(p1).Value = EncrypUname;
                SqlParameter p2 = new SqlParameter("@Password", SqlDbType.VarChar);
                string EncrypPwd = EncryptString(key, txt_Pwd.Text);
                cmd.Parameters.Add(p2).Value = EncrypPwd;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string a = ds.Tables[0].Rows[0][0].ToString();
                //MessageBox.Show("Welcome " + a);
                string decrypUname = DecryptString(key,a);
                MessageBox.Show("Welcome "+  decrypUname);
                if(a != "" )
                {
                    MessageBox.Show("Valid User");
                    Billing b = new Billing();
                    b.Name1 = txt_Uname.Text;
                    b.Show();
                    this.Hide();   

                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
