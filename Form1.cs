namespace LabApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = textusername.Text;
            string password = textpassword.Text;
            if ((user != "") && (password != ""))
            {
                FormChoose choose = new FormChoose(this);
                choose.Show();
                this.Hide();
                textusername.Text = "";
                textpassword.Text = "";
            }
            else
            {
                MessageBox.Show("Username and Password can not be empty");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
