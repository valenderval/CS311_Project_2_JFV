using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CS311_Project_2_JFV
{
    public partial class frmMain : Form
    {
        float initialBank = 100;
        float currentBank;
        float currentBet;
        int die1;
        int die2;
        public frmMain()
        {
            InitializeComponent();
        }//end frmMain

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (currentBank < currentBet)
            {
                Console.WriteLine("Not enough money in Bank.");
            }
            else
            {
                calculateScore();
            }
        }//end roll

        private void calculateScore()
        {
            Random rdmDie = new Random();
            die1 = rdmDie.Next(1, 7);
            die2 = rdmDie.Next(1, 7);
            int sum = die1 + die2;
            lblDie1.Text = "Die I\n" + die1.ToString();
            lblDie2.Text = "Die II\n" + die2.ToString();


            // Determine the outcome of the game
            if (sum == 7 || sum == 11)
            {
                lblResult.Text = "You win!";
                currentBank += 10; // Add money to bank
                lblBank.Text = "Bank: " + currentBank;
            }
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                lblResult.Text = "You lose!";
                currentBank -= 10; // Subtract money from bank
                lblBank.Text = "Bank: " + currentBank;
            }
            else
            {
                // Game continues if point is established
                int point = sum;
                lblResult.Text = "Point is: " + point;
                bool gameContinues = true;
                while (gameContinues)
                {
                    die1 = rdmDie.Next(1, 7);
                    die2 = rdmDie.Next(1, 7);
                    sum = die1 + die2;

                    if (sum == point)
                    {
                        lblResult.Text = "You win!";
                        currentBank += 10; // Add money to bank
                        lblBank.Text = "Bank: " + currentBank;
                        gameContinues = false;
                    }
                    else if (sum == 7)
                    {
                        lblResult.Text = "Craps! You lose!";
                        currentBank -= 10; // Subtract money from bank
                        lblBank.Text = "Bank: " + currentBank;
                        gameContinues = false;
                    }
                }
            }
            txtBet.Clear();
        }   // end calculateScore

        private void txtBet_TextChanged(object sender, EventArgs e)
        {
            
        }//end txtBet_txtChanged

    }//end main
}//end Namespace
