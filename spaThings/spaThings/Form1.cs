using System.Data;
using System.Data.SqlClient;
using static spaThings.authenticate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace spaThings
{
    public partial class Form1 : Form
    {
        private User authenticatedUser;
        public Form1(User user)
        {
            InitializeComponent();
            authenticatedUser = user; // Assign the authenticated user to the local variable

            // Additional initialization or actions based on the authenticated user can be added here
            // For example, you can set labels or perform other operations.
            label1.Text = $"Welcome, {authenticatedUser.Username}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC08\SQLEXPRESS; Initial Catalog=spaThings; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room typ

                string query1 = "select * from spaStuff where 1 = 1";
                List<string> conditions = new List<string>(); //empty at this moment

                if (activityCm.SelectedItem != null)
                {
                    conditions.Add("activity = @ac");
                }

                if (timeSlot.SelectedItem != null)
                {
                    conditions.Add("timeSlot = @ts");
                }
                if (employee.SelectedItem != null)
                {
                    conditions.Add("employee = @em");
                }

                if (conditions.Count > 0)
                {
                    query1 += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                if (activityCm.SelectedItem != null) { cmd.Parameters.AddWithValue("@ac", activityCm.SelectedItem.ToString()); }

                if (timeSlot.SelectedItem != null) { cmd.Parameters.AddWithValue("@ts", timeSlot.SelectedItem.ToString()); }
                if (employee.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@em", employee.SelectedItem.ToString());
                }

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;

                }
            }
        }

        private void activityPreference_Click(object sender, EventArgs e)
        {
            using (activityPreferencePage userInputForm = new activityPreferencePage())
            {
                userInputForm.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(0)) //name of the activity
                {
                    SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC08\SQLEXPRESS; Initial Catalog=spaThings; Integrated Security=True;");
                    sqlCon.Open();
                    string query = "select count(1) from spaStuff where activity = @activity";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@activity", activityCm.SelectedItem.ToString());
                        string activity;
                        //initialize here

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                             
                            if (activityCm.SelectedItem != null)
                                activity = reader["activity"].ToString();

                            //same with others

                            //we read everything here

                        }

                        string queryInsert = "insert into Activity INNER JOIN spaStuff on Activity.activity = spaStuff.activity () VALUES ()";
                        SqlCommand insertCmd = new SqlCommand(queryInsert, sqlCon);

                        //insert query in the other table


                    }
                }
            }
        }
    }
}