namespace DrugsScedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar = false)
            {
                password.UseSystemPasswordChar = true;
            }
            if (password.UseSystemPasswordChar = true)
            {
                password.UseSystemPasswordChar = false;
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            string Login = login.Text;
            string Password = password.Text;
            MessageBox.Show("Succes");
        }

        public void autorisation_Click(object sender, EventArgs e)
        {

        }
    }
}
