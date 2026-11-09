namespace LabApp
{
    public partial class FormChoose : Form
    {
        private Form1 login;
        private bool loggingOut = false;

        public FormChoose(Form1 loginForm)
        {
            InitializeComponent();
            login = loginForm;
        }

        // Called by the Bicycle / Mushroom forms when the user logs out
        public void Logout()
        {
            loggingOut = true;
            login.Show();
            this.Close();
        }

        private void btnbicycle_Click(object sender, EventArgs e)
        {
            FormBicycle bicycle = new FormBicycle(this);
            bicycle.Show();
            this.Hide();
        }

        private void btnmushroom_Click(object sender, EventArgs e)
        {
            FormMushroom mushroom = new FormMushroom(this);
            mushroom.Show();
            this.Hide();
        }

        private void FormChoose_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggingOut)
            {
                Application.Exit();
            }
        }
    }
}
