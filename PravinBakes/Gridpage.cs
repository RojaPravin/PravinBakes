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
    public partial class Gridpage : Form
    {
        public Gridpage()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string pravin = ConfigurationManager.ConnectionStrings["pbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(pravin);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tempFetchImage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                Image img;
                img = Image.FromFile(dr[1].ToString());
                dataGridView1.Rows.Add(dr[0].ToString(), img);
            }

        }
    }
}
