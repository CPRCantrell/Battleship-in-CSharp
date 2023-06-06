class Battleship
{
    public void Run()
    {
        this.Welcome();
        do
        {
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

    private bool PlayAgain()
    {
        string[] acceptableYes = {"again", "yes", "yea", "y"};
        string[] acceptableNo = {"done", "no", "naw", "n"};

        while(true)
        {
            Console.Write("Would you like to play again: ");
            try
            {
                string response = Console.ReadLine().Split(" ").Where(character => character != "").ToArray()[0].ToLower();
                Console.WriteLine(response);

                foreach(string answer in acceptableYes)
                    if(answer == response)
                        return true;

                foreach(string answer in acceptableNo)
                    if(answer == response)
                        return false;
            }
            catch(IndexOutOfRangeException){}

            Console.WriteLine($"Invalid Entry! Acceptable Answers are [{string.Join(", ", acceptableYes)}] or [{string.Join(", ", acceptableNo)}]");
        }
    }

    private void GameLoop()
    {

    }

}