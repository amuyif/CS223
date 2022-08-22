using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Class_Exercise
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void addnewproductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opened = this.ActiveMdiChild;
            if (opened != null)
            {
                opened.Close();
            }
                login screen = new login();
                screen.MdiParent = this;
                screen.Show();
            

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 scren = new Form1();
            scren.MdiParent = this;
            scren.Show();
        }
    }
}
