using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Att_System
{
    public partial class LoginFrm : Form
    {
        public bool loginFlag { get; set; }
        public LoginFrm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(pass_txt.Text, pass_txt.Text);

            if(dt.Rows.Count > 0)
            {

                loginFlag = true;
            }
            else
            {

                loginFlag = false;
            }

            Close();

        
        }
    }
}
