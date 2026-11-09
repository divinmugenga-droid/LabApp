namespace LabApp
{
    public partial class FormMushroom : Form
    {
        private FormChoose choose;
        private bool loggingOut = false;

        // which question is currently asked
        // 0 = ring, 1 = forest, 2 = convex cup (meadow), 3 = gills, 4 = convex cup (no ring)
        private int question = 0;

        public FormMushroom(FormChoose chooseForm)
        {
            InitializeComponent();
            choose = chooseForm;
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (question == 0)
            {
                labelquestion.Text = "Does your mushroom have a ring?";
            }
            else if (question == 1)
            {
                labelquestion.Text = "Does your mushroom grow in a forest?";
            }
            else if (question == 3)
            {
                labelquestion.Text = "Does your mushroom have gills?";
            }
            else
            {
                labelquestion.Text = "Does your mushroom have a convex cup?";
            }
        }

        private void ShowResult(string mushroom)
        {
            MessageBox.Show("Your mushroom is: " + mushroom);
            question = 0;          // start again
            ShowQuestion();
        }

        private void Answer(bool yes)
        {
            if (question == 0)                 // ring ?
            {
                if (yes)
                {
                    question = 1;              // Agaric, Amanite or Coprin
                }
                else
                {
                    question = 3;              // Cepe, Girolle or Pied bleu
                }
                ShowQuestion();
            }
            else if (question == 1)            // forest ? (has a ring)
            {
                if (yes)
                {
                    ShowResult("Amanite tue-mouche");
                }
                else
                {
                    question = 2;              // Agaric or Coprin
                    ShowQuestion();
                }
            }
            else if (question == 2)            // convex cup ? (ring, meadow)
            {
                if (yes)
                {
                    ShowResult("Agaric jaunissant");
                }
                else
                {
                    ShowResult("Coprin chevelu");
                }
            }
            else if (question == 3)            // gills ? (no ring)
            {
                if (yes)
                {
                    question = 4;              // Girolle or Pied bleu
                    ShowQuestion();
                }
                else
                {
                    ShowResult("Cepe de bordeaux");
                }
            }
            else                               // convex cup ? (no ring, gills)
            {
                if (yes)
                {
                    ShowResult("Pied bleu");
                }
                else
                {
                    ShowResult("Girolle");
                }
            }
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            Answer(true);
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Answer(false);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            loggingOut = true;
            choose.Logout();
            this.Close();
        }

        private void FormMushroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggingOut)
            {
                Application.Exit();
            }
        }
    }
}
