using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class SanrioGUI : Form
    {
        int number1;
        public SanrioGUI()
        {
            InitializeComponent();
        }

        private void PushMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Correct!");
        }

        private void PushMe_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong Answer!");
        }

        private void PushMe_Click3(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong Answer!");
        }

        private void CheckInt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(NumBox.Text, out number1))
            {
                if (number1 == 1974)
                {
                    MessageBox.Show(NumBox.Text, "Yes, that's correct! The year is 1974!");
                }
                else
                {
                    MessageBox.Show("Nope, that is the WRONG year, Try Again!");
                    NumBox.Clear();
                }

            } // end outer if
            else
            {
                NumBox.Clear();
                MessageBox.Show("Not a valid integer");
            } // end else
        }

        private void Check1(object sender, EventArgs e)
        {
            MessageBox.Show("Nope wrong answer, Try Again!");
            checkBox1.Checked = false; // clears the box 
        }

        private void Check2(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, that's CORRECT!");
            checkBox2.Checked = true; // Leave it checked
        }

        private void Check3(object sender, EventArgs e)
        {
            MessageBox.Show("Nope wrong answer, Try Again!");
            checkBox3.Checked = false; // clears the box
        }

        private void CheckInt_Click2(object sender, EventArgs e)
        {
            int selectedWeight = (int)NumUpDown.Value;
            if (selectedWeight == 3)
            {
                MessageBox.Show("Yes, that weight is CORRECT!");
            }
            else
            {
                MessageBox.Show("That weight is WRONG, Try Again!");
            }
        }

        private void SanrioGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
                                                                
   
