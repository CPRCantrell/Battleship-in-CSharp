class Battleship
{
    private Player playerOne, playerTwo;

    public void Run()
    {
        this.Welcome();
        do
        {
            this.HumanOrAiPlayers();
            this.GameLoop();
        }
        while(this.PlayAgain());
    }

    private void Welcome()
    {
        string welcomeTitle = "- Welcome to BattleShip -";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (welcomeTitle.Length / 2)) + "}", welcomeTitle));
        Console.WriteLine("\nBattleship is a classic game of setting up your board with your fleet and go to war against an opponent. Each player will take turns naming corrdinates in hopes of striking your Oppnents ship,and once struck you will get another turn until you miss. Plan carefully and Have fun!");
        Console.Write("\n\nPress ENTER to start...");
        while(Console.ReadKey(true).Key != ConsoleKey.Enter)
            continue;
    }

    private string HumanOrAiPlayers()
    {
        Console.WriteLine("Select player set-up: \n1> Human v Human \n2> Human v Ai \n3>Ai v Ai \n");
        string[] options = {"1", "2", "3"};
        return this.CollectValidatedInput(options, "Which do you choose: ");
    }

    private void GameLoop()
    {
        int round = 1;
        do {
            if(round%2 == 0)
                this.playerTwo.PlayTurn();
            else
                this.playerOne.PlayTurn();
            ++round;
        } while(this.playerOne.Winner() || this.playerTwo.Winner());
    }

    private bool PlayAgain()
    {
        string[] acceptableYes = {"again", "yes", "yea", "y"};
        string[] acceptableNo = {"done", "no", "naw", "n"};

        while(true)
        {
            string response = this.CollectValidatedInput(acceptableYes.Concat(acceptableNo).ToArray(), "Would you like to play again: ");

            foreach(string answer in acceptableYes)
                if(answer == response)
                    return true;

            foreach(string answer in acceptableNo)
                if(answer == response)
                    return false;


        }
    }

    private string CollectValidatedInput(string[] acceptableAnswers, string prompt)
    {
        while(true)
        {
            try
            {
                Console.WriteLine(prompt);
                string response = Console.ReadLine().Split(" ").Where(character => character != "").ToArray()[0].ToLower();

                foreach(string answer in acceptableAnswers)
                    if(response == answer)
                        return answer;
            }
            catch(IndexOutOfRangeException){}

            Console.WriteLine($"Invalid Entry! Acceptable Answers are [{string.Join(", ", acceptableAnswers)}]");
        }
    }
}