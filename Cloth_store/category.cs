using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cloth_store
{
    public partial class category : Form
    {
        string constr = @"Data Source=.RAHUL\SQLEXPRESS;Initial Catalog=cloth;Integrated Security=True";
        SqlConnection con;
        public category()
        {
            InitializeComponent();
            con = new SqlConnection(constr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[category name]
           ([category_name])
     VALUES
           ('"+ txtcatnm.Text +"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully inserted!");
            con.Close();
        }

        private void category_Load_1(object sender, EventArgs e)
        {

        }
    }
}
