namespace LabApp
{
    public partial class FormBicycle : Form
    {
        private FormChoose choose;
        private bool loggingOut = false;

        public FormBicycle(FormChoose chooseForm)
        {
            InitializeComponent();
            choose = chooseForm;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int start;
            int end;

            // int.TryParse also rejects decimal numbers
            if (!int.TryParse(textstart.Text, out start) || !int.TryParse(textend.Text, out end))
            {
                MessageBox.Show("Please enter whole numbers only (no decimals).");
                return;
            }

            if (start < 0 || start > 23)
            {
                MessageBox.Show("Start time must be between 0 and 23.");
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("End time must be between 1 and 24.");
                return;
            }

            if (start >= end)
            {
                MessageBox.Show("Start time must be less than end time.");
                return;
            }

            int total = 0;

            // add the price of every rented hour
            for (int hour = start; hour < end; hour++)
            {
                int rate;

                if (hour < 7)
                {
                    rate = 500;       // 0 - 7
                }
                else if (hour < 14)
                {
                    rate = 1000;      // 7 - 14
                }
                else if (hour < 19)
                {
                    rate = 1500;      // 14 - 19
                }
                else if (hour < 21)
                {
                    rate = 1000;      // 19 - 21
                }
                else
                {
                    rate = 500;       // 21 - 24
                }

                total = total + rate;
            }

            texttotal.Text = total + " RWF";
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            loggingOut = true;
            choose.Logout();
            this.Close();
        }

        private void FormBicycle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggingOut)
            {
                Application.Exit();
            }
        }
    }
}
