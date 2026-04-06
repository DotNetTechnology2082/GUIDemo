namespace GUIDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "" && password == "")
            {
                MessageBox.Show("Please Enter username and password");
            }
            if (username == "admin" & password == "12345")
            {
                MessageBox.Show("Login Successful!");

                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();

                this.Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
