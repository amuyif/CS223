using System.Data.SqlClient;

namespace to_do_list_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parts = textBox1.Text.Split(',');
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(parts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count - 1; i++)
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Sales;Integrated Security=true");
                SqlCommand cmd = new SqlCommand("Insert Into Table_1(task,ischecked,name1)Values(@task,@ischecked,@name1)", conn);
                cmd.Parameters.AddWithValue("task", checkedListBox1.Items[i]);
                cmd.Parameters.AddWithValue("ischecked", checkedListBox1.GetItemCheckState(i));
                cmd.Parameters.AddWithValue("name1", textBox2.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data inserted Successfully");



            }
        }
    }
}