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
using Microsoft.VisualBasic.ApplicationServices;
using spaThings;

namespace spaThings
{
    public partial class Form4 : Form
    {
        User user = new User();
        public Form4()
        {
            InitializeComponent();

        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 info = new Form5();
            info.ShowDialog();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC08\SQLEXPRESS; Initial Catalog=spaThings; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query1 = "select * from Activity where name = @name";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);
                cmd.Parameters.AddWithValue("@name", comboBox1.Text);


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;

                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC08\SQLEXPRESS; Initial Catalog=spaThings; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string delete = "DELETE FROM Activity WHERE name=@name";
                SqlCommand cmd = new SqlCommand(delete, sqlCon);
                cmd.Parameters.AddWithValue("@name", comboBox1.Text);


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;

                }
            }
        }
    }
}
