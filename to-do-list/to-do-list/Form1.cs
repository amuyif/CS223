namespace to_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgv.Rows.Add(txtName.Text, txtAddress.Text, txtDate.Text, txtWork.Text, txtSkills.Text);

        }

 
        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }
    }
}