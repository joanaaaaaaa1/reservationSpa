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

namespace spaThings
{
    public partial class activityPreferencePage : Form
    {
        public activityPreferencePage()
        {
            InitializeComponent();
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC08\SQLEXPRESS; Initial Catalog=spaThings; Integrated Security=True;"))
            {
                sqlCon.Open();
                string insertQuery = "INSERT INTO Activity VALUES (@dr, @pr, @ac, @name)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                // Set parameters based on selected values
                insertCmd.Parameters.AddWithValue("@dr", duration.Text);
                insertCmd.Parameters.AddWithValue("@pr", preferences.Text);
                insertCmd.Parameters.AddWithValue("@ac", activity.Text);
                insertCmd.Parameters.AddWithValue("@name", name.Text);

                insertCmd.ExecuteNonQuery();

                Form4 booked = new Form4();
                booked.ShowDialog();
                this.Hide();

            }
        }
    }
}
