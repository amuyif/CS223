namespace Att_System
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginFrm newLogin = new LoginFrm();
            newLogin.ShowDialog();

            if (newLogin.loginFlag == false)
            {
                Close();
            }
        }
    }
}