
namespace Mystery_Battle_.Net_Game
{
    public partial class Form1 : Form
    {

        // Declare variables

        // Player choice and Robo choice:
        string playerChoice;
        string roboChoice;

        // Create an array of choices (total of 18 here instead of 3 to allow for more randomness):
        string[] Choices = { "W", "S", "M", "W", "S", "M", "W", "S", "M", "W", "S", "M", "W", "S", "M", "W", "S", "M" };

        // Instantiate random number generator using system-supplied value as seed:
        Random random = new Random();

        // Scoring variables:
        int playerScore;
        int roboScore;
        string draw;

        public Form1()
        {
            InitializeComponent();
        }

        // MakeChoiceEvent for all three buttons: Wizard, Sorceress, Mystery
        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            // Identify the button that triggers the event:

            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;

            // Declare i as random choice starting at index 0 up to length of choices.
            // Set roboChoice to this random choice in the array
            int i = random.Next(0, Choices.Length);
            roboChoice = Choices[i];

            // The labels we named in our design will display the following:
            lblPlayerChoice.Text = "Player is: " + UpdateTextAndImage(playerChoice, PLAYER_PIC);
            lblRoboChoice.Text = "Robo is: " + UpdateTextAndImage(roboChoice, CPU_PIC);

            CheckGame();
        }

        // Goal here to create a method that will return a string with 2 arguments below.
        // Depending on what passes through, the Text and Image will be updated
        private string UpdateTextAndImage(string text, PictureBox pic)
        {
            // Create empty string called word:
            string word = null;

            // Create switch statement checking for 'text' dependent on 3 cases: W, S, M:
            switch (text)
            {
                case "W":
                    word = "Wizard";
                    pic.Image = Properties.Resources.wizard;
                    break;
                case "S":
                    word = "Sorceress";
                    pic.Image = Properties.Resources.sorceress;
                    break;
                case "M":
                    word = "Mystery";
                    pic.Image = Properties.Resources.mystery;
                    break;
            }
            return word;
            
            // After the switch statement runs, it will set up the word and the image then return the word

        }

        /* Create CheckGame method to check 3 conditions of the game: A draw, when Robo wins, and when Player wins 
            Game Notes: 
            1. Sorceress beats Wizard
            2. Wizard beats Mystery 
            3. Mystery beats Sorceress
        */
        private void CheckGame()
        {


            if (roboChoice == playerChoice)
            {
                draw = " Draw!";
                lblPlayerWins.Visible = false;
                lblRoboWins.Visible = false;
                lblDraw.Visible = true;
                lblDraw.Text = "We are NOT EQUALS!" + Environment.NewLine + "AGAIN!";

            }
            else if (playerChoice == "W" && roboChoice == "S" || playerChoice == "M" && roboChoice == "W" || playerChoice == "S" && roboChoice == "M")
            {
                roboScore++;
                draw = null;
                lblDraw.Visible = false;
                lblPlayerWins.Visible = false;
                lblRoboWins.Visible = true;
                lblRoboWins.Text = "I will destroy you!" + Environment.NewLine + "MUWAHAHA..";
 
            } else
            {
                playerScore++;
                draw = null;
                lblDraw.Visible = false;
                lblRoboWins.Visible = false;
                lblPlayerWins.Visible = true;
                lblPlayerWins.Text = "Eat my spells!" + Environment.NewLine + "TeHeheHe..";
            }

            lblRoboResult.Text = "Robo Score: " + roboScore + Environment.NewLine + draw;
            lblPlayerResult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
        }

    }
}